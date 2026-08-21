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
    public float NextCoolTime { get; set; } = 0f;

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } = "1130";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("signPos_")]
    public Vector4 SignPos { get; set; } = new Vector4(0.5f, 0f, 1.1f, 1f);

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("marshDistanceMin_")]
    public float MarshDistanceMin { get; set; } = 1.8f; 

    [JsonPropertyName("marshDistanceMax_")]
    public float MarshDistanceMax { get; set; } = 7.2f; 

    [JsonPropertyName("slashWaitTime_")]
    public float SlashWaitTime { get; set; } = 0.5f; 

    [JsonPropertyName("animStartTime_")]
    public float AnimStartTime { get; set; } = -1f; 

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1f; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WhirlWindInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 

        [JsonPropertyName("moveDirRotY_")]
        public float MoveDirRotY { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("shotNum_")]
        public int ShotNum { get; set; } 

        [JsonPropertyName("shotRadius_")]
        public float ShotRadius { get; set; } 

        [JsonPropertyName("shotLifeTime_")]
        public float ShotLifeTime { get; set; } 

        [JsonPropertyName("shotInitSpd_")]
        public float ShotInitSpd { get; set; } 

        [JsonPropertyName("shotMaxSpd_")]
        public float ShotMaxSpd { get; set; } 

        [JsonPropertyName("shotMoveSpdRange_")]
        public float ShotMoveSpdRange { get; set; } 

        [JsonPropertyName("shotEaseTime_")]
        public float ShotEaseTime { get; set; } 

        [JsonPropertyName("shotAmplitude_")]
        public float ShotAmplitude { get; set; } 

        [JsonPropertyName("shotPeriod_")]
        public float ShotPeriod { get; set; } 

        [JsonPropertyName("shotInfo_")]
        [Editable(false)]
        public BindingList<WhirlWindInfo> ShotInfo { get; set; } = [.. Enumerable.Repeat(new WhirlWindInfo(), 4)]; 
    }
}
