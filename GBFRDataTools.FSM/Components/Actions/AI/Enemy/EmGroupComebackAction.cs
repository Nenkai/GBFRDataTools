using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmGroupComebackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmGroupComebackAction);

    [JsonPropertyName("isComebackActor_")]
    public bool IsComebackActor { get; set; } = false;

    [JsonPropertyName("isUseFade_")]
    public bool IsUseFade { get; set; } = false;

    [JsonPropertyName("isUseGravity_")]
    public bool IsUseGravity { get; set; } = true;

    [JsonPropertyName("playerOffsetDist_")]
    public float PlayerOffsetDist { get; set; } = 15f;

    [JsonPropertyName("cutMotParamList_")]
    public BindingList<CutMotionParameter> CutMotParamList { get; set; } = []; // std::vector<BT::EmGroupComebackAction::CutMotionParameter>

    [JsonPropertyName("comebackOffsetPos_")]
    public Vector4 ComebackOffsetPos { get; set; } = Vector4.UnitW;

    public class CutMotionParameter /* EmGroupComebackAction::CutMotionParameter */
    {
        [JsonPropertyName("isSkipRotForOffset_")]
        public bool IsSkipRotForOffset { get; set; }
    
        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; }
    
        [JsonPropertyName("offsetDir_")]
        public float OffsetDir { get; set; }
    
        [JsonPropertyName("nonCutUseIntervalFrame_")]
        public int NonCutUseIntervalFrame { get; set; }
    
        [JsonPropertyName("motId_")]
        public string MotId { get; set; }
    }
}
