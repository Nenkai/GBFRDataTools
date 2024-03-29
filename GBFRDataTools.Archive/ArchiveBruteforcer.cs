﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;

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

    public static string[] type = [
        "pl", "em", "np", "wp", "we", "wn", "bg", "bh", "ba", "fp", "fe", "fn", "et", "ef", "it", "sc", "tr", "bt"
    ];

    public void Bruteforce()
    {
        

        //BruteforceNpcRoleMsg();
        //BruteforceBossBattleTex();
        //BruteforceLayoutStagePlacement();
        //BruteforceSounds();
        //BruteforceFsmQuest();
        //BruteforceMiscTextures();
        //BruteforceEffectPrimitive();
        //BruteforceLipSync();
        //BruteforceEffectTextureFiles();
        //BruteforcePhaseEffect();
        //BruteforceLayout2();


        /*
        foreach (var t in type)
            BruteforceModelStreaming(t);
        */

        /*
        foreach (var t in type)
            BruteforceEffectPrefix(t);
        */

        /*
        foreach (var t in type)
            BruteforceModel(t);
        */

        /*
        foreach (var t in type)
            BruteforcePrefixListFiles(t);
        */

        /*
        BruteforcePrefixWeird("st", "r");
        BruteforcePrefixWeird("ph", "p");
        */

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


        foreach (var file in _archive.ArchiveFilesHashTable.ToList())
        {
            // remove fhd for 4k assets
            _archive.RegisterFileIfValid(file.Key.Replace("ui", "ui/fhd"));
            _archive.RegisterFileIfValid(file.Key.Replace("ui", "ui/fhd").Replace(".wtb", ".tex.texb"));
            _archive.RegisterFileIfValid(file.Key.Replace("ui", "ui/fhd").Replace(".tex.texb", ".wtb"));

            _archive.RegisterFileIfValid(file.Key.Replace("ui/fhd", "ui"));
            _archive.RegisterFileIfValid(file.Key.Replace("ui/fhd", "ui").Replace(".wtb", ".tex.texb"));
            _archive.RegisterFileIfValid(file.Key.Replace("ui/fhd", "ui").Replace(".tex.texb", ".wtb"));

            _archive.RegisterFileIfValid(file.Key.Replace("eng", "jpn"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "chs"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "cht"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "deu"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "esp"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "fra"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "ita"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "jpn"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "kor"));
            _archive.RegisterFileIfValid(file.Key.Replace("eng", "por"));

            _archive.RegisterFileIfValid(file.Key.Replace("jpn", "eng"));

            _archive.RegisterFileIfValid(file.Key.Replace("pck", "bnk"));
            _archive.RegisterFileIfValid(file.Key.Replace("bnk", "pck"));

            _archive.RegisterFileIfValid(file.Key.Replace("english(us)", "japanese"));
            _archive.RegisterFileIfValid(file.Key.Replace("japanese", "english(us)"));

            _archive.RegisterFileIfValid(file.Key.Replace("/4k", "/2k"));

            _archive.RegisterFileIfValid(file.Key.Replace(".wtb", ".tex.texb"));

            _archive.RegisterFileIfValid(file.Key.Replace(".tex.texb", ".wtb"));
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

    public void BruteforceLayout2()
    {
        for (int i = 0; i < 0x1000; i++)
        {
            for (int j = 0; j < 0x10; j++)
            {
                _archive.RegisterFileIfValid($"st{j:X1}/r{i:X3}/r{i:X3}.layout2");

            }
        }
    }

    public void BruteforcePhaseEffect()
    {
        for (int i = 0; i < 10000; i++)
        {
            for (int j = 0; j < 0x1000; j++)
            {
                string path = $"effect/savedata/r{j:X3}/{i:D4}.est";
                _archive.RegisterFileIfValid(path);
            }
        }
    }

    public void BruteforceNpcRoleMsg()
    {
        foreach (var t in type)
        {
            for (int i = 0; i < 0x10000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _archive.RegisterFileIfValid($"system/npc/data/{t}{i:X4}_{j}_npcrole.msg");

                }
            }
        }
    }

    public void BruteforceBossBattleTex()
    {
        foreach (var t in type)
        {
            for (int i = 0; i < 0x10000; i++)
            {
                _archive.RegisterFileIfValid($"ui/layouts/telop/bossbattle/noatlastextures/eng/tlp_bbtl_{t}{i:x4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/layouts/telop/bossbattle/noatlastextures/eng/tlp_bbtl_{t}{i:x4}.wtb");

                for (int j = 0; j < 10; j++)
                {
                    _archive.RegisterFileIfValid($"ui/layouts/telop/bossbattle/noatlastextures/tlp_bbtl_{t}{i:x4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/telop/bossbattle/noatlastextures/tlp_bbtl_{t}{i:x4}_{j:D2}.wtb");
                }
            }
        }
    }

    public void BruteforceWwisePacks()
    {
        for (int i = 0; i < 0x10000; i++)
        {
            _archive.RegisterFileIfValid($"sound/japanese/vo_ci{i:x4}.pck");
        }


        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 100; k++)
                {
                    _archive.RegisterFileIfValid($"sound/japanese/vo_pl1102_{i:D2}_{j:D2}_{k:D2}.bnk");
                    _archive.RegisterFileIfValid($"sound/japanese/vo_pl1102_{i:D2}_{j:D2}_{k:D2}_m.bnk");

                }
            }
        }


        for (int i = 0; i < 0x1000; i++)
        {
            _archive.RegisterFileIfValid($"sound/japanese/vo_ft{i:x3}.pck");
        }

        for (int i = 0; i < 1000000; i++)
        {
            _archive.RegisterFileIfValid($"sound/japanese/vo_cw{i:D6}.pck");
            _archive.RegisterFileIfValid($"sound/japanese/vo_ct{i:D6}.pck");
            _archive.RegisterFileIfValid($"sound/japanese/vo_cn{i:D6}.pck");

        }
    }


    public void BruteforceFsmQuest()
    {
        for (int i = 0; i < 500000; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                _archive.RegisterFileIfValid($"system/fsm/quest/quest_{i:D6}_{j}_fsm_ingame.msg");
            }
        }
    }

    public void BruteforceMiscTextures()
    {
        for (int i = 0; i < 100; i++)
        {
            _archive.RegisterFileIfValid($"ui/layouts/common/image_capture/noatlastextures/cmn_imgcap_location_{i:D2}.tex.texb");
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_quest/noatlastextures/cmn_imgqst_location_{i:D2}.tex.texb");
        }

        for (int i = 0; i < 1000; i++)
        {
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_item/noatlastextures/cmn_icitm_icon_wbg{i:D3}.wtb");
        }

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 10000; j++)
            {
                _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_item/noatlastextures/cmn_imgitm_{i:D2}_{j:D4}.wtb");
                _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_item/noatlastextures/cmn_imgitm_{i:D2}_{j:D4}_glow.wtb");
            }
        }

        for (int i = 0; i < 10000; i++)
        {
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_word/noatlastextures/cmn_imgword_location_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_word/noatlastextures/cmn_imgword_common_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_word/noatlastextures/cmn_imgword_primalbeasts_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_word/noatlastextures/cmn_imgword_species_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_chami/noatlastextures/cmn_imgchm_mob{i:D4}.wtb");

            for (int j = 0; j < 20; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_fate/noatlastextures/cmn_imgfate_{i:D4}_{j:D2}_{k:D2}.wtb");

                }
            }
        }


        for (int i = 0; i < 0x10000; i++)
        {
            foreach (var type in type)
            {
                for (int j = 0; j < 10; j++)
                {
                    _archive.RegisterFileIfValid($"ui/layouts/common/chara_voice/noatlastextures/cmn_chrvo_{type}{i:D4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/chara_plprm/noatlastextures/cmn_chrprm_{type}{i:D4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_mainstory/noatlastextures/cmn_imgmain_{type}{i:D4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_bookem/noatlastextures/cmn_imgbook_{type}{i:D4}_{j:D2}.wtb");
                    _archive.RegisterFileIfValid($"ui/fhd/movie/ab_{type}{i:D4}_{j:D2}.bk2");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_chrcolor/noatlastextures/cmn_imgcol_{type}{i:D4}_c{j:D2}.wtb");

                }

                _archive.RegisterFileIfValid($"ui/fhd/layouts/telop/bossbattle/noatlastextures/jpn/tlp_bbtl_{type}{i:D4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/fhd/layouts/pause/limitbonus/noatlastextures/ps_lb_stree_{type}{i:D4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/fhd/layouts/hud/linklevel/noatlastextures/hud_lnklv_{type}{i:D4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/fhd/layouts/blacksmith/weapon/noatlastextures/bs_wpn_{type}{i:D4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_equip/noatlastextures/cmn_imgequ_{type}{i:D4}.wtb");
                _archive.RegisterFileIfValid($"ui/fhd/layouts/common/image_equip/noatlastextures/cmn_imgequ_s_{type}{i:D4}.wtb");


            }
        }
    }

    public void BruteforceLayoutStagePlacement()
    {
        // Takes a while.
        for (int j = 0; j < 0x10; j++)
        {
            for (int k = 0; k < 100; k++)
            {
                for (int i = 0; i < 500000; i++)
                {
                    _archive.RegisterFileIfValid($"layout/p{j:X1}{k:D2}/placement_multi_{i:D6}.scene.msg");
                }
            }
        }
    }

    public void BruteforceSounds()
    {
        foreach (var p in type)
        {
            for (int i = 0; i < 0x10000; i++)
            {
                _archive.RegisterFileIfValid($"sound/english(us)/vo_{p}{i:x4}.pck");
                _archive.RegisterFileIfValid($"sound/english(us)/vo_{p}{i:x4}.bnk");
                _archive.RegisterFileIfValid($"sound/english(us)/vo_{p}{i:x4}_m.pck");
                _archive.RegisterFileIfValid($"sound/english(us)/vo_{p}{i:x4}_m.bnk");
                _archive.RegisterFileIfValid($"sound/english(us)/vo_{p}{i:x4}_town.pck");
                _archive.RegisterFileIfValid($"sound/english(us)/vo_{p}{i:x4}_town.bnk");
                _archive.RegisterFileIfValid($"sound/se/{p}{i:x4}.bnk");
                _archive.RegisterFileIfValid($"sound/se/{p}{i:x4}.pck");
                _archive.RegisterFileIfValid($"sound/se/{p}{i:x4}_m.bnk");
                _archive.RegisterFileIfValid($"sound/se/{p}{i:x4}_m.pck");
                _archive.RegisterFileIfValid($"sound/se/{p}{i:x4}_town.bnk");
                _archive.RegisterFileIfValid($"sound/se/{p}{i:x4}_town.pck");
            }
        }

        foreach (string p in new string[] { "cn", "ct", "cw" })
        {
            for (int i = 0; i < 0x1000000; i++)
            {
                _archive.RegisterFileIfValid($"sound/english(us)/{p}{i:x6}.pck");
                _archive.RegisterFileIfValid($"sound/english(us)/{p}{i:x4}.bnk");
            }
        }
    }

    public void BruteforceLipSync()
    {
        // Requires file generated with the following command (can take a while, 1gb)
        // strings2 -r "extracted/*" > strings.txt

        using var sr = new StreamReader(@"strings.txt");
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                string sub = line.Substring(i);
                _archive.RegisterFileIfValid(sub);
                _archive.RegisterFileIfValid("ui/" + sub + ".view.viewb");
                _archive.RegisterFileIfValid("ui/" + sub + ".tex.texb");
                _archive.RegisterFileIfValid("ui/" + sub + ".list.listb");
                _archive.RegisterFileIfValid("ui/" + sub + ".anim.animb");
                _archive.RegisterFileIfValid("ui/" + sub + ".lang.langb");
                _archive.RegisterFileIfValid("ui/" + sub + ".prfb");
                _archive.RegisterFileIfValid("ui/" + sub + ".wtb");
                _archive.RegisterFileIfValid(sub.Replace("tga", "wtb"));
                _archive.RegisterFileIfValid(sub.Replace("yml", "msg"));
                _archive.RegisterFileIfValid(sub.Replace("dds", "wtb"));

                if (sub.Contains("vo_", StringComparison.OrdinalIgnoreCase))
                {
                    string[] spl = sub.Split('_');
                    for (int k = 0; k < spl.Length; k++)
                    {
                        _archive.RegisterFileIfValid($"sound/lipsync/eng/{spl[k]}/{sub}.lip");
                        for (int l = 0; l < 25; l++)
                            _archive.RegisterFileIfValid($"sound/lipsync/eng/{spl[k]}/{sub}_{l}.lip");
                    }


                    for (int j = 0; j < sub.Length; j++)
                    {
                        string subsub = sub.Substring(0, sub.Length - j);
                        spl = subsub.Split('_');

                        for (int k = 0; k < spl.Length; k++)
                        {
                            _archive.RegisterFileIfValid($"sound/lipsync/eng/{spl[k]}/{subsub}.lip");
                            for (int l = 0; l < 25; l++)
                                _archive.RegisterFileIfValid($"sound/lipsync/eng/{spl[k]}/{sub}_{l}.lip");
                        }
                    }
                }
            }
        }
    }

    public void BruteforceEffectPrimitive()
    {
        for (int i = 0; i < 0x1000; i++)
        {
            _archive.RegisterFileIfValid($"effect/primitive/{i:x3}.bxm");
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
            ModelMaterialSet parse = ModelMaterialSet.Serializer.Parse(buf);

            foreach (var t in parse.Materials)
            {
                foreach (var tex in t.TextureMaps)
                {
                    _archive.RegisterFileIfValid($"texture/4k/{tex.ShaderMapNameHash}.texture");
                }
            }
        }
    }

    public void BruteforceEffectTextureFiles()
    {
        for (int i = 0; i < 0x1000; i++)
        {
            string path = $"effect/texture/{i:x3}/effect_texture_info.eti";

            if (_archive.RegisterFileIfValid(path))
            {
                _archive.ExtractFile(path, Path.Combine(_archive.GetDirectory(), "data"));

                byte[] buf = File.ReadAllBytes(Path.Combine(_archive.GetDirectory(), "data", path));
                EffectTextureImplementationHeader parse = EffectTextureImplementationHeader.Serializer.Parse(buf);

                foreach (var file in parse.Files)
                {
                    if (file.TextureFilePath is not null)
                        _archive.RegisterFileIfValid(file.TextureFilePath);

                    if (file.EpbFilePath is not null)
                        _archive.RegisterFileIfValid(file.EpbFilePath);
                }
            }
        }
    }

    public void BruteforcePrefixListFiles(string prefix)
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

    public void BruteforceModel(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            string path = $"model/{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.minfo";
            _archive.RegisterFileIfValid(path);

            path = $"model/{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.skeleton";
            _archive.RegisterFileIfValid(path);

            path = $"model/{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.sop";
            _archive.RegisterFileIfValid(path);

            path = $"model/{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.bxm";
            _archive.RegisterFileIfValid(path);

            path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.lst";
            _archive.RegisterFileIfValid(path);

            path = $"{prefix}/{prefix}{i:x4}/{prefix}{i:x4}.col";
            _archive.RegisterFileIfValid(path);

            for (int j = 0; j < 10; j++)
            {
                path = $"model/{prefix}/{prefix}{i:x4}/vars/{j}.mmat";
                _archive.RegisterFileIfValid(path);
            }

            for (int j = 100; j < 110; j++)
            {
                path = $"model/{prefix}/{prefix}{i:x4}/vars/{j}.mmat";
                _archive.RegisterFileIfValid(path);
            }
        }
    }

    public void BruteforceModelStreaming(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                string path = $"model_streaming/lod{j}/{prefix}{i:x4}.mmesh";
                _archive.RegisterFileIfValid(path);

                path = $"model_streaming/shadowlod{j}/{prefix}{i:x4}.mmesh";
                _archive.RegisterFileIfValid(path);
            }
        }
    }

    public void BruteforceSeqBxm(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            if (i % 1000 == 0)
                Console.WriteLine($"{prefix} {i}");

            for (int j = 0; j < 10000; j++)
            {
                string path = $"effect/savedata/{prefix}{i:x4}/{j:D4}.est";
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
