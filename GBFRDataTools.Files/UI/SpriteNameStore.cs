using GBFRDataTools.Hashing;

using System.Reflection;


namespace GBFRDataTools.Files.UI;

public class SpriteNameStore
{
    public static Dictionary<uint, string> HashToSpriteName = [];

    static SpriteNameStore()
    {
        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        if (string.IsNullOrEmpty(assemblyLocation)) // This may be empty if we compiled the executable as single-file.
            assemblyLocation = Environment.GetCommandLineArgs()[0]!;

        string currentDir = Path.GetDirectoryName(assemblyLocation)!;

        using var fs = new StreamReader(Path.Combine(currentDir, "UI", "sprite_names.txt"));
        while (!fs.EndOfStream)
        {
            var line = fs.ReadLine();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                continue;

            HashToSpriteName.Add(XXHash32Custom.Hash(line),line);
        }
    }
}
