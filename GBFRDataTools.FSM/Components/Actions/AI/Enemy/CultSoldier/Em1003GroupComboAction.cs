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
    public float TurnRate { get; set; } = 0.3f; // Offset 0x34

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; // Offset 0x38

    [JsonPropertyName("attackDist_")]
    public float AttackDist { get; set; } = 3f; // Offset 0x3C

    [JsonPropertyName("guideRed_")]
    public float GuideRed { get; set; } = 255f; // Offset 0x40

    [JsonPropertyName("guideAlphaFront_")]
    public float GuideAlphaFront { get; set; } = 80f; // Offset 0x44

    [JsonPropertyName("guideAlphaBack_")]
    public float GuideAlphaBack { get; set; } = 20f; // Offset 0x48

    [JsonPropertyName("guideWidth_")]
    public float GuideWidth { get; set; } = 2f; // Offset 0x4C

    [JsonPropertyName("attackMoveSpeed_")]
    public float AttackMoveSpeed { get; set; } = 40f; // Offset 0x50

    [JsonPropertyName("attackEndHeight_")]
    public float AttackEndHeight { get; set; } = 3f; // Offset 0x58

    public Em1003GroupComboAction()
    {
    }
}