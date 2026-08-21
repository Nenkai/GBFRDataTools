using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;
using GBFRDataTools.FSM.Components.Actions.Behavior;

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
    public bool IsDisbleCollisionActionStart { get; set; } = false; 

    [JsonPropertyName("isDisbleLockOnActionStart_")]
    public bool IsDisbleLockOnActionStart { get; set; } = false; 

    [JsonPropertyName("isDisbleDamageActionStart_")]
    public bool IsDisbleDamageActionStart { get; set; } = false; 

    [JsonPropertyName("isDisbleObjHitActionStart_")]
    public bool IsDisbleObjHitActionStart { get; set; } = false; 

    [JsonPropertyName("isEnableAppearInvincibleActionStart_")]
    public bool IsEnableAppearInvincibleActionStart { get; set; } = false; 

    [JsonPropertyName("isEnableCollisionAfterLand_")]
    public bool IsEnableCollisionAfterLand { get; set; } = false; 

    [JsonPropertyName("isEnableLockOnAfterLand_")]
    public bool IsEnableLockOnAfterLand { get; set; } = false; 

    [JsonPropertyName("isEnableDamageAfterLand_")]
    public bool IsEnableDamageAfterLand { get; set; } = false; 

    [JsonPropertyName("isEnableObjHitAfterLand_")]
    public bool IsEnableObjHitAfterLand { get; set; } = false; 

    [JsonPropertyName("isDisableAppearInvincibleActionStart_")]
    public bool IsDisableAppearInvincibleActionStart { get; set; } = false; 
}
