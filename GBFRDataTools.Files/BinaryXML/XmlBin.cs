using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using Syroot.BinaryData;

namespace GBFRDataTools.Files.BinaryXML;

public class XmlBin
{
    public const uint MAGIC = 0x42584D00;
    public const ushort BINXML_ATTR_INVALID = 0xFFFF;

    // Note: Struct names/fields from reverse engineered game (Vanquish) with debug symbols

    /// <summary>
    /// Reads a PlatinumGames binary xml (.bxm) file from stream into a <see cref="XmlDocument"/>.
    /// </summary>
    /// <param name="stream"></param>
    /// <returns></returns>
    /// <exception cref="InvalidDataException"></exception>
    public static XmlDocument Read(Stream stream)
    {
        XmlDocument doc = new XmlDocument();

        using var bs = new BinaryStream(stream, ByteConverter.Big);
        if (bs.ReadUInt32() != MAGIC)
            throw new InvalidDataException("Not a valid BXM (Binary XML) file.");

        // XmlBinHeader
        uint veropt = bs.ReadUInt32();
        uint numElem = bs.ReadUInt16();
        uint numAttr = bs.ReadUInt16();
        uint sizeText = bs.ReadUInt32();

        List<XmlBinElem> nodes = new List<XmlBinElem>();
        for (int i = 0; i < numElem; i++)
        {
            XmlBinElem bxmlNode = new()
            {
                NumChild = bs.ReadUInt16(),
                IdxChild = bs.ReadUInt16(),
                NumAttr = bs.ReadUInt16(),
                IdxAttr = bs.ReadUInt16(),
            };

            nodes.Add(bxmlNode);
        }

        int kvOffset = (int)bs.Position;
        int actualDataOffset = (int)(bs.Position + (numAttr * 4));

        List<XmlBinAttr16> datas = new List<XmlBinAttr16>();
        for (int i = 0; i < numAttr; i++)
        {
            bs.Position = kvOffset + (i * 0x04);

            XmlBinAttr16 data = new()
            {
                KeyOffset = bs.ReadUInt16(),
                ValueOffset = bs.ReadUInt16(),
            };

            if (data.KeyOffset != BINXML_ATTR_INVALID)
            {
                bs.Position = actualDataOffset + data.KeyOffset;
                data.Key = bs.ReadString(StringCoding.ZeroTerminated);
            }

            if (data.ValueOffset != BINXML_ATTR_INVALID)
            {
                bs.Position = actualDataOffset + data.ValueOffset;
                data.Value = bs.ReadString(StringCoding.ZeroTerminated);
            }
            datas.Add(data);
        }

        ProcessChildNode(nodes, datas, nodes[0], doc, null!);

        return doc;
    }

    private static void ProcessChildNode(List<XmlBinElem> flattenedNodeList, List<XmlBinAttr16> dataList, XmlBinElem bxmlNode, XmlDocument xmlDoc, XmlElement parentXmlElem)
    {
        XmlElement newElem = xmlDoc.CreateElement(dataList[bxmlNode.IdxAttr].Key);
        if (!string.IsNullOrEmpty(dataList[bxmlNode.IdxAttr].Value))
            newElem.Value = dataList[bxmlNode.IdxAttr].Value;

        if (parentXmlElem is null)
            xmlDoc.AppendChild(newElem);
        else
            parentXmlElem.AppendChild(newElem);

        for (int i = 0; i < bxmlNode.NumAttr; i++)
        {
            XmlBinAttr16 attrKv = dataList[bxmlNode.IdxAttr + 1 + i];
            newElem.SetAttribute(attrKv.Key, attrKv.Value);
        }

        for (int i = 0; i < bxmlNode.NumChild; i++)
            ProcessChildNode(flattenedNodeList, dataList, flattenedNodeList[bxmlNode.IdxChild + i], xmlDoc, newElem);
    }

    /// <summary>
    /// Writes a <see cref="XmlDocument"/> into a stream as binary xml (.bxm).
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="document"></param>
    public static void Write(Stream stream, XmlDocument document)
    {
        using var bs = new BinaryStream(stream, ByteConverter.Big);
        bs.Position = 0x10;

        // Build lists
        List<XmlBinElem> nodeList = new List<XmlBinElem>();
        List<XmlBinAttr16> kvList = new List<XmlBinAttr16>();

        foreach (XmlElement node in document.ChildNodes)
        {
            WriteNode(nodeList, kvList, node);
        }

        // Start writing
        for (int i = 0; i < nodeList.Count; i++)
        {
            if (nodeList[i].NumChild == 0)
                nodeList[i].IdxChild = (ushort)nodeList.Count;

            bs.WriteInt16((short)nodeList[i].NumChild);
            bs.WriteInt16((short)nodeList[i].IdxChild);
            bs.WriteInt16((short)nodeList[i].NumAttr);
            bs.WriteInt16((short)nodeList[i].IdxAttr);
        }

        int kvListOffset = (int)bs.Position;
        int startKvDataOffset = (int)kvListOffset + (kvList.Count * 0x4);
        int kvDataOffset = startKvDataOffset;

        Dictionary<string, ushort> strToOffset = new Dictionary<string, ushort>();

        for (int i = 0; i < kvList.Count; i++)
        {
            XmlBinAttr16 kv = kvList[i];

            bs.Position = kvDataOffset;

            if (!strToOffset.TryGetValue(kv.Key, out ushort keyOffset))
            {
                kv.KeyOffset = (ushort)(kvDataOffset - startKvDataOffset);
                strToOffset.Add(kv.Key, kv.KeyOffset);

                bs.WriteString(kv.Key, StringCoding.ZeroTerminated);
                kvDataOffset = (ushort)bs.Position;
            }
            else
                kv.KeyOffset = (ushort)keyOffset;

            if (!string.IsNullOrEmpty(kv.Value))
            {
                if (!strToOffset.TryGetValue(kv.Value, out ushort valueOffset))
                {
                    kv.ValueOffset = (ushort)(kvDataOffset - startKvDataOffset);
                    strToOffset.Add(kv.Value, kv.ValueOffset);

                    bs.WriteString(kv.Value, StringCoding.ZeroTerminated);
                    kvDataOffset = (ushort)bs.Position;
                }
                else
                    kv.ValueOffset = (ushort)valueOffset;
            }
            else
                kv.ValueOffset = BINXML_ATTR_INVALID;

            bs.Position = kvListOffset + (i * 0x04);
            bs.WriteInt16((short)kvList[i].KeyOffset);
            bs.WriteInt16((short)kvList[i].ValueOffset);
        }

        // Finish header (0x10)
        bs.Position = 0;
        bs.WriteUInt32(MAGIC);
        bs.WriteUInt32(0); // Flags?
        bs.WriteInt16((short)nodeList.Count);
        bs.WriteInt16((short)kvList.Count);
        bs.WriteInt32(kvDataOffset - startKvDataOffset);
    }

    private static void WriteNode(List<XmlBinElem> flattenedElemList, List<XmlBinAttr16> attrList, XmlElement node)
    {
        var bxmlNode = new XmlBinElem()
        {
            NumChild = (ushort)node.ChildNodes.Count,
            NumAttr = (ushort)node.Attributes.Count,
            IdxAttr = (ushort)attrList.Count,
            IdxChild = (ushort)(flattenedElemList.Count + 1),
        };
        flattenedElemList.Add(bxmlNode);

        var attr16 = new XmlBinAttr16()
        {
            Key = node.Name,
            Value = node.Value,
        };
        attrList.Add(attr16);

        foreach (XmlAttribute attr in node.Attributes)
        {
            attrList.Add(new XmlBinAttr16()
            {
                Key = attr.Name,
                Value = attr.Value,
            });
        }

        foreach (XmlElement childNode in node.ChildNodes)
            WriteNode(flattenedElemList, attrList, childNode);
    }
}
