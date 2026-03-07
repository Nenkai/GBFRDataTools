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
    public bool IsCreateAttackSign { get; set; } = false; // Offset 0x190

    [JsonPropertyName("isStormBigSize_")]
    public bool IsStormBigSize { get; set; } = false; // Offset 0x191

    [JsonPropertyName("isAssociateWith_")]
    public bool IsAssociateWith { get; set; } = false; // Offset 0x192

    [JsonPropertyName("stormType_")]
    public int StormType { get; set; } = 0; // Offset 0x194

    [JsonPropertyName("stormSetType_")]
    public int StormSetType { get; set; } = 0; // Offset 0x198

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x1A0

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x1B0

    [JsonPropertyName("signStartSe_")]
    public string SignStartSe { get; set; } // Offset 0xD90

    [JsonPropertyName("signEndSe_")]
    public string SignEndSe { get; set; } // Offset 0xDB0

    public Em7201CauseStormAction()
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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DependAILevelParam
    {
        [JsonPropertyName("stormType_")]
        public int StormType { get; set; } // Offset 0x10

        [JsonPropertyName("stormNum_")]
        public int StormNum { get; set; } // Offset 0x14

        [JsonPropertyName("stormRadius_")]
        public float StormRadius { get; set; } // Offset 0x18

        [JsonPropertyName("stormLifeTime_")]
        public float StormLifeTime { get; set; } // Offset 0x1C

        [JsonPropertyName("stormMoveSpd_")]
        public float StormMoveSpd { get; set; } // Offset 0x20

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0x24

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } // Offset 0x28

        [JsonPropertyName("stormSetPositions_")]
        [Editable(false)]
        public BindingList<StormSetPosInfo> StormSetPositions { get; set; } = [.. Enumerable.Repeat(new StormSetPosInfo(), 10)]; // Offset 0x30

        [JsonPropertyName("stormSelfMoveLists_")]
        [Editable(false)]
        public BindingList<BindingList<StormSelfMoveInfo>> StormSelfMoveLists { get; set; } = [.. Enumerable.Repeat(new BindingList<StormSelfMoveInfo>(), 10)]; // Offset 0x170

        public DependAILevelParam()
        {
        }
    }
}