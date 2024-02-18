using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FlatSharp;
using GBFRDataTools.FlatBuffers;
using GBFRDataTools.Archive;

namespace GBFRDataTools.Archive;

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
        /*
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
        */

        BruteforceEffectPrimitive();

        // Slow! at least 2 hours
        /*
        BruteforceSeqBxm("ba");
        BruteforceSeqBxm("bg");
        BruteforceSeqBxm("bh");
        BruteforceSeqBxm("ci");
        BruteforceSeqBxm("ct");
        BruteforceSeqBxm("em");
        BruteforceSeqBxm("et");
        BruteforceSeqBxm("it");
        BruteforceSeqBxm("np");
        BruteforceSeqBxm("we");
        BruteforceSeqBxm("wp");
        */

        // TODO go through bnk/pck for lip files

        foreach (var file in _archive.ArchiveFilesHashTable.ToList())
        {
            // remove fhd for 4k assets
            _archive.RegisterFileIfValid(file.Key.Replace("/fhd", ""));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "jpn"));
            _archive.RegisterFileIfValid(file.Key.Replace("/4k", "/2k"));
            _archive.RegisterFileIfValid(file.Key.Replace(".wtb", ".tex.texb"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_effect.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_flags.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_facialmotion.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_eyecontrol.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_ik.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_attack.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_cloth.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_mesh.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_se.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_speed.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_vib.bxm"));
            _archive.RegisterFileIfValid(file.Key.Replace("seq.bxm", "seq_edit_camera.bxm"));

        }
    }

    public void BruteforceEffectPrimitive()
    {
        for (int i = 0; i < 0x1000; i++)
        {
            _archive.RegisterFileIfValid($"effect/primitive/{i:X3}.bxm");
        }
    }

    public void BruteforceEffectPrefix(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            _archive.RegisterFileIfValid($"effect/{prefix}{i:x4}.bxm");
        }
    }

    public void BruteforceMatTextures()
    {
        foreach (var file in Directory.GetFiles(_archive.GetDirectory(), "*.mmat", SearchOption.AllDirectories))
        {
            byte[] buf = File.ReadAllBytes(file);
            ModelMaterial parse = ModelMaterial.Serializer.Parse(buf);

            foreach (var t in parse.Materials)
            {
                foreach (var tex in t.Textures)
                {
                    _archive.RegisterFileIfValid($"texture/4k/{tex.Name}.texture");
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
                _archive.ExtractFile(path, Path.Combine(_archive.GetDirectory(), "data"));

                using var sr = new StreamReader(Path.Combine(_archive.GetDirectory(), "data", path));
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    _archive.RegisterFileIfValid(l);
                }
            }
        }
    }

    public void BruteforceSeqBxm(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            Console.WriteLine($"{prefix} {i}");
            for (int j = 0; j < 0x10000; j++)
            {
                string path = $"effect/savedata/{prefix}{i:x4}/{j:x4}.est";
                _archive.RegisterFileIfValid(path);

                /*
                for (int k = 0; k < 12; k++)
                {
                    string path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}_{j:x4}_{k}_seq_edit_ik.bxm";
                    _archive.RegisterFileIfValid(path);

                    path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}_{j:x4}_{k}_seq_edit_flags.bxm";
                    _archive.RegisterFileIfValid(path);

                    path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}_{j:x4}_{k}_seq_edit_facialmotion.bxm";
                    _archive.RegisterFileIfValid(path);

                    path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}_{j:x4}_{k}_seq_edit_effect.bxm";
                    _archive.RegisterFileIfValid(path);

                    path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}_{j:x4}_{k}_seq.bxm";
                    _archive.RegisterFileIfValid(path);
                }

                string path2 = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}_{j:x4}.mot";
                _archive.RegisterFileIfValid(path2);
                */
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
                    _archive.ExtractFile(path, Path.Combine(_archive.GetDirectory(), "data"));

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
