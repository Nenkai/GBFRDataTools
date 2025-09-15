using GBFRDataTools.FSM.Components.Actions.Battle;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

[Description("Vrazarek Firewyrm will activate BloodThirst before jumping up into the air and hovering above the battlefield.")]
public class Em1801MeteorAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MeteorAction);

    [JsonPropertyName("waitStartTime_")]
    public float WaitStartTime { get; set; } = 3f; // Offset 0x14A8

    [Description("If pools of lava are currently on the field, will cause them to explode using this interval for the entire duration of the action.")]
    [JsonPropertyName("activateMagmaTime_")]
    public float ActivateMagmaTime { get; set; } = 1f; // Offset 0x14AC

    public Em1801MeteorAction()
    {
    }
}
