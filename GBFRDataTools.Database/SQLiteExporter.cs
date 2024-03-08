using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.Sqlite;

using Syroot.BinaryData.Memory;
using Syroot.BinaryData;

using GBFRDataTools.Database;
using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database;

public class SQLiteExporter
{
    public GameDatabase _database;
    private SqliteConnection _con;

    public SQLiteExporter(GameDatabase database)
    {
        _database = database;
    }

    public void ExportTables(string sqliteDbFile)
    {
        _con = new SqliteConnection($"Data Source={sqliteDbFile}");
        _con.Open();

        foreach (var table in _database.Tables) 
        {
            ExportTableToSQLite(table.Key, table.Value.Columns, table.Value.Rows);
        }

        _con.Close();
        _con.Dispose();
    }


    public void ExportTableToSQLite(string name, List<TableColumn> columns, List<TableRow> rows)
    {
        //SQL: DROP TABLE IF EXISTS
        var command = _con.CreateCommand();
        command.CommandText = $"DROP TABLE IF EXISTS \"{name}\";";

#if DONT_RUN_SQL
        Console.WriteLine($"Skipping DROP TABLE IF EXISTS for '{name}'.");
        command.Cancel();
#else
        Console.WriteLine($"Running DROP TABLE IF EXISTS for '{name}'.");
        command.ExecuteNonQuery();
#endif


        //SQL: CREATE TABLE
        string tableDefinition = $"CREATE TABLE \"{name}\" (\n";
        foreach (TableColumn column in columns)
        {
            tableDefinition += $"    \"{column.Name}\" {DBUtils.TypeToSQLiteTypeName(column.Type)},\n";
        }

        tableDefinition = tableDefinition.Remove(tableDefinition.Length - 2); // replace trailing comma
        tableDefinition += "\n";
        tableDefinition += ");";

#if PRINT_SQL_QUERIES
        Console.WriteLine(tableDefinition);
#endif
        command = _con.CreateCommand();
        command.CommandText = tableDefinition;
#if DONT_RUN_SQL
        Console.WriteLine($"Skipping CREATE TABLE for '{name}'.");
        command.Cancel();
#else
        Console.WriteLine($"Running CREATE TABLE for '{name}'.");
        command.ExecuteNonQuery();
#endif

        //SQL: INSERT INTO
        if (rows.Count > 0)
        {
            string insertDefinition = $"INSERT INTO \"{name}\" (";
            foreach (TableColumn header in columns)
            {
                insertDefinition += $"\"{header.Name}\", ";
            }
            insertDefinition = insertDefinition.Remove(insertDefinition.Length - 2); // replace trailing comma
            insertDefinition += ")\n" +
                                "VALUES\n";

            for (int entryCounter = 0; entryCounter < rows.Count; entryCounter++)
            {
                insertDefinition += "    (";
                var row = rows[entryCounter];

                for (int i = 0; i < columns.Count; i++)
                {
                    TableColumn column = columns[i];

                    insertDefinition += column.Type switch
                    {
                        DBColumnType.String or DBColumnType.RawString or DBColumnType.HashString or DBColumnType.HexUInt or DBColumnType.StringPointer
                            => $"'{((string)row.Cells[i]).Replace("'", "''")}', ",
                        DBColumnType.Int => $"{(int)row.Cells[i]}, ",
                        DBColumnType.UInt => $"{(uint)row.Cells[i]}, ",
                        DBColumnType.Float => $"{(float)row.Cells[i]}, ",
                        DBColumnType.Int64 => $"{(ulong)row.Cells[i]}, ",
                        DBColumnType.Short => $"{(ushort)row.Cells[i]}, ",
                        DBColumnType.Byte => $"{(byte)row.Cells[i]}, ",
                        DBColumnType.Double => $"{(double)row.Cells[i]}, ",
                        _ => throw new InvalidDataException($"Unexpected type '{column.Type}' for column {column.Name} in table {name}")
                    };
                }

                insertDefinition = insertDefinition.Remove(insertDefinition.Length - 2); // replace trailing comma
                insertDefinition += "),\n";

                if (entryCounter % 100 == 99 && entryCounter < rows.Count - 25)
                {
                    insertDefinition = insertDefinition.Remove(insertDefinition.Length - 2); // replace trailing comma
                    insertDefinition += ";\n";

#if PRINT_SQL_QUERIES
                    Console.WriteLine(insertDefinition);
#endif

                    command = _con.CreateCommand();
                    command.CommandText = insertDefinition;
#if DONT_RUN_SQL
                Console.WriteLine($"Skipping early ({(100.0f * entryCounter) / (1.0f * rows.Count)}%) INSERT INTO for '{name}'.");
                command.Cancel();
#else
                    Console.WriteLine($"Running early ({(100.0f * entryCounter) / (1.0f * rows.Count)}%) INSERT INTO for '{name}'.");
                    command.ExecuteNonQuery();
#endif

                    insertDefinition = $"INSERT INTO \"{name}\" (";
                    foreach (TableColumn column in columns)
                    {
                        insertDefinition += $"\"{column.Name}\", ";
                    }
                    insertDefinition = insertDefinition.Remove(insertDefinition.Length - 2); // replace trailing comma
                    insertDefinition += ")\n" +
                                        "VALUES\n";
                }
            }

            insertDefinition = insertDefinition.Remove(insertDefinition.Length - 2); // replace trailing comma
            insertDefinition += ";\n";

            /*
            var errorValue = ((stringDataOffset == 0 ? bs.Length : stringDataOffset) - bs.Position) / entryCount;
            if (errorValue > 0)
            {
                Console.WriteLine($"Warning: Headers for table {name} are incorrect.\n" +
                            $" Entries are {errorValue} byte(s) too large.");
            }
            else if (errorValue < 0)
            {
                Console.WriteLine($"Warning: Headers for table {name} are incorrect.\n" +
                            $" Entries are {Math.Abs(errorValue)} byte(s) too small.");
            }
            */

#if PRINT_SQL_QUERIES
            Console.WriteLine(insertDefinition);
#endif

            command = _con.CreateCommand();
            command.CommandText = insertDefinition;
#if DONT_RUN_SQL
            Console.WriteLine($"Skipping INSERT INTO for '{name}'.");
            command.Cancel();
#else
            Console.WriteLine($"Running INSERT INTO for '{name}'.");
            command.ExecuteNonQuery();
#endif
        }
        Console.WriteLine($"All done for '{name}'.");
    }
}