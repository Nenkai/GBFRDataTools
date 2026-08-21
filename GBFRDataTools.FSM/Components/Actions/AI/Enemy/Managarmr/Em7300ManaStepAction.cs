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
    public BindingList<StepInfo> StepInfos { get; set; } = []; 

    [JsonPropertyName("isTargetManualPlayer_")]
    public bool IsTargetManualPlayer { get; set; } = false; 

    [JsonPropertyName("isAttackSign_")]
    public bool IsAttackSign { get; set; } = false; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StepInfo
    {
        [JsonPropertyName("type_")]
        public int Type { get; set; } 

        [JsonPropertyName("homingAngle_")]
        public float HomingAngle { get; set; } 

        [JsonPropertyName("stepDist_")]
        public float StepDist { get; set; } 

        [JsonPropertyName("isUpdateTargetVector_")]
        public bool IsUpdateTargetVector { get; set; } 

        [JsonPropertyName("isInverseHoming_")]
        public bool IsInverseHoming { get; set; } 
    }
}
