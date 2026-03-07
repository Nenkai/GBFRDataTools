using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
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

[Description("""
    Vrazarek Firewyrm will flash red, before performing a spin, whipping the area with his tail. 
    Spawns magma around him, based on the interval specified with "CreateMagmaIntervalTime".
    """)]
public class Em1801TailAttackAction : Em1800TailAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801TailAttackAction);

    [JsonPropertyName("createMagmaIntervalTime_")]
    public float CreateMagmaIntervalTime { get; set; } = 0.5f; // Offset 0x4C

    public Em1801TailAttackAction()
    {
    }
}
