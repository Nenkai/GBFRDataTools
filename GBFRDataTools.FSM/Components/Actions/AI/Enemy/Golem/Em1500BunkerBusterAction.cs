using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500BunkerBusterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BunkerBusterAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x34

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 3f; // Offset 0x38

    [JsonPropertyName("showFallPointHight_")]
    public float ShowFallPointHight { get; set; } = 5f; // Offset 0x3C

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0.35f; // Offset 0x40

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 5f; // Offset 0x44

    [JsonPropertyName("isCancelAction_")]
    public bool IsCancelAction { get; set; } = true; // Offset 0x48

    public Em1500BunkerBusterAction()
    {
    }
}