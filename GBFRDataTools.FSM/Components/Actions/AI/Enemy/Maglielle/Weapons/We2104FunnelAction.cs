using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2104FunnelAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2104FunnelAction);

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 50f; // Offset 0x155C

    [JsonPropertyName("aimSec_")]
    public float AimSec { get; set; } = 1.5f; // Offset 0x1560

    [JsonPropertyName("partsAttackIntervalSec_")]
    public float PartsAttackIntervalSec { get; set; } = 1f; // Offset 0x1564

    [JsonPropertyName("addHeight_")]
    public float AddHeight { get; set; } = 0.01f; // Offset 0x1568

    [JsonPropertyName("waitAttackSec_")]
    public float WaitAttackSec { get; set; } = 1f; // Offset 0x156C

    [JsonPropertyName("waitEndSec_")]
    public float WaitEndSec { get; set; } = 1f; // Offset 0x1570

    [JsonPropertyName("maxDirX_")]
    public float MaxDirX { get; set; } = 25f; // Offset 0x1574

    [JsonPropertyName("maxDirY_")]
    public float MaxDirY { get; set; } = 15f; // Offset 0x1578

    public We2104FunnelAction()
    {
    }
}
