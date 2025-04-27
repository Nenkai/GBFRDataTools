using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801MeteorAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MeteorAction);

    [JsonPropertyName("waitStartTime_")]
    public float WaitStartTime { get; set; } = 3f; // Offset 0x14A8

    [JsonPropertyName("activateMagmaTime_")]
    public float ActivateMagmaTime { get; set; } = 1f; // Offset 0x14AC

    public Em1801MeteorAction()
    {
    }
}
