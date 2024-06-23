using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;
using Syroot.BinaryData.Memory;

using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database;

/// <summary>
/// Represents a game table.
/// </summary>
public class DataTable
{
    /// <summary>
    /// Row size for the table.
    /// </summary>
    public int RowSize;

    /// <summary>
    /// Columns for the table.
    /// </summary>
    public List<TableColumn> Columns { get; set; }

    /// <summary>
    /// Rows for the table.
    /// </summary>
    public List<TableRow> Rows { get; set; } = [];

    /// <summary>
    /// Reads the specified table file.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="version"></param>
    /// <exception cref="InvalidDataException"></exception>
    public void Read(string path, Version version)
    {
        string fileName = Path.GetFileNameWithoutExtension(path);
        string hdrFile = TableMappingReader.GetHeadersFilePath(fileName);

        Columns = TableMappingReader.ReadColumnMappings(hdrFile, version, out RowSize);


        byte[] file = File.ReadAllBytes(path);
        var sr = new SpanReader(file);

        long rowCount = sr.ReadInt64();

        if (!fileName.EndsWith("_str") && 8 + (RowSize * rowCount) != file.Length)
            throw new InvalidDataException($"Table {fileName} did not match expected size, it's larger");

        for (int i = 0; i < rowCount; i++)
        {
            var row = new TableRow();
            row.ReadRow(Columns, file.AsSpan(8 + (i * RowSize)));
            Rows.Add(row);
        }
    }
    
    /// <summary>
    /// Saves the current table.
    /// </summary>
    /// <param name="path"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void Save(string path)
    {
        Console.WriteLine($"Creating {path} ({Rows.Count} rows)");
        using var fs = File.Create(path);
        using var bs = new BinaryStream(fs);

        bs.WriteUInt64((ulong)Rows.Count);

        long lastStrPtrOffset = bs.Position + (RowSize * Rows.Count);

        foreach (TableRow row in Rows)
        {
            for (int i = 0; i < Columns.Count; i++)
            {
                TableColumn col = Columns[i];
                object value = row.Cells[i];

                switch (col.Type)
                {
                    case DBColumnType.RawString:
                        {
                            byte[] buf = new byte[col.StringLength];
                            Encoding.UTF8.GetBytes((string)value, buf);
                            bs.WriteBytes(buf);
                        }
                        break;
                    case DBColumnType.StringPointer:
                        {
                            bs.WriteInt64(lastStrPtrOffset - bs.Position);
                            long currentPos = bs.Position;

                            bs.Position = lastStrPtrOffset;
                            bs.WriteString((string)value, StringCoding.ZeroTerminated);
                            lastStrPtrOffset = bs.Position;
                            bs.Position = currentPos;
                        }
                        break;
                    case DBColumnType.HashString:
                    case DBColumnType.HexUInt:
                    case DBColumnType.UInt:
                        bs.WriteUInt32((uint)value);
                        break;
                    case DBColumnType.Int64:
                        bs.WriteInt64((long)value);
                        break;
                    case DBColumnType.Int:
                        bs.WriteInt32((int)value);
                        break;
                    case DBColumnType.Float:
                        bs.WriteSingle((float)value);
                        break;
                    case DBColumnType.Byte:
                        bs.WriteByte((byte)value);
                        break;
                    case DBColumnType.SByte:
                        bs.WriteSByte((sbyte)(int)value);
                        break;
                    case DBColumnType.Short:
                        bs.WriteInt16((short)value);
                        break;
                    case DBColumnType.UShort:
                        bs.WriteUInt16((ushort)value);
                        break;
                    default:
                        throw new NotImplementedException($"Type {col.Type} is invalid or not supported.");
                }
            }
        }
    }
}

