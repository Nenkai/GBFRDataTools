using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBFRDataTools.Database.Entities;
using Syroot.BinaryData;
using Syroot.BinaryData.Memory;

namespace GBFRDataTools.Database;

public class DataTable
{
    public string Name { get; set; }

    public List<TableColumn> Columns { get; set; }
    public List<TableRow> Rows { get; set; } = [];

    static Dictionary<uint, string> hashes = new Dictionary<uint, string>();

    static DataTable()
    {
        using var sr = new StreamReader(@"C:\Users\nenkai\source\repos\GRBFDataTools\GBFRDataTools\bin\Debug\net8.0\hashlist.txt");
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

    public void Read(string path)
    {
        string fileName = Path.GetFileNameWithoutExtension(path);
        string hdrFile = TableMappingReader.GetHeadersFile(fileName);

        Columns = TableMappingReader.ReadColumnMappings(hdrFile, out int readSize);

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
                        row.Cells.Add(sr.ReadStringRaw(col.StringLength).TrimEnd('\0'));
                        break;
                    case DBColumnType.HashString:
                        uint hash = sr.ReadUInt32();
                        if (hashes.TryGetValue(hash, out string val))
                            row.Cells.Add(val);
                        else
                            row.Cells.Add(hash.ToString("X8"));
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
                    case DBColumnType.UInt:
                        row.Cells.Add(sr.ReadUInt32());
                        break;
                    case DBColumnType.Float:
                        row.Cells.Add(sr.ReadSingle());
                        break;
                    case DBColumnType.Double:
                        row.Cells.Add(sr.ReadDouble());
                        break;
                    case DBColumnType.Byte:
                        row.Cells.Add(sr.ReadByte());
                        break;
                    case DBColumnType.Short:
                        row.Cells.Add(sr.ReadUInt16());
                        break;

                    default:
                        break;
                }
            }

            Rows.Add(row);
        }
    }
}
