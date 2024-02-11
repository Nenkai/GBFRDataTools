using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Archive;

namespace GBFRDataTools
{
    public class ArchiveBruteforcer
    {
        private string _gameDir;
        private DataArchive _archive;

        public ArchiveBruteforcer(DataArchive archive)
        {
            _archive = archive;
        }

        public void Bruteforce()
        {
            BruteforcePrefix("ba");
            BruteforcePrefix("pl");
            BruteforcePrefix("em");
            BruteforcePrefix("wp");
            BruteforcePrefix("np");
            BruteforcePrefix("et");
            BruteforcePrefix("we");

            BruteforcePrefixWeird("st", "r");
            BruteforcePrefixWeird("ph", "p");

            BruteforceEffectPrefix("bh");
            BruteforceEffectPrefix("ba");
            BruteforceEffectPrefix("ct");
            BruteforceEffectPrefix("ci");
            BruteforceEffectPrefix("cw");
            BruteforceEffectPrefix("em");
            BruteforceEffectPrefix("pl");

            // TODO go through bnk/pck for lip files

            foreach (var file in _archive.ArchiveFilesHashTable.ToList())
            {
                // remove fhd for 4k assets
                _archive.RegisterFileIfValid(file.Key.Replace("/fhd", ""));
                _archive.RegisterFileIfValid(file.Key.Replace("eng", "jpn"));
            }
        }

        public void BruteforceEffectPrefix(string prefix)
        {
            for (int i = 0; i < 0x10000; i++)
            {
                string path = $"effect/{prefix}{i:x4}.bxm";
                if (_archive.RegisterFileIfValid(path))
                {
                    for (int j = 0; j < 0x10000; j++)
                    {
                        _archive.RegisterFileIfValid($"effect/savedata/{prefix}{i:x4}/{j:x4}.est");
                    }
                }
            }
        }

        public void BruteforcePrefix(string prefix)
        {
            for (int i = 0; i < 0x10000; i++)
            {
                string path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.lst";
                if (_archive.RegisterFileIfValid(path))
                {
                    _archive.ExtractFile(path);

                    using var sr = new StreamReader(Path.Combine(_archive.GetDirectory(), "data", path));
                    while (!sr.EndOfStream)
                    {
                        string l = sr.ReadLine();
                        _archive.RegisterFileIfValid(l);
                    }
                }
            }
        }

        public void BruteforcePrefixWeird(string prefix, string prefix2)
        {
            for (int i = 0; i < 0x10; i++)
            {
                for (int j = 0; j < 0x1000; j++)
                {
                    string path = $"{prefix}{i:x1}/{prefix2}{j:x3}/{prefix2}{j:x3}.lst";
                    if (_archive.RegisterFileIfValid(path))
                    {
                        _archive.ExtractFile(path);

                        using var sr = new StreamReader(Path.Combine(_archive.GetDirectory(), "data", path));
                        while (!sr.EndOfStream)
                        {
                            string l = sr.ReadLine();
                            _archive.RegisterFileIfValid(l);
                        }
                    }
                }
            }
        }


        public void ListFiles()
        {
            string[] files = Directory.GetFiles(_gameDir, "*.lst", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine($"Checking-out: {file}");
                using var st = File.OpenText(file);
                while (!st.EndOfStream)
                {
                    _archive.RegisterFileIfValid(st.ReadLine().Trim());
                }
            }

        }
    }
}
