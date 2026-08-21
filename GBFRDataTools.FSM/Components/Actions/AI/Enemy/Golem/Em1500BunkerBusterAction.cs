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
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 3f; 

    [JsonPropertyName("showFallPointHight_")]
    public float ShowFallPointHight { get; set; } = 5f; 

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0.35f; 

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 5f; 

    [JsonPropertyName("isCancelAction_")]
    public bool IsCancelAction { get; set; } = true; 
}