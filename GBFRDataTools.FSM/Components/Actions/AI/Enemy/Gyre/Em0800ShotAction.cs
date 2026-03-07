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
    public string MotionId { get; set; } // Offset 0x30

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; } // Offset 0x50

    [JsonPropertyName("fsmFileName_")]
    public string FsmFileName { get; set; } // Offset 0x70

    [JsonPropertyName("em0800ShotParams_")]
    public BindingList<Em0800ShotParam> Em0800ShotParams { get; set; } = []; // Offset 0xB8

    [JsonPropertyName("shotType_")]
    public int ShotType { get; set; } = 0; // Offset 0x90

    [JsonPropertyName("offsetType_")]
    public int OffsetType { get; set; } = 0; // Offset 0x94

    [JsonPropertyName("throwMode_")]
    public bool ThrowMode { get; set; } = false; // Offset 0x99

    [JsonPropertyName("throwStartOffsetPos_")]
    public Vector4 ThrowStartOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xA0

    [JsonPropertyName("throwLandingTime_")]
    public float ThrowLandingTime { get; set; } = 0.1f; // Offset 0xB0

    [JsonPropertyName("useAttackSignFlag_")]
    public bool UseAttackSignFlag { get; set; } = true; // Offset 0x98

    [JsonPropertyName("groundTarget_")]
    public bool GroundTarget { get; set; } = false; // Offset 0xB4

    public Em0800ShotAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em0800ShotParam
    {
        [JsonPropertyName("shotTrigTime_")]
        public float ShotTrigTime { get; set; } // Offset 0x10

        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } // Offset 0x20

        [JsonPropertyName("offsetRandomPos_")]
        public Vector4 OffsetRandomPos { get; set; } // Offset 0x60

        public Em0800ShotParam()
        {
        }
    }
}
