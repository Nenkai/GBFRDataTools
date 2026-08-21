using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1003GroupComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1003GroupComboAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; 

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; 

    [JsonPropertyName("attackDist_")]
    public float AttackDist { get; set; } = 3f; 

    [JsonPropertyName("guideRed_")]
    public float GuideRed { get; set; } = 255f; 

    [JsonPropertyName("guideAlphaFront_")]
    public float GuideAlphaFront { get; set; } = 80f; 

    [JsonPropertyName("guideAlphaBack_")]
    public float GuideAlphaBack { get; set; } = 20f; 

    [JsonPropertyName("guideWidth_")]
    public float GuideWidth { get; set; } = 2f; 

    [JsonPropertyName("attackMoveSpeed_")]
    public float AttackMoveSpeed { get; set; } = 40f; 

    [JsonPropertyName("attackEndHeight_")]
    public float AttackEndHeight { get; set; } = 3f; 
}