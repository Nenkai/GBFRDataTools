using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class EmCultSoldierBaseComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCultSoldierBaseComboAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; // Offset 0x40

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; // Offset 0x44

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x30

    [JsonPropertyName("permissionNoHitProbability_")]
    public int PermissionNoHitProbability { get; set; } = 0; // Offset 0x48

    [JsonPropertyName("permissionNoHitDist_")]
    public float PermissionNoHitDist { get; set; } = 0f; // Offset 0x4C

    [JsonPropertyName("permissionNoHitAngleDeg_")]
    public float PermissionNoHitAngleDeg { get; set; } = 190f; // Offset 0x50

    [JsonPropertyName("startMotionTime_")]
    public float StartMotionTime { get; set; } = 0f; // Offset 0x5C

    [JsonPropertyName("movementRateOnFlag_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public int MovementRateOnFlag { get; set; }

    public EmCultSoldierBaseComboAction()
    {
    }
}