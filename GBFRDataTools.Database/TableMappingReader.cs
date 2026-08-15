using System;
using System.Collections.Generic;
using System.IO;
using GBFRDataTools.Database.Entities;

namespace GBFRDataTools.Database;

/// <summary>
/// Utility class for column definition header (.headers) files.
/// </summary>
public abstract class TableMappingReader
{
    protected abstract Stream? GetHeaderSource(string tableName);
    protected abstract void Log(string @string);

    public List<TableColumn> ReadColumnMappings(string tableName, Version version, out int readSize)
    {
        int offset = 0;
        List<TableColumn> columns = IterativeHeadersReader(tableName, ref offset, version);

        readSize = offset;
        return columns;
    }

    private List<TableColumn> IterativeHeadersReader(string tableName, ref int offset, Version inputVersion)
    {
        using var stream = GetHeaderSource(tableName);
        if (stream == null)
        {
            Log($"Metadata error: unknown include file '{tableName}' - may break!");
            return [];
        }

        using var sr = new StreamReader(stream);

        List<TableColumn> columns = new();
        var dir = Path.GetDirectoryName(tableName);
        int lineNumber = 0;

        Version max_version = null;
        Version min_version = new Version(1, 0, 0);

        while (!sr.EndOfStream)
        {
            lineNumber++;
            var debugln = $"{tableName}:{lineNumber}";

            var line = sr.ReadLine()?.Trim();

            // support comments & skip empty lines
            if (string.IsNullOrEmpty(line) || line.StartsWith("//"))
                continue;

            // support comments
            var commentIndex = line.IndexOf("//");
            if (commentIndex >= 0)
            {
                line = line.Substring(0, commentIndex);
                line = line.Trim();
            }

            var split = line.Split('|');
            var id = split[0];


            TableColumn column = null;
            if (id == "add_column")
            {
                if (split.Length < 3 || split.Length > 4)
                    Log($"Metadata error: {debugln} has malformed 'add_column' - expected 2 or 3 arguments (name, type, offset?), may break!");

                string columnName = split[1];
                string columnTypeStr = split[2];

                DBColumnType columnType = DBUtils.ColumnTypeToType(columnTypeStr);
                if (columnType == DBColumnType.Unknown)
                    Log($"Metadata error: {debugln} has malformed 'add_column' - type '{columnTypeStr}' is invalid\n" +
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
                    Log($"Metadata error: {debugln} has malformed 'padding' - expected 1 argument (length), may break!");

                offset += Convert.ToInt32(split[1], 16);
            }
            else if (id == "set_min_version")
            {
                if (split.Length < 2)
                    Log($"Metadata error: {debugln} has malformed 'set_min_version' - expected 1 arguments (version), may break!");

                if (!Version.TryParse(split[1], out Version ver))
                    Log($"Metadata error: {debugln} has malformed 'set_min_version' - version is invalid - may break!");

                min_version = ver;
            }
            else if (id == "set_max_version")
            {
                if (split.Length < 2)
                    Log($"Metadata error: {debugln} has malformed 'set_max_version' - expected 1 arguments (version), may break!");

                if (!Version.TryParse(split[1], out Version ver))
                    Log($"Metadata error: {debugln} has malformed 'set_max_version' - version is invalid - may break!");

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
                    Log($"Metadata error: {debugln} has malformed 'include' - expected 1 argument (filename), may break!");

                columns.AddRange(IterativeHeadersReader(split[1], ref offset, inputVersion));
            }
        }

        return columns;
    }
}
