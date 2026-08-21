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

public class Em7201ExSpecialArtsFinishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExSpecialArtsFinishAction);

    [JsonPropertyName("shotOffset_")]
    public Vector4 ShotOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; 

    [JsonPropertyName("stormUse_")]
    public bool StormUse { get; set; } = false; 

    [JsonPropertyName("stormSetPositions_")]
    public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = []; 

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; 

    [JsonPropertyName("stageBaseMoveSpd_")]
    public float StageBaseMoveSpd { get; set; } = 15f;

    [JsonPropertyName("startMotionId_")]
    public string? StartMotionId { get; set; } = "7008";

    [JsonPropertyName("endMotionId_")]
    public string? EndMotionId { get; set; } = "1a57";

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }


    public class DependAILevelParam
    {
        [JsonPropertyName("shotCount_")]
        public int ShotCount { get; set; } 

        [JsonPropertyName("shotSpd_")]
        public float ShotSpd { get; set; } 

        [JsonPropertyName("shotLifeTime_")]
        public float ShotLifeTime { get; set; } 

        [JsonPropertyName("galeToOutsideAddSpd_")]
        public float GaleToOutsideAddSpd { get; set; } 

        [JsonPropertyName("galeToOutsideDist_")]
        public float GaleToOutsideDist { get; set; } 

        [JsonPropertyName("galeToOutsideTime_")]
        public float GaleToOutsideTime { get; set; } 

        [JsonPropertyName("galeToSelfAddSpd_")]
        public float GaleToSelfAddSpd { get; set; } 

        [JsonPropertyName("galeToSelfDist_")]
        public float GaleToSelfDist { get; set; } 

        [JsonPropertyName("galeToSelfTime_")]
        public float GaleToSelfTime { get; set; } 
    }
}

