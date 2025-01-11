using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl2200Param : PlayerParameterInfo
{
    [JsonPropertyName("swordShineGageDecreasePoint_")]
    public float SwordShineGageDecreasePoint { get; set; }

    [JsonPropertyName("swordShineAutoDecreaseStopSec_")]
    public float SwordShineAutoDecreaseStopSec { get; set; }

    [JsonPropertyName("inifinitoCreareSwordNum_")]
    public int InifinitoCreareSwordNum { get; set; }

    [JsonPropertyName("inifinitoCreareSwordRadius_")]
    public float InifinitoCreareSwordRadius { get; set; }

    [JsonPropertyName("swordGodApeearingSec_")]
    public float SwordGodApeearingSec { get; set; }

    [JsonPropertyName("gageIncreaseDataList_")]
    public BindingList<GageAddParam> GageIncreaseDataList { get; set; } = []; // std::vector<Pl2200Param::GageAddParam>

    [JsonPropertyName("linkAttack_SwordGodGageIncrement_")]
    public float LinkAttack_SwordGodGageIncrement { get; set; }

    [JsonPropertyName("linkAttack_SwordShineGageIncrement_")]
    public float LinkAttack_SwordShineGageIncrement { get; set; }

    [JsonPropertyName("swordGodGageResetGraseSec_")]
    public float SwordGodGageResetGraseSec { get; set; }

    [JsonPropertyName("ability08RetrySec_")]
    public float Ability08RetrySec { get; set; }

    public class GageAddParam // Pl2200Param::GageAddParam
    {
        [JsonPropertyName("actionID_")]
        public int ActionID { get; set; }

        [JsonPropertyName("swordGodGageIncrease_")]
        public float SwordGodGageIncrease { get; set; }

        [JsonPropertyName("swordShineGageIncrease_")]
        public float SwordShineGageIncrease { get; set; }

    }
}
