using Syroot.BinaryData.Memory;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Database.Entities;

public class TableRow
{
    public List<object> Cells { get; set; } = new List<object>();

    public void ReadRow(List<TableColumn> columns, Span<byte> rowBytes, IdDatabase? idDatabase)
    {
        SpanReader sr = new SpanReader(rowBytes);
        for (int j = 0; j < columns.Count; j++)
        {
            TableColumn col = columns[j];

            switch (col.Type)
            {
                case DBColumnType.RawString:
                    {
                        byte[] data = sr.ReadBytes(col.StringLength);
                        Cells.Add(Encoding.UTF8.GetString(data).TrimEnd('\0'));
                    }
                    break;
                case DBColumnType.HashString:
                    uint hash = sr.ReadUInt32();
                    if (idDatabase is not null && idDatabase.Hashes.TryGetValue(hash, out string? val))
                        Cells.Add(val);
                    else
                        Cells.Add(hash.ToString("X8"));
                    break;
                case DBColumnType.StringPointer:
                    {
                        long currentOffset = sr.Position;
                        long strOffset = sr.ReadInt64();

                        sr.Position = (int)currentOffset + (int)strOffset;
                        Cells.Add(sr.ReadString0());
                        sr.Position = (int)currentOffset + 8;
                    }
                    break;
                case DBColumnType.Int64:
                    Cells.Add(sr.ReadUInt64());
                    break;
                case DBColumnType.HexUInt:
                    {
                        uint hexVal = sr.ReadUInt32();
                        Cells.Add(hexVal.ToString("X8"));
                    }
                    break;
                case DBColumnType.Int:
                    Cells.Add(sr.ReadInt32());
                    break;
                case DBColumnType.Short:
                    Cells.Add(sr.ReadInt16());
                    break;
                case DBColumnType.UInt:
                    Cells.Add(sr.ReadUInt32());
                    break;
                case DBColumnType.Float:
                    Cells.Add(sr.ReadSingle());
                    break;
                case DBColumnType.Double:
                    Cells.Add(sr.ReadDouble());
                    break;
                case DBColumnType.SByte:
                    Cells.Add(sr.ReadSByte());
                    break;
                case DBColumnType.Byte:
                    Cells.Add(sr.ReadByte());
                    break;
                case DBColumnType.UShort:
                    Cells.Add(sr.ReadUInt16());
                    break;

                default:
                    throw new NotImplementedException($"Type {col.Type} is invalid or not supported.");
            }
        }
    }
}
