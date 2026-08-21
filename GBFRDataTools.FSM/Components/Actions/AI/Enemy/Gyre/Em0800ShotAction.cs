using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0800ShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0800ShotAction);

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } 

    [JsonPropertyName("fsmClassName_")]
    public string? FsmClassName { get; set; } 

    [JsonPropertyName("fsmFileName_")]
    public string? FsmFileName { get; set; } 

    [JsonPropertyName("em0800ShotParams_")]
    public BindingList<Em0800ShotParam> Em0800ShotParams { get; set; } = []; 

    [JsonPropertyName("shotType_")]
    public int ShotType { get; set; } = 0; 

    [JsonPropertyName("offsetType_")]
    public int OffsetType { get; set; } = 0; 

    [JsonPropertyName("throwMode_")]
    public bool ThrowMode { get; set; } = false; 

    [JsonPropertyName("throwStartOffsetPos_")]
    public Vector4 ThrowStartOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("throwLandingTime_")]
    public float ThrowLandingTime { get; set; } = 0.1f; 

    [JsonPropertyName("useAttackSignFlag_")]
    public bool UseAttackSignFlag { get; set; } = true; 

    [JsonPropertyName("groundTarget_")]
    public bool GroundTarget { get; set; } = false; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em0800ShotParam
    {
        [JsonPropertyName("shotTrigTime_")]
        public float ShotTrigTime { get; set; } 

        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } 

        [JsonPropertyName("offsetRandomPos_")]
        public Vector4 OffsetRandomPos { get; set; } 
    }
}
