using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;
using Syroot.BinaryData.Memory;

using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database;

public class DataTable
{
    public string Name { get; set; }

    public int RowSize;
    public List<TableColumn> Columns { get; set; }
    public List<TableRow> Rows { get; set; } = [];

    static Dictionary<uint, string> hashes = new Dictionary<uint, string>();

    static DataTable()
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "ids.txt");
        if (!File.Exists(path))
            throw new FileNotFoundException($"ERROR: ID definition file {path} is missing.");

        using var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "ids.txt"));
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            string[] spl = line.Split('|');
            if (spl.Length == 3)
            {
                if (spl[0].Length != 8)
                    continue;

                uint hash = uint.Parse(spl[0], System.Globalization.NumberStyles.HexNumber);
                hashes.TryAdd(hash, spl[2]);
            }
        }
    }

    public void Read(string path, Version version)
    {
        string fileName = Path.GetFileNameWithoutExtension(path);
        string hdrFile = TableMappingReader.GetHeadersFile(fileName);

        Columns = TableMappingReader.ReadColumnMappings(hdrFile, version, out RowSize);

        byte[] file = File.ReadAllBytes(path);
        var sr = new SpanReader(file);

        long rowCount = sr.ReadInt64();
        for (int i = 0; i < rowCount; i++)
        {
            var row = new TableRow();
            for (int j = 0; j < Columns.Count; j++)
            {
                TableColumn col = Columns[j];

                switch (col.Type)
                {
                    case DBColumnType.RawString:
                        {
                            byte[] data = sr.ReadBytes(col.StringLength);
                            row.Cells.Add(Encoding.UTF8.GetString(data).TrimEnd('\0'));
                        }
                        break;
                    case DBColumnType.HashString:
                        uint hash = sr.ReadUInt32();
                        if (hashes.TryGetValue(hash, out string val))
                            row.Cells.Add(val);
                        else
                            row.Cells.Add(hash.ToString("X8"));
                        break;
                    case DBColumnType.StringPointer:
                        {
                            long currentOffset = sr.Position;
                            long strOffset = sr.ReadInt64();

                            sr.Position = (int)currentOffset + (int)strOffset;
                            row.Cells.Add(sr.ReadString0());
                            sr.Position = (int)currentOffset + 8;
                        }
                        break;
                    case DBColumnType.Int64:
                        row.Cells.Add(sr.ReadUInt64());
                        break;
                    case DBColumnType.HexUInt:
                        {
                            uint hexVal = sr.ReadUInt32();
                            row.Cells.Add(hexVal.ToString("X8"));
                        }
                        break;
                    case DBColumnType.Int:
                        row.Cells.Add(sr.ReadInt32());
                        break;
                    case DBColumnType.Short:
                        row.Cells.Add(sr.ReadInt16());
                        break;
                    case DBColumnType.UInt:
                        row.Cells.Add(sr.ReadUInt32());
                        break;
                    case DBColumnType.Float:
                        row.Cells.Add(sr.ReadSingle());
                        break;
                    case DBColumnType.Double:
                        row.Cells.Add(sr.ReadDouble());
                        break;
                    case DBColumnType.SByte:
                        row.Cells.Add(sr.ReadSByte());
                        break;
                    case DBColumnType.Byte:
                        row.Cells.Add(sr.ReadByte());
                        break;
                    case DBColumnType.UShort:
                        row.Cells.Add(sr.ReadUInt16());
                        break;

                    default:
                        break;
                }
            }

            Rows.Add(row);
        }

        if (!fileName.EndsWith("_str") && sr.Position != sr.Length)
            throw new InvalidDataException($"Table {fileName} did not match expected size, it's larger");
    }

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
                        bs.WriteSByte((sbyte)value);
                        break;
                    case DBColumnType.Short:
                        bs.WriteInt16((short)value);
                        break;
                    case DBColumnType.UShort:
                        bs.WriteUInt16((ushort)value);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}

