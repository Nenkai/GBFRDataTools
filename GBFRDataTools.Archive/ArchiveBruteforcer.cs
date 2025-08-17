using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;

using FlatSharp;
using GBFRDataTools.FlatBuffers;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

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
        "pl", "em", "np", "wp", "we", "wn", "bg", "bh", "ba", "fp", "fe", "fn", "et", "ef", "it", "sc", "tr", "bt",
        // cw, ct, cm, ci, sst
    ];

    public void Bruteforce()
    {
        //BruteforceEventCutscenes();
        //BruteforceWwisePacks();
        //BruteforceMinimap();
        //BruteforceNpcRoleMsg();
        //BruteforceBossBattleTex();
        //BruteforceLayoutStagePlacement();
        //BruteforceSoundsAndLipsync();
        //BruteforceFsmQuest();
        //BruteforceMiscTextures();
        //BruteforceEffectPrimitive();
        //BruteforceFromStringList();
        //BruteforceFileReferencesFromLayout();
        //BruteforceFileReferencesFromFSM();
        //BruteforceEffectTextureFiles();
        //BruteforcePhaseEffect();
        //BruteforceLayout2();
        //BruteforceSeqBxm(); // Slow!

        /*
        for (int i = 0; i < 0x1000; i++)
        {
            _archive.RegisterFileIfValid($"system/npc/{i:X3}_npcconfig.msg");
        }
        */


        foreach (var t in type)
        {
            //BruteforceBehavior(t);
            //BruteforcePreset(t);
            //BruteforceSystemPlayerData(t);
            //BruteforceFinishCamera(t);
            //BruteforceEffectPrefix(t);
            //BruteforceModel(t);
            //BruteforcePrefixListFiles(t);
        }
        

        /*
        BruteforcePrefixWeird("st", "r");
        BruteforcePrefixWeird("ph", "p");
        */

        foreach (var file in _archive.ArchiveFilesHashTable.ToList())
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                _archive.RegisterFileIfValid(file.Key.Replace($"_{i:D1}", $"_{i-1:D1}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"_{i:D1}", $"_{i+1:D1}"));
            }

            for (int i = 'a'; i < 'z'; i++)
            {
                _archive.RegisterFileIfValid(file.Key.Replace($"_{(char)i}", $"_{(char)(i - 1)}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"_{(char)i}", $"_{(char)(i + 1)}"));
            }
            

            
            // This actually helped a ton
            for (int i = 0; i < 100; i += 1)
            {
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D4}", $"{i + 1:D4}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D3}", $"{i + 1:D3}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D2}", $"{i + 1:D2}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D1}", $"{i + 1:D1}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X4}", $"{i + 1:X4}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X3}", $"{i + 1:X3}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X2}", $"{i + 1:X2}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X1}", $"{i + 1:X4}"));
            }

            for (int i = 0; i < 1000; i += 10)
            {
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D4}", $"{i + 10:D4}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D3}", $"{i + 10:D3}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D2}", $"{i + 10:D2}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D1}", $"{i + 10:D1}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X4}", $"{i + 16:X4}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X3}", $"{i + 16:X3}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X2}", $"{i + 16:X2}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X1}", $"{i + 16:X4}"));
            }

            for (int i = 0; i < 10000; i += 100)
            {
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D4}", $"{i + 100:D4}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D3}", $"{i + 100:D3}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D2}", $"{i + 100:D2}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:D1}", $"{i + 100:D1}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X4}", $"{i + 256:X4}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X3}", $"{i + 256:X3}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X2}", $"{i + 256:X2}"));
                _archive.RegisterFileIfValid(file.Key.Replace($"{i:X1}", $"{i + 256:X4}"));
            }
            */

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
            _archive.RegisterFileIfValid(file.Key.Replace(".msg", ".yml")); // Just incase

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

    public void BruteforceEventCutscenes()
    {
        List<string> motions = [

        ];

        foreach (var type in new string[] { "cw", "ct", "cn", "ci" })
        {
            for (int i = 0; i < 0x10000; i++)
            {
                _archive.RegisterFileIfValid($"system/event/{type}/{type}{i:D4}/master.evtb");

                foreach (var t in motions)
                    _archive.RegisterFileIfValid($"system/event/{type}/{type}{i:D4}/motion/{t}.mot");
            }
        }
    }

    public void BruteforceMinimap()
    {
        for (int i = 0; i < 0x1000; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_p{i:x3}_{j:D2}.tex.texb");
                _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_p{i:x3}_{j:D2}.wtb");
            }
        }

        for (int i = 0; i < 0x100; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                for (int k = 'a'; k <= 'z'; k++)
                {
                    _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_s{(char)k}{i:x2}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_s{(char)k}{i:x2}_{j:D2}.wtb");

                    _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_s{(char)k}_ex{i:x2}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_s{(char)k}_ex{i:x2}_{j:D2}.wtb");

                    _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_{(char)k}{i:x2}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_{(char)k}{i:x2}_{j:D2}.wtb");

                    for (int l = 0; l < 15; l++)
                    {
                        _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_s{(char)k}{i:x2}_{j:D2}_{l:D2}.tex.texb");
                        _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_s{(char)k}{i:x2}_{j:D2}_{l:D2}.wtb");
                        _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_{(char)k}{i:x2}_{j:D2}_{l:D2}.tex.texb");
                        _archive.RegisterFileIfValid($"ui/layouts/hud/minimap/noatlastextures/mmap_{(char)k}{i:x2}_{j:D2}_{l:D2}.wtb");
                    }
                }
            }
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
            _archive.RegisterFileIfValid($"sound/japanese/vo_ci{i:x4}_m.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/japanese/vo_ci{i:x4}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/se/ci{i:x4}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/se/ci{i:x4}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/se/cw{i:x4}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/se/cw{i:x4}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/se/em{i:x4}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/se/em{i:x4}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/se/ct{i:x4}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/se/ct{i:x4}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/se/ba{i:x4}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/se/ba{i:x4}_01_{j:D2}_00.pck");
        }


        foreach (var type in type)
        {
            for (int i = 0; i < 0x10000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _archive.RegisterFileIfValid($"sound/japanese/vo_{type}{i:x4}.pck");
                    _archive.RegisterFileIfValid($"sound/japanese/vo_{type}{i:x4}_town.pck");
                    _archive.RegisterFileIfValid($"sound/japanese/vo_{type}{i:x4}_town_01_{j:D2}_00.pck");
                    _archive.RegisterFileIfValid($"sound/japanese/vo_{type}{i:x4}_01_{j:D2}_00.pck");
                    _archive.RegisterFileIfValid($"sound/japanese/vo_{type}{i:x4}_01_{j:D2}_00_m.pck");
                }
            }
        }
        


        for (int i = 0; i < 0x1000; i++)
        {
            _archive.RegisterFileIfValid($"sound/japanese/vo_ft{i:x3}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/japanese/vo_ft{i:x3}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/japanese/vo_r{i:x3}.pck");
            _archive.RegisterFileIfValid($"sound/japanese/vo_r{i:x3}_m.pck");
            _archive.RegisterFileIfValid($"sound/se/r{i:x3}.pck");
            _archive.RegisterFileIfValid($"sound/se/r{i:x3}_m.pck");
        }

        for (int i = 0; i < 1000000; i++)
        {
            _archive.RegisterFileIfValid($"sound/japanese/vo_cw{i:D6}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/japanese/vo_cw{i:D6}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/japanese/vo_ct{i:D6}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/japanese/vo_ct{i:D6}_01_{j:D2}_00.pck");

            _archive.RegisterFileIfValid($"sound/japanese/vo_cn{i:D6}.pck");
            for (int j = 0; j < 10; j++)
                _archive.RegisterFileIfValid($"sound/japanese/vo_cn{i:D6}_01_{j:D2}_00.pck");

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
            _archive.RegisterFileIfValid($"ui/layouts/common/image_quest/noatlastextures/cmn_imgqst_location_{i:D2}.tex.texb");
        }

        for (int i = 0; i < 1000; i++)
        {
            _archive.RegisterFileIfValid($"ui/layouts/common/image_item/noatlastextures/cmn_icitm_icon_wbg{i:D3}.wtb");
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
            _archive.RegisterFileIfValid($"ui/layouts/common/image_word/noatlastextures/cmn_imgword_location_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/layouts/common/image_word/noatlastextures/cmn_imgword_common_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/layouts/common/image_word/noatlastextures/cmn_imgword_primalbeasts_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/layouts/common/image_word/noatlastextures/cmn_imgword_species_{i:D4}.wtb");
            _archive.RegisterFileIfValid($"ui/layouts/common/image_chami/noatlastextures/cmn_imgchm_mob{i:D4}.wtb");

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
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_s_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_s_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_{type}{i:X4}_glow.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_s_{type}{i:X4}_glow.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_{type}{i:X4}_glow.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_s_{type}{i:X4}_glow.wtb");

                for (int j = 0; j < 5; j++)
                {
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_{type}{i:X4}_{j:D2}.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_s_{type}{i:X4}_{j:D2}.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_{type}{i:X4}_{j:D2}.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_s_{type}{i:X4}_{j:D2}.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_{type}{i:X4}_{j:D2}_glow.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_s_{type}{i:X4}_{j:D2}_glow.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_{type}{i:X4}_{j:D2}_glow.wtb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_s_{type}{i:X4}_{j:D2}_glow.wtb");
                }

                /*
                for (int j = 0; j < 10; j++)
                {
                    _archive.RegisterFileIfValid($"ui/layouts/common/chara_voice/noatlastextures/cmn_chrvo_{type}{i:X4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/chara_plprm/noatlastextures/cmn_chrprm_{type}{i:X4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_mainstory/noatlastextures/cmn_imgmain_{type}{i:X4}_{j:D2}.tex.texb");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_bookem/noatlastextures/cmn_imgbook_{type}{i:X4}_{j:D2}.wtb");
                    _archive.RegisterFileIfValid($"ui/movie/ab_{type}{i:X4}_{j:D2}.bk2");
                    _archive.RegisterFileIfValid($"ui/layouts/common/image_chrcolor/noatlastextures/cmn_imgcol_{type}{i:X4}_c{j:D2}.wtb");

                }

                _archive.RegisterFileIfValid($"ui/layouts/telop/bossbattle/noatlastextures/jpn/tlp_bbtl_{type}{i:X4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/layouts/pause/limitbonus/noatlastextures/ps_lb_stree_{type}{i:X4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/layouts/hud/linklevel/noatlastextures/hud_lnklv_{type}{i:X4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/layouts/blacksmith/weapon/noatlastextures/bs_wpn_{type}{i:X4}.tex.texb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip/noatlastextures/cmn_imgequ_s_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/common/image_equip_s/noatlastextures/cmn_imgequ_s_{type}{i:X4}.wtb");
                _archive.RegisterFileIfValid($"ui/layouts/pause/limitbonus/noatlastextures/ps_lb_stree_{type}{i:X4}.wtb");
                */
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

    public void BruteforceSoundsAndLipsync()
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

        // This helps a lot - applying entity to entity sounds (there's a lot)
        List<string> lipsyncFiles = [];
        foreach (var file in _archive.ArchiveFilesHashTable)
        {
            if (file.Key.StartsWith("sound/lipsync/"))
                lipsyncFiles.Add(Path.GetFileName(file.Key));
        }

        List<string> entities = [];
        foreach (var lipsync in lipsyncFiles)
        {
            entities.Add(lipsync.Substring(0, 6));
        }
        entities = entities.Distinct().ToList();

        foreach (var lipsync in lipsyncFiles)
        {
            foreach (var pref in entities)
            {
                _archive.RegisterFileIfValid($"sound/lipsync/eng/{pref}/{pref}_{lipsync.Substring(7)}");
                _archive.RegisterFileIfValid($"sound/lipsync/eng/{pref}/{lipsync.Substring(7)}");
                _archive.RegisterFileIfValid($"sound/lipsync/eng/{pref}/{lipsync}");
            }
        }

    }

    public void BruteforceFromStringList()
    {
        // Requires file generated with the following command (can take a while, 1gb)
        // strings2 -r "extracted/*" > strings.txt

        using var sr = new StreamReader(@"D:\Games\SteamLibrary\steamapps\common\Granblue Fantasy Relink\strings.txt");
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
                _archive.RegisterFileIfValid("system/camera/data/" + sub + ".msg");
                _archive.RegisterFileIfValid(sub.Replace("tga", "wtb"));
                _archive.RegisterFileIfValid(sub.Replace("yml", "msg"));
                _archive.RegisterFileIfValid(sub.Replace("dds", "wtb"));
                
                _archive.RegisterFileIfValid(sub.Replace("yml", "msg")); // layout files refers to yml

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

    public void BruteforceEffectFolder()
    {
        for (int i = 0; i < 0x1000; i++)
        {
            _archive.RegisterFileIfValid($"effect/primitive/{i:x3}.bxm");
            _archive.RegisterFileIfValid($"effect/vertexanimationtextures/{i:X3}.vat");
        }
    }

    public void BruteforceEffectPrefix(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            _archive.RegisterFileIfValid($"effect/{prefix}{i:x4}.bxm");
        }
    }

    public void BruteforceFileReferencesFromLayout()
    {
        // Requires files extracted beforehand
        foreach (var file in Directory.GetFiles(Path.Combine(_archive.GetDirectory(), "ext_1_3_1", "layout"), "*.msg", SearchOption.AllDirectories))
        {
            try
            {
                byte[] buf = File.ReadAllBytes(file);
                string json = MessagePack.MessagePackSerializer.ConvertToJson(buf);
                JsonDocument doc = JsonDocument.Parse(json);

                VisitJsonElementForLocalIBL(doc.RootElement);
            }
            catch (Exception ex)
            {

            }
        }

        foreach (var file in Directory.GetFiles(Path.Combine(_archive.GetDirectory(), "ext_1_3_1", ".unmapped"), "*.msg", SearchOption.AllDirectories))
        {
            try
            {
                byte[] buf = File.ReadAllBytes(file);
                string json = MessagePack.MessagePackSerializer.ConvertToJson(buf);
                JsonDocument doc = JsonDocument.Parse(json);

                VisitJsonElementForLocalIBL(doc.RootElement);
            }
            catch (Exception ex)
            {
                
            }
        }

        void VisitJsonElementForLocalIBL(JsonElement elem)
        {
            if (elem.ValueKind == JsonValueKind.Object)
            {
                foreach (var i in elem.EnumerateObject())
                {
                    if (i.Name == "LocalIBLSceneObject")
                    {
                        foreach (var iblElem in i.Value.EnumerateObject())
                        {
                            if (iblElem.Name == "mUuid")
                            {
                                List<ulong> uuids = []; // cy::ISceneObject::UUID aka cyan::u64x2
                                foreach (var uuidElem in iblElem.Value.EnumerateArray())
                                {
                                    uuids.Add(uuidElem.GetUInt64());
                                }

                                // localIBL/{}{:x}{:x}{}.wtb
                                _archive.RegisterFileIfValid($"localIBL/{uuids[0]:x8}{uuids[1]:x8}.wtb");
                                _archive.RegisterFileIfValid($"localIBL/irradiance/{uuids[0]:x8}{uuids[1]:x8}_irradiance.wtb");

                            }
                        }
                    }
                    else if (i.Name == "actionBehaviorFunctionArgs_")
                    {
                        foreach (var j in i.Value.EnumerateArray())
                        {
                            if (j.ValueKind == JsonValueKind.Array)
                            {
                                List<string> strs = [];
                                foreach (var k in j.EnumerateArray())
                                {
                                    if (k.ValueKind == JsonValueKind.String)
                                    {
                                        strs.Add(k.GetString());
                                        ;
                                    }
                                }

                                if (strs.Count == 2)
                                {
                                    _archive.RegisterFileIfValid($"system/fsm/{strs[0]}/{strs[0]}_{strs[1]}_fsm_ingame.msg");
                                }
                            }
                            ;
                        }
                    }
                    else
                    {

                        if (i.Value.ValueKind == JsonValueKind.Object)
                            VisitJsonElementForLocalIBL(i.Value);
                        else if (i.Value.ValueKind == JsonValueKind.Array)
                        {
                            foreach (JsonElement arrValue in i.Value.EnumerateArray())
                            {
                                VisitJsonElementForLocalIBL(arrValue);
                            }
                        }
                    }
                }
            }
        }
    }

    public void BruteforceFileReferencesFromFSM()
    {
        // Requires files extracted beforehand
        foreach (var file in Directory.GetFiles(Path.Combine(_archive.GetDirectory(), "ext_1.2.1", "system", "fsm"), "*.msg", SearchOption.AllDirectories))
        {
            try
            {
                byte[] buf = File.ReadAllBytes(file);
                string json = MessagePack.MessagePackSerializer.ConvertToJson(buf);
                JsonDocument doc = JsonDocument.Parse(json);

                VisitJsonElementForFSM(doc.RootElement);
            }
            catch (Exception ex)
            {

            }
        }

        void VisitJsonElementForFSM(JsonElement elem)
        {
            if (elem.ValueKind == JsonValueKind.Object)
            {
                foreach (var i in elem.EnumerateObject())
                {
                    if (i.Name == "fsmFolderName_")
                    {
                        string folder = i.Value.GetString();
                        if (string.IsNullOrEmpty(folder))
                            continue;

                        var name = elem.GetProperty("fsmName_").GetString();
                        _archive.RegisterFileIfValid($"system/fsm/{folder}/{folder}_{name}_fsm_ingame.msg");
                    }
                    else
                    {

                        if (i.Value.ValueKind == JsonValueKind.Object)
                            VisitJsonElementForFSM(i.Value);
                        else if (i.Value.ValueKind == JsonValueKind.Array)
                        {
                            foreach (JsonElement arrValue in i.Value.EnumerateArray())
                            {
                                VisitJsonElementForFSM(arrValue);
                            }
                        }
                    }
                }
            }
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

    public void BruteforceSystemPlayerData(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            string path = $"system/player/data/{prefix}{i:x4}/{prefix}{i:x4}.msg";
            _archive.RegisterFileIfValid(path);

            path = $"system/player/data/{prefix}{i:x4}/{prefix}{i:x4}_action.msg";
            _archive.RegisterFileIfValid(path);

            path = $"system/player/data/{prefix}{i:x4}/{prefix}{i:x4}parameter.msg";
            _archive.RegisterFileIfValid(path);
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

            for (int j = 1000; j < 1100; j++)
            {
                path = $"model/{prefix}/{prefix}{i:x4}/vars/{j}.mmat";
                _archive.RegisterFileIfValid(path);
            }
        }
    }

    public void BruteforceFinishCamera(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            string path = $"system/finishcamera/{prefix}{i:x4}/{prefix}{i:x4}_camera_parameter.msg";
            _archive.RegisterFileIfValid(path);
        }
    }

    public void BruteforceBehavior(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            string path = $"system/behaviorparam/{prefix}/data/{prefix}{i:x4}.msg";
            _archive.RegisterFileIfValid(path);
        }
    }

    public void BruteforcePreset(string prefix)
    {
        for (int i = 0; i < 0x10000; i++)
        {
            string path = $"system/preset/{prefix}{i:x4}_preset.msg";
            _archive.RegisterFileIfValid(path);
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

    public void BruteforceSeqBxm()
    {
        foreach (var type in type)
        {
            string typeDir = Path.Combine(_archive.GetDirectory(), "ext_1_3_1", type);
            if (Directory.Exists(typeDir))
            {
                foreach (var dir in Directory.GetDirectories(typeDir))
                {
                    Console.WriteLine(dir);
                    string modelName = Path.GetFileNameWithoutExtension(dir);
                    for (int i = 0; i < 0x10000; i++)
                    {
                        for (int k = 0; k < 14; k++)
                        {
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_ik.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_flags.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_facialmotion.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_effect.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_attack.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_mesh.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_eyecontrol.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_se.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_speed.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_vib.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_camera.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq_edit_cloth.bxm");
                            _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}_{k}_seq.bxm");
                        }

                        _archive.RegisterFileIfValid($"{type}/{modelName}/{modelName}_{i:x4}.mot");
                    }
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
