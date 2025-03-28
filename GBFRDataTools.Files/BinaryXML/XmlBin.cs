﻿using System;
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
    public const uint MAGIC_ALT = 0x584d4c00;
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
        uint magic = bs.ReadUInt32();
        if (magic != MAGIC && magic != MAGIC_ALT)
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
            newElem.InnerText = dataList[bxmlNode.IdxAttr].Value;

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

        var rootNode = document; // Node 'document' will be ignored, it's just a placeholder node from the .NET api side
        RecurseXmlNode(nodeList, kvList, rootNode);

        // Start writing
        for (int i = 0; i < nodeList.Count; i++)
        {
            bs.WriteInt16((short)nodeList[i].NumChild);
            bs.WriteInt16((short)nodeList[i].IdxChild);
            bs.WriteInt16((short)nodeList[i].NumAttr);
            bs.WriteInt16((short)nodeList[i].IdxAttr);
        }

        int kvListOffset = (int)bs.Position;
        int startKvDataOffset = kvListOffset + (kvList.Count * 0x4);
        int kvDataOffset = startKvDataOffset;

        Dictionary<string, ushort> strToOffset = new Dictionary<string, ushort>();

        int sizeText = 0;
        if (rootNode != null)
        {
            for (int i = 0; i < kvList.Count; i++)
            {
                XmlBinAttr16 kv = kvList[i];

                bs.Position = kvDataOffset;

                if (!strToOffset.TryGetValue(kv.Key, out ushort keyOffset))
                {
                    kv.KeyOffset = (ushort)(kvDataOffset - startKvDataOffset);
                    strToOffset.Add(kv.Key, kv.KeyOffset);

                    bs.WriteString(kv.Key, StringCoding.ZeroTerminated);
                    kvDataOffset = (int)bs.Position;
                }
                else
                    kv.KeyOffset = keyOffset;

                if (!string.IsNullOrEmpty(kv.Value))
                {
                    if (!strToOffset.TryGetValue(kv.Value, out ushort valueOffset))
                    {
                        kv.ValueOffset = (ushort)(kvDataOffset - startKvDataOffset);
                        strToOffset.Add(kv.Value, kv.ValueOffset);

                        bs.WriteString(kv.Value, StringCoding.ZeroTerminated);
                        kvDataOffset = (int)bs.Position;
                    }
                    else
                        kv.ValueOffset = valueOffset;
                }
                else
                    kv.ValueOffset = BINXML_ATTR_INVALID;

                bs.Position = kvListOffset + (i * 0x04);
                bs.WriteInt16((short)kvList[i].KeyOffset);
                bs.WriteInt16((short)kvList[i].ValueOffset);
            }

            sizeText = kvDataOffset - startKvDataOffset;
        }

        // Finish header (0x10)
        bs.Position = 0;
        bs.WriteUInt32(MAGIC);
        bs.WriteUInt32(0); // Flags?
        bs.WriteInt16((short)nodeList.Count);
        bs.WriteInt16((short)kvList.Count);
        bs.WriteInt32(sizeText);
    }

    /// <summary>
    /// Adds from a System.Xml node
    /// </summary>
    /// <param name="flattenedElemList"></param>
    /// <param name="attrList"></param>
    /// <param name="node"></param>
    private static void AddNodeFromXml(List<XmlBinElem> flattenedElemList, List<XmlBinAttr16> attrList, XmlNode node)
    {
        int nodeCount = 0;
        XmlText text = null;
        for (int i = 0; i < node.ChildNodes.Count; i++)
        {
            if (node.ChildNodes[i] is XmlText xmlText)
            {
                text = xmlText;
                continue;
            }

            nodeCount++;
        }

        var bxmlchildNode = new XmlBinElem()
        {
            NumChild = (ushort)nodeCount,
            NumAttr = (ushort)(node.Attributes?.Count ?? 0),
            IdxAttr = (ushort)attrList.Count,
        };
        flattenedElemList.Add(bxmlchildNode);

        var attr16 = new XmlBinAttr16()
        {
            Key = node.Name,
            Value = text?.Value,
        };
        attrList.Add(attr16);

        if (node.Attributes != null)
        {
            foreach (XmlAttribute attr in node.Attributes)
            {
                attrList.Add(new XmlBinAttr16()
                {
                    Key = attr.Name,
                    Value = attr.Value,
                });
            }
        }
    }

    /// <summary>
    /// Recursively goes through a System.Xml node
    /// </summary>
    /// <param name="flattenedElemList"></param>
    /// <param name="attrList"></param>
    /// <param name="node"></param>
    private static void RecurseXmlNode(List<XmlBinElem> flattenedElemList, List<XmlBinAttr16> attrList, XmlNode node)
    {
        int elemIndex = flattenedElemList.Count;

        foreach (XmlNode childNode in node.ChildNodes)
        {
            if (childNode is XmlText || childNode is XmlDeclaration)
                continue;

            AddNodeFromXml(flattenedElemList, attrList, childNode);
        }

        if (node.ChildNodes.Count == 0)
            flattenedElemList[elemIndex - 1].IdxChild = (ushort)elemIndex;
        else
        {
            int i = 0;
            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode is XmlText || childNode is XmlDeclaration)
                    continue;

                flattenedElemList[elemIndex + i].IdxChild = (ushort)flattenedElemList.Count;
                RecurseXmlNode(flattenedElemList, attrList, childNode);

                i++;
            }
        }
    }
}
