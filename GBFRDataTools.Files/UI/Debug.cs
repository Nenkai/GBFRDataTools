using GBFRDataTools.Files.UI.Assets;
using GBFRDataTools.Files.UI.Serialization;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.UI;

public class UIDebugUtilities
{
    // Dumps "sprite_names.txt"
    public static void GetAllSpriteNames(string pathToUiDirectory)
    {
        Dictionary<uint, string> _spriteNames = [];

        using var tx = new StreamWriter("sprite_names.txt");
        foreach (var file in Directory.GetFiles(pathToUiDirectory, "*.texb", SearchOption.AllDirectories))
        {
            var fs = File.OpenRead(file);
            var bulk = new BulkReader(fs);
            Texture texture = bulk.ReadObject<Texture>();

            int count = 0;
            foreach (var sprite in texture.Sprites)
            {
                if (_spriteNames.TryAdd(XXHash32Custom.Hash(sprite.Name), sprite.Name))
                {
                    if (count == 0)
                    {
                        string normalized = file.Replace('\\', '/');
                        int idx = normalized.IndexOf("ui/");
                        tx.WriteLine($"// {normalized.Substring(idx, file.Length - idx)}");
                    }

                    tx.WriteLine(sprite.Name);
                    count++;
                }
            }

            if (count > 0)
                tx.WriteLine();
        }
    }
}
