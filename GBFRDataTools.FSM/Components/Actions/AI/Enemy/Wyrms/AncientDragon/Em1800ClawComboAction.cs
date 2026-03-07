using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800ClawComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800ClawComboAction);

    [JsonPropertyName("param0_")]
    public Param Param0 { get; set; } = new(); // Offset 0x38

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } = new(); // Offset 0x58

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0; // Offset 0x88

    public Em1800ClawComboAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("startSecond_")]
        public float StartSecond { get; set; } // Offset 0x10

        [JsonPropertyName("interpSecond_")]
        public float InterpSecond { get; set; } // Offset 0x14

        [JsonPropertyName("cancelSecond_")]
        public float CancelSecond { get; set; } // Offset 0x18

        public Param()
        {
        }
    }
}
