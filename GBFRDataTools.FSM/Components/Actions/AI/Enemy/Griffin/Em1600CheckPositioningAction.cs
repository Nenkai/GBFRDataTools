using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600CheckPositioningAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600CheckPositioningAction);

    [JsonPropertyName("frontDirRot_")]
    public float FrontDirRot { get; set; } = 45f; // Offset 0x38

    [JsonPropertyName("checkDist_")]
    public float CheckDist { get; set; } = 15f; // Offset 0x3C

    public Em1600CheckPositioningAction()
    {
    }
}


