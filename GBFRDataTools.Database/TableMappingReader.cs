using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database;

/// <summary>
/// Utility class for column definition header (.headers) files.
/// </summary>
public class TableMappingReader
{
    public static List<TableColumn> ReadColumnMappings(string tableName, Version version, out int readSize)
    {
        int offset = 0;
        List<TableColumn> columns = IterativeHeadersReader(tableName, ref offset, version);

        readSize = offset;
        return columns;
    }

    public static string? GetHeadersFilePath(string tableName, bool checkSize = false)
    {
        string exePath = Utils.GetCurrentExecutingPath();
        string currentDir = Path.GetDirectoryName(exePath)!;

        string headersFilePath = Path.Combine(currentDir, "Headers", Path.ChangeExtension(tableName, ".headers"));
        if (File.Exists(headersFilePath))
        {
            if (checkSize)
            {
                using var fs = new FileStream(headersFilePath, FileMode.Open);
                if (fs.Length > 0)
                {
                    return headersFilePath;
                }
            }
            else
            {
                return headersFilePath;
            }
        }
        return null;
    }

    private static List<TableColumn> IterativeHeadersReader(string filename, ref int offset, Version inputVersion)
    {
        string path = GetHeadersFilePath(filename);
        using var sr = new StreamReader(path);

        List<TableColumn> columns = new();
        var dir = Path.GetDirectoryName(filename);
        var fn = Path.GetFileNameWithoutExtension(Path.GetFileName(filename));
        int lineNumber = 0;

        Version max_version = null;
        Version min_version = new Version(1, 0, 0);

        while (!sr.EndOfStream)
        {
            lineNumber++;
            var debugln = $"{fn}:{lineNumber}";

            var line = sr.ReadLine()?.Trim();

            // support comments & skip empty lines
            if (string.IsNullOrEmpty(line) || line.StartsWith("//"))
                continue;

            var split = line.Split("|");
            var id = split[0];


            TableColumn column = null;
            if (id == "add_column")
            {
                if (split.Length < 3 || split.Length > 4)
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'add_column' - expected 2 or 3 arguments (name, type, offset?), may break!");

                string columnName = split[1];
                string columnTypeStr = split[2];

                DBColumnType columnType = DBUtils.ColumnTypeToType(columnTypeStr);
                if (columnType == DBColumnType.Unknown)
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'add_column' - type '{columnTypeStr}' is invalid\n" +
                        $"Valid types: str, int8, int16, int32/int, int64, uint8, uint16, uint32/uint, uint64, float, double");

                if (inputVersion < min_version || (max_version != null && inputVersion > max_version))
                    continue;

                column = new TableColumn
                {
                    Name = columnName,
                    Type = columnType
                };

                if (columnType == DBColumnType.RawString)
                {
                    column.StringLength = int.Parse(split[3].Substring(2), System.Globalization.NumberStyles.HexNumber);
                    column.Offset = offset;
                    offset += column.StringLength;
                }
                else
                {
                    if (split.Length == 3)
                        column.Offset = offset;
                    else
                        column.Offset = Convert.ToInt64(split[3], 16);


                    offset += DBUtils.TypeToSize(columnType);
                }

                columns.Add(column);
            }
            else if (id == "padding")
            {
                if (split.Length != 2)
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'padding' - expected 1 argument (length), may break!");

                offset += Convert.ToInt32(split[1], 16);
            }
            else if (id == "set_min_version")
            {
                if (split.Length < 2)
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'set_min_version' - expected 1 arguments (version), may break!");

                if (!Version.TryParse(split[1], out Version ver))
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'set_min_version' - version is invalid - may break!");

                min_version = ver;
            }
            else if (id == "set_max_version")
            {
                if (split.Length < 2)
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'set_max_version' - expected 1 arguments (version), may break!");

                if (!Version.TryParse(split[1], out Version ver))
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'set_max_version' - version is invalid - may break!");

                max_version = ver;
            }
            else if (id == "reset_min_version")
            {
                min_version = new Version(1, 0, 0);
            }
            else if (id == "reset_max_version")
            {
                max_version = null;
            }
            else if (id == "include")
            {
                if (split.Length != 2)
                    Console.WriteLine($"Metadata error: {debugln} has malformed 'include' - expected 1 argument (filename), may break!");

                var headersFilename = GetHeadersFilePath($"{split[1]}.headers");
                if (headersFilename == null)
                {
                    Console.WriteLine($"Metadata error: unknown include file '{split[1]}.headers' - may break!");
                    continue;
                }

                columns.AddRange(IterativeHeadersReader(headersFilename, ref offset, inputVersion));

            }
        }

        return columns;
    }
}