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
    public Param Param0 { get; set; } = new(); 

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } = new(); 

    [JsonPropertyName("param2_")]
    public Param Param2 { get; set; } = new(); 

    [JsonPropertyName("param3_")]
    public Param Param3 { get; set; } = new(); 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("motionName_")]
        public string? MotionName { get; set; } 

        [JsonPropertyName("startSecond_")]
        public float StartSecond { get; set; } 

        [JsonPropertyName("interpSecond_")]
        public float InterpSecond { get; set; } 

        [JsonPropertyName("cancelSecond_")]
        public float CancelSecond { get; set; } 

        [JsonPropertyName("isBreathControl_")]
        public bool IsBreathControl { get; set; } 
    }
}
