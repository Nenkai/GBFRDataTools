using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Motion;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ComboMotionPlayAction : ComboMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ComboMotionPlayAction);

    [JsonPropertyName("movementParam0_")]
    public MovementParam MovementParam0 { get; set; } = new(); // Offset 0xD8

    [JsonPropertyName("movementParam1_")]
    public MovementParam MovementParam1 { get; set; } = new(); // Offset 0x100

    [JsonPropertyName("movementParam2_")]
    public MovementParam MovementParam2 { get; set; } = new(); // Offset 0x128

    [JsonPropertyName("movementParam3_")]
    public MovementParam MovementParam3 { get; set; } = new(); // Offset 0x150

    public Em1700ComboMotionPlayAction()
    {
    }

    public class MovementParam
    {
        [JsonPropertyName("isChangeMovement_")]
        public bool IsChangeMovement { get; set; } // Offset 0x8

        [JsonPropertyName("normalDist_")]
        public float NormalDist { get; set; } // Offset 0xC

        [JsonPropertyName("minDist_")]
        public float MinDist { get; set; } // Offset 0x10

        [JsonPropertyName("maxDist_")]
        public float MaxDist { get; set; } // Offset 0x14

        [JsonPropertyName("offsetDist_")]
        public float OffsetDist { get; set; } // Offset 0x18

        [JsonPropertyName("setTime_")]
        public float SetTime { get; set; } // Offset 0x1C

        [JsonPropertyName("movementRate_")]
        public float MovementRate { get; set; } // Offset 0x20
    }
}
