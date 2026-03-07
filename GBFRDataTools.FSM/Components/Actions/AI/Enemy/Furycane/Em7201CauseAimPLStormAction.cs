using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201CauseAimPLStormAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CauseAimPLStormAction);

    [JsonPropertyName("stormRadius_")]
    public float StormRadius { get; set; } = 5f; // Offset 0x530

    [JsonPropertyName("nextCoolTime_")]
    public float NextCoolTime { get; set; } = 0f; // Offset 0x534

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x538

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)]; // Offset 0x558

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0; // Offset 0x620

    [JsonPropertyName("signStartSe_")]
    public string SignStartSe { get; set; } // Offset 0x628

    [JsonPropertyName("signEndSe_")]
    public string SignEndSe { get; set; } // Offset 0x648

    public Em7201CauseAimPLStormAction()
    {
    }

    public class DependAILevelParam
    {
        [JsonPropertyName("isUseStorm_")]
        public bool IsUseStorm { get; set; } // Offset 0x8

        [JsonPropertyName("stormMoveSpd_")]
        public float StormMoveSpd { get; set; } // Offset 0xC

        [JsonPropertyName("stormStopHomingDist_")]
        public float StormStopHomingDist { get; set; } // Offset 0x10

        [JsonPropertyName("stormStartMoveTime_")]
        public float StormStartMoveTime { get; set; } // Offset 0x14

        [JsonPropertyName("stormLifeTime_")]
        public float StormLifeTime { get; set; } // Offset 0x18

        [JsonPropertyName("isHoming_")]
        public bool IsHoming { get; set; } // Offset 0x1C

        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0x20

        [JsonPropertyName("galeDist_")]
        public float GaleDist { get; set; } // Offset 0x24

        public DependAILevelParam()
        {
        }
    }
}