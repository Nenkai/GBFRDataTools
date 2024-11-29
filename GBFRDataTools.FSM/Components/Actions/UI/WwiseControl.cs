using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class WwiseControl : ActionComponent
{
    [JsonPropertyName("seType_")]
    public SeType SeType { get; set; } = SeType.None;

    [JsonPropertyName("isOut_")]
    public bool IsOut { get; set; } = false;
}

public enum SeType
{
    None,
    core_sys_shop_blacksmith,
    core_sys_shop_blacksmith_sub,
    core_sys_shop_siero,
    core_sys_shop_siero_sub,
    core_sys_shop_zasuba,
    core_sys_nameinput,
    core_sys_shop_quest,
    core_sys_shop_quest_sub,
    core_sys_shop_quest_receive,
    core_pause, // has hardcoded check
    core_sys_trialbattle_result, 
    core_sys_trialbattle_modemanu,
    core_sys_trialbattle_modechoice,
    core_sys_tutorialpause,
    core_sys_multiquest_result,
    core_sys_shop_charaunlock,
    core_sys_islandmove,
    core_sys_ft,
    core_pause_online, // has hardcoded check
    core_sys_tutorialpause_online, 
    core_sys_shop_siero_sub_online,
    core_sys_shop_quest_sub_pause,
    core_sys_shop_blacksmith_sub_online,
    core_sys_shop_zasuba_result,
    core_sys_shop_savepoint,
    core_sys_tutorialbutton_control,
    core_sysgameev_pause,
    core_sys_lyrianote_from_menu,
    core_sys_lyrianote_from_game,
}