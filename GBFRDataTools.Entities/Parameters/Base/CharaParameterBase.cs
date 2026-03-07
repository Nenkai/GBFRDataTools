using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Parameters.Base;

public class CharaParameterBase
{
    [JsonPropertyName("hp_")]
    public int Hp { get; set; }

    [JsonPropertyName("atk_")]
    public int Atk { get; set; }

    [JsonPropertyName("break_")]
    public int Break { get; set; }

    [JsonPropertyName("def_")]
    public float Def { get; set; }

    [JsonPropertyName("endurance_")]
    public int Endurance { get; set; }

    [JsonPropertyName("exp_")]
    public int Exp { get; set; }

    [JsonPropertyName("hitSEMaxBreak_")]
    public float HitSEMaxBreak { get; set; }

    [JsonPropertyName("hitSEMinBreak_")]
    public float HitSEMinBreak { get; set; }

    [JsonPropertyName("hpCurve_")]
    public GuiImportableCurve<float> HpCurve { get; set; }

    [JsonPropertyName("atkCurve_")]
    public GuiImportableCurve<float> AtkCurve { get; set; }

    [JsonPropertyName("defCurve_")]
    public GuiImportableCurve<float> DefCurve { get; set; }

    [JsonPropertyName("expCurve_")]
    public GuiImportableCurve<float> ExpCurve { get; set; }

    [JsonPropertyName("fsmParam_")]
    public CharaAutoFSMParam FsmParam { get; set; }
}
