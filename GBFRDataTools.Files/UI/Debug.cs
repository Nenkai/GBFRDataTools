using GBFRDataTools.Files.UI.Types;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI;

public class UIDebugUtilities
{
    // Dumps "sprite_names.txt"
    public static void GetAllSpriteNames(string pathToUiDirectory)
    {
        Dictionary<uint, string> _spriteNames = [];

        using (var tx = new StreamWriter("sprite_names.txt"))
        {
            foreach (var file in Directory.GetFiles(pathToUiDirectory, "*.texb", SearchOption.AllDirectories))
            {
                var fs = File.OpenRead(file);
                var bulk = new BulkReader(fs);
                var root = bulk.ReadObject(KnownProperties.List);
                bulk.ResolveHashReferencesRecursive(root);

                int count = 0;
                foreach (var sub in root.Children)
                {
                    UIObjectArray sprites = root["Sprites"] as UIObjectArray;
                    foreach (UIObject sprite in sprites.Array)
                    {
                        var name = sprite["Name"] as UIString;
                        if (_spriteNames.TryAdd(XXHash32Custom.Hash(name.Str), name.Str))
                        {
                            if (count == 0)
                            {
                                string normalized = file.Replace('\\', '/');
                                int idx = normalized.IndexOf("ui/");
                                tx.WriteLine($"// {normalized.Substring(idx, file.Length - idx)}");
                            }

                            tx.WriteLine(name.Str);
                            count++;
                        }
                    }
                }

                if (count > 0)
                    tx.WriteLine();
            }
        }
    }
}
