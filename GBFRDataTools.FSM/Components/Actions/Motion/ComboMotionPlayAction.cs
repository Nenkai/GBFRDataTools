using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Motion;

public class ComboMotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ComboMotionPlayAction);

    [JsonPropertyName("param0_")]
    public Param Param0 { get; set; } // Offset 0x30

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } // Offset 0x50

    [JsonPropertyName("param2_")]
    public Param Param2 { get; set; } // Offset 0x70

    [JsonPropertyName("param3_")]
    public Param Param3 { get; set; } // Offset 0x90

    public ComboMotionPlayAction()
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

        public Param()
        {
        }
    }
}

