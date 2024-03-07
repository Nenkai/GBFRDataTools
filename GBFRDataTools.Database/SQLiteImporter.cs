using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Globalization;

using Microsoft.Data.Sqlite;
using Syroot.BinaryData;

using GBFRDataTools.Hashing;
using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database;

public class SQLiteImporter
{
    private string _sqliteFile;

    private SqliteConnection _con;
    private GameDatabase _database = new();

    public SQLiteImporter(string sqliteFile)
    {
        _sqliteFile = sqliteFile;
    }

    public GameDatabase Import()
    {
        _con = new SqliteConnection($"Data Source={_sqliteFile}");
        _con.Open();

        CreateTables();
        FillTables();

        return _database;
    }

    public void CreateTables()
    {
        var command = _con.CreateCommand();
        command.CommandText = $"SELECT name FROM sqlite_schema WHERE type ='table' AND name NOT LIKE 'sqlite_%';";
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            string tableName = (string)reader["name"];
            _database.Tables.Add(tableName, new DataTable());
        }
    }

    public void FillTables()
    {
        foreach (KeyValuePair<string, DataTable> table in _database.Tables)
        {
            var headerFileName = TableMappingReader.GetHeadersFile(table.Key);
            if (string.IsNullOrEmpty(headerFileName))
                continue;

            var dataTable = table.Value;
            dataTable.Columns = TableMappingReader.ReadColumnMappings(headerFileName, out int rowSize);
            dataTable.RowSize = rowSize;

            var command = _con.CreateCommand();
            command.CommandText = $"SELECT * FROM {table.Key};";
            var reader = command.ExecuteReader();

            if (dataTable.Columns.Count != reader.FieldCount)
                throw new InvalidDataException($"Mismatched amount of columns for table {table.Key}");

            Console.WriteLine($"Reading from {table.Key}...");
            
            while (reader.Read())
            {
                var row = new TableRow();

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    switch (dataTable.Columns[i].Type)
                    {
                        case DBColumnType.HashString:
                            {
                                string value = reader.GetString(i);
                                if (value.Length == 8 && uint.TryParse(value, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint val))
                                    row.Cells.Add(val);
                                else
                                    row.Cells.Add(XXHash32Custom.Hash(value));
                            }
                            break;
                        case DBColumnType.RawString:
                        case DBColumnType.StringPointer:
                            {
                                string value = reader.GetString(i);
                                row.Cells.Add(value);
                            }
                            break;
                        case DBColumnType.Int:
                            {
                                int value = (int)reader.GetInt64(i);
                                row.Cells.Add(value);
                            }
                            break;
                        case DBColumnType.HexUInt:
                            {
                                string value = reader.GetString(i);
                                if (value.Length == 8 && uint.TryParse(value, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint val))
                                    row.Cells.Add(val);
                                else
                                    throw new InvalidDataException("Hex UInt value is incorrect");
                            }
                            break;
                        case DBColumnType.UInt:
                            {
                                uint value = (uint)reader.GetInt32(i);
                                row.Cells.Add(value);
                            }
                            break;
                        case DBColumnType.Int64:
                            {
                                long value = reader.GetInt64(i);
                                row.Cells.Add(value);
                            }
                            break;
                        case DBColumnType.Float:
                            {
                                float value = reader.GetFloat(i);
                                row.Cells.Add(value);
                            }
                            break;
                        case DBColumnType.Short:
                            {
                                short value = (short)reader.GetInt64(i);
                                row.Cells.Add(value);
                            }
                            break;
                        case DBColumnType.Byte:
                            {
                                byte value = reader.GetByte(i);
                                row.Cells.Add(value);
                            }
                            break;
                        default:
                            throw new Exception("Unexpected type");
                            break;
                    }
                }

                dataTable.Rows.Add(row);
            }
        }
    }
}

