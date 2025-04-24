using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmJumpAction : BehaviorJumpAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmJumpAction);

    [JsonPropertyName("isDisbleCollisionActionStart_")]
    public bool IsDisbleCollisionActionStart { get; set; } = false; // Offset 0xC0

    [JsonPropertyName("isDisbleLockOnActionStart_")]
    public bool IsDisbleLockOnActionStart { get; set; } = false; // Offset 0xC1

    [JsonPropertyName("isDisbleDamageActionStart_")]
    public bool IsDisbleDamageActionStart { get; set; } = false; // Offset 0xC2

    [JsonPropertyName("isDisbleObjHitActionStart_")]
    public bool IsDisbleObjHitActionStart { get; set; } = false; // Offset 0xC3

    [JsonPropertyName("isEnableAppearInvincibleActionStart_")]
    public bool IsEnableAppearInvincibleActionStart { get; set; } = false; // Offset 0xC4

    [JsonPropertyName("isEnableCollisionAfterLand_")]
    public bool IsEnableCollisionAfterLand { get; set; } = false; // Offset 0xC5

    [JsonPropertyName("isEnableLockOnAfterLand_")]
    public bool IsEnableLockOnAfterLand { get; set; } = false; // Offset 0xC6

    [JsonPropertyName("isEnableDamageAfterLand_")]
    public bool IsEnableDamageAfterLand { get; set; } = false; // Offset 0xC7

    [JsonPropertyName("isEnableObjHitAfterLand_")]
    public bool IsEnableObjHitAfterLand { get; set; } = false; // Offset 0xC8

    [JsonPropertyName("isDisableAppearInvincibleActionStart_")]
    public bool IsDisableAppearInvincibleActionStart { get; set; } = false; // Offset 0xC9

    public EmJumpAction()
    {
    }
}
