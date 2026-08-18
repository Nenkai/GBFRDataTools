using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using GBFRDataTools.Database.Entities;
using Microsoft.CodeAnalysis;

namespace GBFRDataTools.Database.Generator;

file static class Extensions
{
    extension(string str)
    {
        public string ToPascalCase()
            => string.Concat(str.Split('_').Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));

        public string Indent(int level)
            => str.Replace("\n", "\n" + string.Concat(Enumerable.Repeat("    ", level)));
    }

    extension(IEnumerable<TableColumn> tcs)
    {
        public string AsProperties()
        {
            List<string> properties = [];

            foreach (var tc in tcs)
            {
                string entry = $$"""
                    public {{tc.Type.AsCsharpType()}} {{tc.Name}} { get; set; }
                    """;

                properties.Add(entry);
            }

            return string.Join("\n", properties);
        }

        public string AsEntries()
        {
            List<string> entries = [];
            foreach (var tc in tcs)
            {
                string entry = $$"""
                    new TableColumn()
                    {
                        Name = "{{tc.Name}}",
                        Type = DBColumnType.{{tc.Type}},
                        MinVersion = new Version("{{tc.MinVersion}}"),
                        MaxVersion = new Version("{{tc.MaxVersion}}"),
                        Offset = {{tc.Offset}},
                        StringLength = {{tc.StringLength}}
                    }
                    """;

                entries.Add(entry);
            }

            return string.Join(", \n", entries);
        }

        public string AsReadParse()
        {
            var entries = tcs.SelectMany(TypeParser.ReadType);
            return string.Join("\n", entries);
        }

        public string AsWriteParse()
            => string.Join("\n", tcs.SelectMany(TypeParser.WriteType));
    }
}

public class GeneratorConfig
{
    public string Version { get; set; } = null!;
    public string[] Tables { get; set; } = null!;
}

[Generator]
public class Generator : IIncrementalGenerator
{
    public Version TargetVersion { get; set; } = null!;

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<string> headerFiles =
            context.AdditionalTextsProvider.Where(file => Path.GetFileName(file.Path) == "GBFR_tables.json")
            .SelectMany((file, ct) =>
            {
                var config = JsonSerializer.Deserialize<GeneratorConfig>(file.GetText()!.ToString())!;
                TargetVersion = Version.Parse(config.Version);
                return config.Tables;
            })
            .Collect()
            .SelectMany((patterns, ct) =>
            {
                var regexPatterns = patterns.Select(x => $"^{x}$".Replace("*", ".+").Replace("?", "."));

                var tableNames = StaticTableMappingReader.GetAllEmbeddedHeaders().ToArray();
                return tableNames.Where(tableName =>
                {
                    return regexPatterns.Any(pat => Regex.IsMatch(tableName, pat));
                });
            });

        context.RegisterSourceOutput(headerFiles, GenerateFile);
    }

    public string GenerateSource(StaticTableMappingReader headerReader, string path)
    {
        string baseName = Path.GetFileNameWithoutExtension(path);

        var tcs = headerReader.ReadColumnMappings(path, TargetVersion, out int offset);

        string source = $$"""
        using Syroot.BinaryData;
        using Syroot.BinaryData.Memory;
        using System.Text;

        namespace GBFRDataTools.Database.Generated;

        public record {{baseName.ToPascalCase()}}TableRow : IGameTableRow
        {
            {{tcs.AsProperties().Indent(1)}}

            public void ReadRow(Span<byte> span) 
            {
                var sr = new SpanReader(span);

                {{tcs.AsReadParse().Indent(2)}}
            }

            public void WriteRow(BinaryStream bs, ref long lastStrPtrOffset) 
            {
                {{tcs.AsWriteParse().Indent(2)}}
            }
        }

        public class {{baseName.ToPascalCase()}} : GameTable<{{baseName.ToPascalCase()}}TableRow>
        {
            protected override int RowSize => {{offset}};
            protected override bool HasPointerTypes => {{(tcs.Select(x => x.Type).Any(x => x.IsPointerType) ? "true" : "false")}};

            public {{baseName.ToPascalCase()}}()
            {
            } 

            public {{baseName.ToPascalCase()}}(Span<byte> span) 
            {
                Read(span);
            }
        }
        """;

        return source;
    }

    private void GenerateFile(SourceProductionContext spc, string tableName)
    {
        var headerReader = new StaticTableMappingReader();
        try
        {
            var sourceText = GenerateSource(headerReader, tableName);
            spc.AddSource($"{tableName.ToPascalCase()}.g.cs", sourceText);

            foreach (var log in headerReader.Logs)
            {
                spc.ReportDiagnostic(Diagnostic.Create(
                    id: "GBFRGEN0001",
                    category: "SourceGeneration",
                    message: $"Warning while generating table: {tableName}, {log}",
                    severity: DiagnosticSeverity.Warning,
                    defaultSeverity: DiagnosticSeverity.Warning,
                    isEnabledByDefault: true,
                    warningLevel: 1
                ));
            }
        }
        catch (Exception e)
        {
            spc.ReportDiagnostic(Diagnostic.Create(
                id: "GBFRGEN0002",
                category: "SourceGeneration",
                message: $"Failed to generate source for table: {tableName}, {e}",
                severity: DiagnosticSeverity.Warning,
                defaultSeverity: DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                warningLevel: 1
            ));
        }
    }
}
