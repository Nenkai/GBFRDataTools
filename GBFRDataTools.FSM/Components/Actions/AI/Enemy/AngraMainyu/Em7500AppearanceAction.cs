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
    public float WaitTime { get; set; } = 10f; // Offset 0x40

    [JsonPropertyName("isSetInitPosHandTeleport_")]
    public bool IsSetInitPosHandTeleport { get; set; } = false; // Offset 0x44

    [JsonPropertyName("isSetUseHandEventMode_")]
    public bool IsSetUseHandEventMode { get; set; } = false; // Offset 0x45

    [JsonPropertyName("isSetMegaHand_")]
    public bool IsSetMegaHand { get; set; } = false; // Offset 0x46

    [JsonPropertyName("isSetForcedNeckTarget_")]
    public bool IsSetForcedNeckTarget { get; set; } = false; // Offset 0x47

    [JsonPropertyName("isExitAppear_")]
    public bool IsExitAppear { get; set; } = true; // Offset 0x48

    public Em7500AppearanceAction()
    {
    }
}
