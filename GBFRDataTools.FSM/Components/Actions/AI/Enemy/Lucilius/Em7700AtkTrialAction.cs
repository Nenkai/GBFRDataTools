using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkTrialAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkTrialAction);

    [JsonPropertyName("startWaitShotTime_")]
    public float StartWaitShotTime { get; set; } = 0.01f; // Offset 0xA8

    [JsonPropertyName("shotTime_")]
    public float ShotTime { get; set; } = 999999f; // Offset 0xAC

    [JsonPropertyName("oneShotWait_")]
    public float OneShotWait { get; set; } = 0.1f; // Offset 0xB0

    public Em7700AtkTrialAction()
    {
    }
}


