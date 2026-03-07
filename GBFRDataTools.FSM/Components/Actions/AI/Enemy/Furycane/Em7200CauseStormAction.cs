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
    public bool IsCreateAttackSign { get; set; } = false; // Offset 0x170

    [JsonPropertyName("isAssociateWith_")]
    public bool IsAssociateWith { get; set; } = false; // Offset 0x171

    [JsonPropertyName("isStormBigSize_")]
    public bool IsStormBigSize { get; set; } = false; // Offset 0x172

    [JsonPropertyName("stormType_")]
    public int StormType { get; set; } = 0; // Offset 0x174

    [JsonPropertyName("StormSetType_")]
    public int StormSetType { get; set; } = 0; // Offset 0x178

    [JsonPropertyName("stormNum_")]
    public int StormNum { get; set; } = 4; // Offset 0x17C

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; // Offset 0x180

    [JsonPropertyName("stormLifeTime_")]
    public float StormLifeTime { get; set; } = 20f; // Offset 0x184

    [JsonPropertyName("stormMoveSpd_")]
    public float StormMoveSpd { get; set; } = 16f; // Offset 0x188

    [JsonPropertyName("checkWallHitLength_")]
    public float CheckWallHitLength { get; set; } = 17.5f; // Offset 0x18C

    [JsonPropertyName("stormSetPositions_")]
    [Editable(false)]
    public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = [.. Enumerable.Repeat(new StormSetPosInfo(), 10)];// Offset 0x1F0

    [JsonPropertyName("stormSelfMoveLists_")]
    [Editable(false)]
    public BindingList<BindingList<StormSelfMoveInfo>> StormSelfMoveLists { get; set; } = [.. Enumerable.Repeat(new BindingList<StormSelfMoveInfo>(), 10)]; // Offset 0x330

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x190

    [JsonPropertyName("galeAddSpd_")]
    public float GaleAddSpd { get; set; } = 2f; // Offset 0x198

    [JsonPropertyName("galeAddSpdHard_")]
    public float GaleAddSpdHard { get; set; } = 4f; // Offset 0x19C

    [JsonPropertyName("galeDist_")]
    public float GaleDist { get; set; } = 10.2f; // Offset 0x1A0

    [JsonPropertyName("customType_")]
    public int CustomType { get; set; } = 0; // Offset 0x1A4

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 0.8333333f; // Offset 0x1A8

    [JsonPropertyName("signStartSe_")]
    public string SignStartSe { get; set; } // Offset 0x1B0

    [JsonPropertyName("signEndSe_")]
    public string SignEndSe { get; set; } // Offset 0x1D0

    public Em7200CauseStormAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public StormSetPosInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StormSelfMoveInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public StormSelfMoveInfo()
        {
        }
    }
}




