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

public class Em1800ComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800ComboAction);

    [JsonPropertyName("param0_")]
    public Param Param0 { get; set; } = new(); // Offset 0x30

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } = new(); // Offset 0x50

    [JsonPropertyName("param2_")]
    public Param Param2 { get; set; } = new(); // Offset 0x70

    [JsonPropertyName("param3_")]
    public Param Param3 { get; set; } = new(); // Offset 0x90

    public Em1800ComboAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("motionName_")]
        public string MotionName { get; set; } // Offset 0x8

        [JsonPropertyName("startSecond_")]
        public float StartSecond { get; set; } // Offset 0x10

        [JsonPropertyName("interpSecond_")]
        public float InterpSecond { get; set; } // Offset 0x14

        [JsonPropertyName("cancelSecond_")]
        public float CancelSecond { get; set; } // Offset 0x18

        [JsonPropertyName("isBreathControl_")]
        public bool IsBreathControl { get; set; } // Offset 0x1C
    }
}
