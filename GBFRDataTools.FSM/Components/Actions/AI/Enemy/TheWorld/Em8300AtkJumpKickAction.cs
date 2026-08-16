using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkJumpKickAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkJumpKickAction);

    [JsonPropertyName("isComboAttack_")]
    public bool IsComboAttack { get; set; } = false;

    [JsonPropertyName("isInhaleAttack_")]
    public bool IsInhaleAttack { get; set; } = false;

    [JsonPropertyName("isGroundDimension_")]
    public bool IsGroundDimension { get; set; } = false;

    [JsonPropertyName("groundDimensionNum_")]
    public int GroundDimensionNum { get; set; } = 6;

    [JsonPropertyName("groundDimensionSetRadius_")]
    public float GroundDimensionSetRadius { get; set; } = 20f;
}