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
    public float HomingAngle { get; set; } = 2f; // Offset 0x58

    [JsonPropertyName("comboInfo_")]
    public BindingList<ComboInfo> ComboInfo_ { get; set; } = []; // Offset 0x60

    [JsonPropertyName("baseWeaponState_")]
    public int BaseWeaponState { get; set; } = 0; // Offset 0x78

    [JsonPropertyName("isAddComboContinueDist_")]
    public bool IsAddComboContinueDist { get; set; } = false; // Offset 0x7C

    public Em2100ComboAction()
    {
    }

    public class ComboInfo
    {
        [JsonPropertyName("motionName_")]
        public string MotionName { get; set; } // Offset 0x8

        [JsonPropertyName("moveDist_")]
        public float MoveDist { get; set; } // Offset 0x28

        [JsonPropertyName("attackDist_")]
        public float AttackDist { get; set; } // Offset 0x2C

        public ComboInfo()
        {
        }
    }
}