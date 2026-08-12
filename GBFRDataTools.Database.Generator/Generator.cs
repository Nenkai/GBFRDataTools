using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

[Generator]
public class Generator : IIncrementalGenerator
{
    public Version TargetVersion { get; set; } = null!;

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<string> headerFiles =
            context.AdditionalTextsProvider.Where(file => Path.GetFileName(file.Path) == "GBFR.tables")
            .SelectMany((file, ct) =>
            {
#pragma warning disable RS1035 // Do not use APIs banned for analyzers
                List<string> lines = [.. File.ReadAllLines(file.Path)];
#pragma warning restore RS1035 // Do not use APIs banned for analyzers
                TargetVersion = Version.Parse(lines.First());
                return lines.Skip(1);
            })
            .SelectMany((tableName, ct) =>
            {
                if (tableName != "*")
                    return [tableName];

                return StaticTableMappingReader.GetAllEmbeddedHeaders();
            });

        context.RegisterSourceOutput(headerFiles, GenerateFile);
    }

    public string GenerateSource(string path)
    {
        string baseName = Path.GetFileNameWithoutExtension(path);

        var headerReader = new StaticTableMappingReader();
        var tcs = headerReader.ReadColumnMappings(path, TargetVersion, out int offset);

        string source = $$"""
        using Syroot.BinaryData;
        using Syroot.BinaryData.Memory;
        using System.Text;

        namespace GBFRDataTools.DB.Generated;

        public class {{baseName.ToPascalCase()}}TableRow : IGameTableRow
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
            public override int RowSize => {{offset}};
            public override bool HasPointerTypes => {{(tcs.Select(x => x.Type).Any(x => x.IsPointerType) ? "true" : "false")}};

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
        try
        {
            var sourceText = GenerateSource(tableName);
            spc.AddSource($"{tableName.ToPascalCase()}.g.cs", sourceText);
        }
        catch (Exception)
        {
            spc.ReportDiagnostic(Diagnostic.Create(
                id: "GBFRGEN0001",
                category: "SourceGeneration",
                message: $"Failed to generate source for table: {tableName}",
                severity: DiagnosticSeverity.Warning,
                defaultSeverity: DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                warningLevel: 1
            ));
        }
    }
}
