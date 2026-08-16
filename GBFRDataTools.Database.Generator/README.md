# GBFRDataTools.Database.Generator

A Roslyn Incremental Source Generator for creating strongly typed classes for their corrosponding `.tbl` files.

# Using the generator
- Add both `GBFRDataTools.Database.Generator` and `GBFRDataTools.Database.Generator.Core` as a dependency in `.csproj` 
- Create a json file named `GBFR_tables.json` in the project root, and add it to the `.csproj`
- **[Optional]** `EmitCompilerGeneratedFiles` and `CompilerGeneratedFilesOutputPath` can be set to view the generated source files

*Example*
```
  <PropertyGroup>
    <EmitCompilerGeneratedFiles>true</EmitCompilerGeneratedFiles>
    <CompilerGeneratedFilesOutputPath>obj/Generated</CompilerGeneratedFilesOutputPath>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\GBFRDataTools.Database.Generator\GBFRDataTools.Database.Generator.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
    <ProjectReference Include="..\GBFRDataTools.Database.Generator.Core\GBFRDataTools.Database.Generator.Core.csproj" />
    <AdditionalFiles Include=".\GBFR_tables.json" />
  </ItemGroup>
```

The content of `GBFR_tables.json` is as follows,
```
{
    "Version": "2.0.3",
    "Tables": [
        "*"
    ]
}
```

- `Version` is the target version of the game the classes should be generated for
- `Tables` is a list of table names to generate, supports wildcards like `*` (multi character) and `?` (single character)

Generated classes live in the `GBFRDataTools.Database.Generated` namespace, and with class names as the table name in pascal case (eg. `ability_group.tbl` -> `GBFRDataTools.Database.Generated.AbilityGroup`).

Generated tables classes are of the type `GBFRDataTools.Database.Generated.GameTable<T>` from `GBFRDataTools.Database.Generator.Core`, where `T` is the strongly typed row entries. Each row of the tables can be accessed via the `Rows` properties.

## Type map
```
.tbl type       | C# type
sbyte          => sbyte
byte           => byte
short          => short
ushort         => ushort
int            => int
uint           => uint
hex_uint       => string
float          => float
int64          => long
double         => double
string         => string
raw_string     => string
hash_string    => string - see note below
string_pointer => string
```

 *hash_string - refer to https://nenkai.github.io/relink-modding/resources/re/hashes/, values are kept as original hex string representation.*
