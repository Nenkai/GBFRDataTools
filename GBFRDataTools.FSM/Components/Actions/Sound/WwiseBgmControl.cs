using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class WwiseBgmControl : ActionComponent
{
    [JsonPropertyName("bgmType_")]
    public BgmType BgmType { get; set; } = BgmType.BGM_None;

    [JsonPropertyName("isOut_")]
    public bool IsOut { get; set; } = false;
}

public enum BgmType
{
    BGM_None,
    BGM_Shop_Chelocarte,
    BGM_Shop_Zasuba,
    BGM_IslandMove,
    BGM_Notice,
    BGM_FateEp,
    BGM_MainMenu,
    BGM_Pause_IngameEv
}
