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

public class Em7201CauseGaleAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201CauseGaleAction);

    [JsonPropertyName("galeType_")]
    public int GaleType { get; set; } = 0; // Offset 0x508

    [JsonPropertyName("attractAtkStartRange_")]
    public float AttractAtkStartRange { get; set; } = 7.5f; // Offset 0x50C

    [JsonPropertyName("causeToSelfMinTime_")]
    public float CauseToSelfMinTime { get; set; } = 1.8f; // Offset 0x510

    [JsonPropertyName("nextCoolTime_")]
    [Editable(false)]
    public BindingList<float> NextCoolTime { get; set; } = [.. Enumerable.Repeat(0, 5)]; // Offset 0x514

    [JsonPropertyName("motionIdStart_")]
    public string MotionIdStart { get; set; } // Offset 0x528

    [JsonPropertyName("motionIdLoop_")]
    public string MotionIdLoop { get; set; } // Offset 0x548

    [JsonPropertyName("motionIdEnd_")]
    public string MotionIdEnd { get; set; } // Offset 0x568

    [JsonPropertyName("aiLevelParamArray_")]
    [Editable(false)]
    public BindingList<DependAILevelParam> AiLevelParamArray { get; set; } = [.. Enumerable.Repeat(new DependAILevelParam(), 5)];  // Offset 0x588

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 1f; // Offset 0x600

    [JsonPropertyName("attackSignRadius_")]
    public float AttackSignRadius { get; set; } = 8f; // Offset 0x604

    [JsonPropertyName("attackSignLength_")]
    public float AttackSignLength { get; set; } = 0f; // Offset 0x608

    public Em7201CauseGaleAction()
    {
    }

    public class DependAILevelParam
    {
        [JsonPropertyName("galeAddSpd_")]
        public float GaleAddSpd { get; set; } // Offset 0x8

        [JsonPropertyName("galeLifeTime_")]
        public float GaleLifeTime { get; set; } // Offset 0xC

        [JsonPropertyName("loopMotionTime_")]
        public float LoopMotionTime { get; set; } // Offset 0x10

        [JsonPropertyName("isForceAttractAttack_")]
        public bool IsForceAttractAttack { get; set; } // Offset 0x14

        public DependAILevelParam()
        {
        }
    }
}