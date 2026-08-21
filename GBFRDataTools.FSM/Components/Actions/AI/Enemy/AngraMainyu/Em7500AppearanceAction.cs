using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AppearanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AppearanceAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 10f;

    [JsonPropertyName("isSetInitPosHandTeleport_")]
    public bool IsSetInitPosHandTeleport { get; set; } = false;

    [JsonPropertyName("isSetUseHandEventMode_")]
    public bool IsSetUseHandEventMode { get; set; } = false;

    [JsonPropertyName("isSetMegaHand_")]
    public bool IsSetMegaHand { get; set; } = false;

    [JsonPropertyName("isSetForcedNeckTarget_")]
    public bool IsSetForcedNeckTarget { get; set; } = false;

    [JsonPropertyName("isExitAppear_")]
    public bool IsExitAppear { get; set; } = true;
}
