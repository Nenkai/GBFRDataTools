using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database
{
    public class DBUtils
    {
        public static string? TypeToSQLiteTypeName(DBColumnType type)
        {
            // can't use a switch for types :(
            if (type == DBColumnType.String || type == DBColumnType.RawString || type == DBColumnType.HashString || type == DBColumnType.HexUInt)
                return "TEXT";
            else if (type == DBColumnType.Byte || type == DBColumnType.Short || type == DBColumnType.Int || type == DBColumnType.UInt || type == DBColumnType.Int64)
                return "INTEGER";
            else if (type == DBColumnType.Float || type == DBColumnType.Double)
                return "REAL";
            else
                return null;
        }

        public static int TypeToSize(DBColumnType type)
        {
            // can't use a switch for types :(
            if (type == DBColumnType.Int64 || type == DBColumnType.Double)
                return 8;
            else if (type == DBColumnType.Int || type == DBColumnType.UInt || type == DBColumnType.Float || type == DBColumnType.HashString || type == DBColumnType.HexUInt)
                return 4;
            else if (type == DBColumnType.Short)
                return 2;
            else if (type == DBColumnType.Byte)
                return 1;

            return -1;
        }

        public static DBColumnType ColumnTypeToType(string str) =>
            str switch
            {
                "raw_string" => DBColumnType.RawString,
                "hash_string" => DBColumnType.HashString,
                "str" or "string" => DBColumnType.String,
                "int8" or "sbyte" => DBColumnType.Byte,
                "int16" or "short" or "2" => DBColumnType.Short,
                "int32" or "int" or "4" => DBColumnType.Int,
                // uint64 isn't supported by sqlite, so it's fine to read as int64
                "int64" or "uint64" or "long" or "ulong" or "8" => DBColumnType.Int64,
                "uint8" or "byte" or "1" => DBColumnType.Byte,
                "uint16" or "ushort" => DBColumnType.Short,
                "uint32" or "uint" => DBColumnType.UInt,
                "hex_uint" => DBColumnType.HexUInt,
                "float" => DBColumnType.Float,
                "double" => DBColumnType.Double,
                _ => throw new InvalidDataException(),
            };


    }
}
