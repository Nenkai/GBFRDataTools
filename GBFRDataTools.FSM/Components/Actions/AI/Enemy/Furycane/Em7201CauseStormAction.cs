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

public class Em7201CauseStormAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CauseStormAction);

    [JsonPropertyName("isCreateAttackSign_")]
    public bool IsCreateAttackSign { get; set; } = false; 

    [JsonPropertyName("isStormBigSize_")]
    public bool IsStormBigSize { get; set; } = false; 

    [JsonPropertyName("isAssociateWith_")]
    public bool IsAssociateWith { get; set; } = false; 

    [JsonPropertyName("stormType_")]
    public int StormType { get; set; } = 0; 

    [JsonPropertyName("stormSetType_")]
    public int StormSetType { get; set; } = 0;

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } = "1600";

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)];

    [JsonPropertyName("signStartSe_")]
    public string SignStartSe { get; set; } = "em7200_atk_magiccircle_sign_start";

    [JsonPropertyName("signEndSe_")]
    public string SignEndSe { get; set; } = "em7200_atk_magiccircle_sign_end";

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSelfMoveInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("stormType_")]
        public int StormType { get; set; } 

        [JsonPropertyName("stormNum_")]
        public int StormNum { get; set; } 

        [JsonPropertyName("stormRadius_")]
        public float StormRadius { get; set; } 

        [JsonPropertyName("stormLifeTime_")]
        public float StormLifeTime { get; set; } 

        [JsonPropertyName("stormMoveSpd_")]
        public float StormMoveSpd { get; set; } 

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } 

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } 

        [JsonPropertyName("stormSetPositions_")]
        [Editable(false)]
        public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = [.. Enumerable.Repeat(new StormSetPosInfo(), 10)]; 

        [JsonPropertyName("stormSelfMoveLists_")]
        [Editable(false)]
        public BindingList<BindingList<StormSelfMoveInfo>> StormSelfMoveLists { get; set; } = [.. Enumerable.Repeat(new BindingList<StormSelfMoveInfo>(), 10)]; 
    }
}