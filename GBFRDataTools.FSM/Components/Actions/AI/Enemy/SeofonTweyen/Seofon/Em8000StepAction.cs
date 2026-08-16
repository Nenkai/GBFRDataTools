using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000StepAction);

    [JsonPropertyName("stepType_")]
    public int StepType { get; set; } = 0;

    [JsonPropertyName("isMotionCancel_")]
    public bool IsMotionCancel { get; set; } = false;

    [JsonPropertyName("isHL_")]
    public bool IsHL { get; set; } = false;

    [JsonPropertyName("isRecordStepDir_")]
    public bool IsRecordStepDir { get; set; } = false;

    [JsonPropertyName("isCheckPrevStep_")]
    public bool IsCheckPrevStep { get; set; } = false;
}
