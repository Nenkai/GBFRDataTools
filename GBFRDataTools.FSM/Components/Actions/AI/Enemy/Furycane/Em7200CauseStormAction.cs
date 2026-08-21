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

public class Em7200CauseStormAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200CauseStormAction);

    [JsonPropertyName("isCreateAttackSign_")]
    public bool IsCreateAttackSign { get; set; } = false; 

    [JsonPropertyName("isAssociateWith_")]
    public bool IsAssociateWith { get; set; } = false; 

    [JsonPropertyName("isStormBigSize_")]
    public bool IsStormBigSize { get; set; } = false; 

    [JsonPropertyName("stormType_")]
    public int StormType { get; set; } = 0; 

    [JsonPropertyName("StormSetType_")]
    public int StormSetType { get; set; } = 0; 

    [JsonPropertyName("stormNum_")]
    public int StormNum { get; set; } = 4; 

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; 

    [JsonPropertyName("stormLifeTime_")]
    public float StormLifeTime { get; set; } = 20f; 

    [JsonPropertyName("stormMoveSpd_")]
    public float StormMoveSpd { get; set; } = 16f; 

    [JsonPropertyName("checkWallHitLength_")]
    public float CheckWallHitLength { get; set; } = 17.5f; 

    [JsonPropertyName("stormSetPositions_")]
    [Editable(false)]
    public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = [.. Enumerable.Repeat(new StormSetPosInfo(), 10)];

    [JsonPropertyName("stormSelfMoveLists_")]
    [Editable(false)]
    public BindingList<BindingList<StormSelfMoveInfo>> StormSelfMoveLists { get; set; } = [.. Enumerable.Repeat(new BindingList<StormSelfMoveInfo>(), 10)];

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } = "1600";

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 2f; 

    [JsonPropertyName("galeAddSpdHard_")]
    public float GaleAddSpdHard { get; set; } = 4f; 

    [JsonPropertyName("galeDist_")]
    public float GaleDist { get; set; } = 10.2f; 

    [JsonPropertyName("customType_")]
    public int CustomType { get; set; } = 0; 

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 0.8333333f;

    [JsonPropertyName("signStartSe_")]
    public string? SignStartSe { get; set; } = "em7200_atk_magiccircle_sign_start";

    [JsonPropertyName("signEndSe_")]
    public string? SignEndSe { get; set; } = "em7200_atk_magiccircle_sign_end";

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
}




