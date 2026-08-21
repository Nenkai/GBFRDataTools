using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class EmAhrimanComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanComboAction);

    [JsonPropertyName("param0_")]
    public Param Param0 { get; set; } = new();

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } = new();

    [JsonPropertyName("param2_")]
    public Param Param2 { get; set; } = new();

    public class Param
    {
        [JsonPropertyName("motionName_")]
        public string? MotionName { get; set; } 

        [JsonPropertyName("cancelSecond_")]
        public float CancelSecond { get; set; } 

        [JsonPropertyName("animSpeedRate_")]
        public float AnimSpeedRate { get; set; } 

        [JsonPropertyName("interpSecond_")]
        public float InterpSecond { get; set; } 

        [JsonPropertyName("moveRate_")]
        public Vector4 MoveRate { get; set; } 

        [JsonPropertyName("moveOffset_")]
        public Vector4 MoveOffset { get; set; } 

    }
}
