using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100ComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100ComboAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 2f; 

    [JsonPropertyName("comboInfo_")]
    public BindingList<ComboInfo> ComboInfo_ { get; set; } = []; 

    [JsonPropertyName("baseWeaponState_")]
    public int BaseWeaponState { get; set; } = 0; 

    [JsonPropertyName("isAddComboContinueDist_")]
    public bool IsAddComboContinueDist { get; set; } = false; 

    public class ComboInfo
    {
        [JsonPropertyName("motionName_")]
        public string? MotionName { get; set; } 

        [JsonPropertyName("moveDist_")]
        public float MoveDist { get; set; } 

        [JsonPropertyName("attackDist_")]
        public float AttackDist { get; set; } 
    }
}