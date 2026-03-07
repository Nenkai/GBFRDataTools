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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300ManaStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300ManaStepAction);

    [JsonPropertyName("stepInfos_")]
    public BindingList<StepInfo> StepInfos { get; set; } = []; // Offset 0x68

    [JsonPropertyName("isTargetManualPlayer_")]
    public bool IsTargetManualPlayer { get; set; } = false; // Offset 0x80

    [JsonPropertyName("isAttackSign_")]
    public bool IsAttackSign { get; set; } = false; // Offset 0x81

    public Em7300ManaStepAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StepInfo
    {
        [JsonPropertyName("type_")]
        public int Type { get; set; } // Offset 0x8

        [JsonPropertyName("homingAngle_")]
        public float HomingAngle { get; set; } // Offset 0xC

        [JsonPropertyName("stepDist_")]
        public float StepDist { get; set; } // Offset 0x10

        [JsonPropertyName("isUpdateTargetVector_")]
        public bool IsUpdateTargetVector { get; set; } // Offset 0x14

        [JsonPropertyName("isInverseHoming_")]
        public bool IsInverseHoming { get; set; } // Offset 0x15

        public StepInfo()
        {
        }
    }
}
