using System;
using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database.Generator;

public static class TypeParser
{
    extension(DBColumnType dBColumnType)
    {
        public string AsCsharpType()
            => dBColumnType switch
            {
                DBColumnType.SByte => typeof(sbyte).Name,
                DBColumnType.Byte => typeof(byte).Name,
                DBColumnType.Short => typeof(short).Name,
                DBColumnType.UShort => typeof(ushort).Name,
                DBColumnType.Int => typeof(int).Name,
                DBColumnType.UInt => typeof(uint).Name,
                DBColumnType.HexUInt => typeof(string).Name,
                DBColumnType.Float => typeof(float).Name,
                DBColumnType.Int64 => typeof(long).Name,
                DBColumnType.Double => typeof(double).Name,
                DBColumnType.String => typeof(string).Name,
                DBColumnType.RawString => typeof(string).Name,
                DBColumnType.HashString => typeof(string).Name,
                DBColumnType.StringPointer => typeof(string).Name,
                _ => throw new NotImplementedException(),
            };

        public bool IsPointerType
            => dBColumnType switch
            {
                DBColumnType.StringPointer => true,
                _ => false
            };
    }

    public static string[] ReadType(TableColumn tc)
        => tc.Type switch
        {
            DBColumnType.SByte => ReadPodType(tc),
            DBColumnType.Byte => ReadPodType(tc),
            DBColumnType.Short => ReadPodType(tc),
            DBColumnType.UShort => ReadPodType(tc),
            DBColumnType.Int => ReadPodType(tc),
            DBColumnType.UInt => ReadPodType(tc),
            DBColumnType.HexUInt => ReadStringType(tc),
            DBColumnType.Float => ReadPodType(tc),
            DBColumnType.Int64 => ReadPodType(tc),
            DBColumnType.Double => ReadPodType(tc),
            DBColumnType.String => ReadStringType(tc),
            DBColumnType.RawString => ReadStringType(tc),
            DBColumnType.HashString => ReadStringType(tc),
            DBColumnType.StringPointer => ReadStringType(tc),
            _ => throw new NotImplementedException(),
        };

    private static string[] ReadPodType(TableColumn tc)
    {
        return [$"{tc.Name} = sr.Read" + tc.Type switch
        {
            DBColumnType.SByte => tc.Type.AsCsharpType(),
            DBColumnType.Byte => tc.Type.AsCsharpType(),
            DBColumnType.Short => tc.Type.AsCsharpType(),
            DBColumnType.UShort => tc.Type.AsCsharpType(),
            DBColumnType.Int => tc.Type.AsCsharpType(),
            DBColumnType.UInt => tc.Type.AsCsharpType(),
            DBColumnType.Float => tc.Type.AsCsharpType(),
            DBColumnType.Int64 => tc.Type.AsCsharpType(),
            DBColumnType.Double => tc.Type.AsCsharpType(),
            _ => throw new NotImplementedException(),
        } + "();"];
    }

    private static string[] ReadStringType(TableColumn tc)
    {
        if (tc.Type == DBColumnType.HexUInt || tc.Type == DBColumnType.HashString)
        {
            return [
                $$"""
                {
                    uint hexVal = sr.ReadUInt32();
                    {{tc.Name}} = hexVal.ToString("X8");
                }
                """
            ];
        }
        else if (tc.Type == DBColumnType.RawString)
        {
            return [
                $$"""
                {
                    byte[] data = sr.ReadBytes({{tc.StringLength}});
                    {{tc.Name}} = Encoding.UTF8.GetString(data).TrimEnd('\0');
                }
                """
            ];
        }
        else if (tc.Type == DBColumnType.StringPointer)
        {
            return [
                $$"""
                {
                    long currentOffset = sr.Position;
                    long strOffset = sr.ReadInt64();

                    sr.Position = (int)currentOffset + (int)strOffset;
                    {{tc.Name}} = sr.ReadString0();
                    sr.Position = (int)currentOffset + 8;
                }
                """
            ];
        }

        throw new NotImplementedException();
    }

    public static string[] WriteType(TableColumn tc)
        => tc.Type switch
        {
            DBColumnType.SByte => WritePodType(tc),
            DBColumnType.Byte => WritePodType(tc),
            DBColumnType.Short => WritePodType(tc),
            DBColumnType.UShort => WritePodType(tc),
            DBColumnType.Int => WritePodType(tc),
            DBColumnType.UInt => WritePodType(tc),
            DBColumnType.HexUInt => WriteStringType(tc),
            DBColumnType.Float => WritePodType(tc),
            DBColumnType.Int64 => WritePodType(tc),
            DBColumnType.Double => WritePodType(tc),
            DBColumnType.String => WriteStringType(tc),
            DBColumnType.RawString => WriteStringType(tc),
            DBColumnType.HashString => WriteStringType(tc),
            DBColumnType.StringPointer => WriteStringType(tc),
            _ => throw new NotImplementedException(),
        };

    private static string[] WritePodType(TableColumn tc)
        => [
            $$"""
            bs.Write{{tc.Type.AsCsharpType()}}({{tc.Name}});
            """
        ];

    private static string[] WriteStringType(TableColumn tc)
    {
        if (tc.Type == DBColumnType.HexUInt || tc.Type == DBColumnType.HashString)
        {
            return [
                $$"""
                {
                    uint hexVal = Convert.ToUInt32({{tc.Name}}, 16);
                    bs.WriteUInt32(hexVal);
                }
                """
            ];
        }
        else if (tc.Type == DBColumnType.RawString)
        {
            return [
                $$"""
                {
                    byte[] buf = new byte[{{tc.StringLength}}];
                    Encoding.UTF8.GetBytes({{tc.Name}}, buf);
                    bs.WriteBytes(buf);
                }
                """
            ];
        }
        else if (tc.Type == DBColumnType.StringPointer)
        {
            return [
                $$"""
                {                            
                    bs.WriteInt64(lastStrPtrOffset - bs.Position);
                    long currentPos = bs.Position;
                    bs.Position = lastStrPtrOffset;
                    bs.WriteString({{tc.Name}}, StringCoding.ZeroTerminated);
                    lastStrPtrOffset = bs.Position;
                    bs.Position = currentPos;
                }
                """
            ];
        }

        throw new NotImplementedException();
    }
}
