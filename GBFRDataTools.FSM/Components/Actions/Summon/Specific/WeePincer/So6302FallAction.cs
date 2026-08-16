using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.WeePincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So6302FallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So6302FallAction);

    [JsonPropertyName("attackParam_")]
    public AttackParam_ AttackParam { get; set; } = new();

    public class AttackParam_ /* So6302FallAction::AttackParam */
    {
        [JsonPropertyName("fallFrame_")]
        public int FallFrame { get; set; }
    
        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; }
    
        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; }
    
        [JsonPropertyName("attackSize_")]
        public Vector4 AttackSize { get; set; }
    
        [JsonPropertyName("attackOffsetY_")]
        public float AttackOffsetY { get; set; }
    
        [JsonPropertyName("spArtsRate_")]
        public float SpArtsRate { get; set; }
    
        [JsonPropertyName("hitStopSec_")]
        public float HitStopSec { get; set; }

        [JsonPropertyName("hitVibrationType_")]
        public int HitVibrationType { get; set; }
    
        [JsonPropertyName("hitVibrationPowerL_")]
        public Vector2 HitVibrationPowerL { get; set; }
    
        [JsonPropertyName("hitVibrationPowerR_")]
        public Vector2 HitVibrationPowerR { get; set; }
    
        [JsonPropertyName("hitVibrationSec_")]
        public float HitVibrationSec { get; set; }
    
        [JsonPropertyName("attackStartFrame_")]
        public int AttackStartFrame { get; set; }
    
        [JsonPropertyName("attackFrame_")]
        public int AttackFrame { get; set; }
    
        [JsonPropertyName("attackMultiHitIntervalFrame_")]
        public int AttackMultiHitIntervalFrame { get; set; }
    
        [JsonPropertyName("reaction_")]
        public int Reaction { get; set; }
    }
}