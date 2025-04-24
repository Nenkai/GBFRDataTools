using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class EmCultSoldierBaseApproachAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCultSoldierBaseApproachAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; // Offset 0x50

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; // Offset 0x54

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x30

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x40

    public EmCultSoldierBaseApproachAction()
    {
    }
}