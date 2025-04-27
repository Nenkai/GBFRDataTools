using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201CauseWhirlWindAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CauseWhirlWindAction);

    [JsonPropertyName("nextCoolTime_")]
    public float NextCoolTime { get; set; } = 0f; // Offset 0x500

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x508

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x540

    [JsonPropertyName("signPos_")]
    public Vector4 SignPos { get; set; } = new Vector4(0.5f, 0f, 1.1f, 1f); // Offset 0xCC0

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } // Offset 0x528

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; // Offset 0xCD0

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; // Offset 0xCD4

    [JsonPropertyName("slashWaitTime_")]
    public float SlashWaitTime { get; set; } = 0.5f; // Offset 0xCDC

    [JsonPropertyName("animStartTime_")]
    public float AnimStartTime { get; set; } = -1f; // Offset 0xCE0

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1f; // Offset 0xCE4

    public Em7201CauseWhirlWindAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x20

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } // Offset 0x10

        public WhirlWindInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("shotNum_")]
        public int ShotNum { get; set; } // Offset 0x10

        [JsonPropertyName("shotRadius_")]
        public float ShotRadius { get; set; } // Offset 0x14

        [JsonPropertyName("shotLifeTime_")]
        public float ShotLifeTime { get; set; } // Offset 0x18

        [JsonPropertyName("shotInitSpd_")]
        public float ShotInitSpd { get; set; } // Offset 0x1C

        [JsonPropertyName("shotMaxSpd_")]
        public float ShotMaxSpd { get; set; } // Offset 0x20

        [JsonPropertyName("shotMoveSpdRange_")]
        public float ShotMoveSpdRange { get; set; } // Offset 0x24

        [JsonPropertyName("shotEaseTime_")]
        public float ShotEaseTime { get; set; } // Offset 0x30

        [JsonPropertyName("shotAmplitude_")]
        public float ShotAmplitude { get; set; } // Offset 0x28

        [JsonPropertyName("shotPeriod_")]
        public float ShotPeriod { get; set; } // Offset 0x2C

        [JsonPropertyName("shotInfo_")]
        [Editable(false)]
        public BindingList<WhirlWindInfo> ShotInfo { get; set; } = [.. Enumerable.Repeat(new WhirlWindInfo(), 4)]; // Offset 0x40

        public DependAILevelParam()
        {
        }
    }
}
