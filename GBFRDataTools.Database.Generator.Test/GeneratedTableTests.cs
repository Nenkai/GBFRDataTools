using System.Runtime.CompilerServices;
using GBFRDataTools.Database.Generated;
using Syroot.BinaryData;

namespace GBFRDataTools.Database.Generator.Test;

file static class Extensions
{
    extension(string str)
    {
        public string ToPascalCase()
            => string.Concat(str.Split('_').Select(word => char.ToUpper(word[0]) + word[1..].ToLower()));
    }
}

public class GeneratedTableTests
{
    [SetUp]
    public void Setup()
    {
    }

    private static string CallerFilePath([CallerFilePath] string callerFilePath = "")
        => callerFilePath;

    private static IEnumerable<string> EnumerateTables()
    {
        var rootDir = Path.GetDirectoryName(CallerFilePath());

        return Directory.EnumerateFiles(rootDir! + "\\CleanTables\\table", "*.tbl", SearchOption.AllDirectories);
    }

    [TestCaseSource(nameof(EnumerateTables)), Parallelizable]
    public void RoundTripTable(string tblPath)
    {
        string tableName = Path.GetFileNameWithoutExtension(tblPath);
        Type ConcreteTableClass = Type.GetType($"GBFRDataTools.Database.Generated.{tableName.ToPascalCase()}")!;
        if (ConcreteTableClass is null)
            Assert.Ignore($"{tableName} is not generated");
        GameTable gameTable = (GameTable)Activator.CreateInstance(ConcreteTableClass)!;

        byte[] origContent = File.ReadAllBytes(tblPath);
        gameTable.Read(origContent);

        using var ms = new MemoryStream();
        using var bs = new BinaryStream(ms);

        gameTable.Write(bs);

        byte[] roundTripContent = ms.ToArray();

        Assert.That(roundTripContent, Is.EqualTo(origContent));
    }
}
