using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600ComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600ComboAction);

    [JsonPropertyName("em7600Combos_")]
    public BindingList<Em7600Combo> Em7600Combos { get; set; } = []; // Offset 0x30

    public Em7600ComboAction()
    {
    }

    public class Em7600Combo
    {
        [JsonPropertyName("startFrame_")]
        public int StartFrame { get; set; } // Offset 0x8

        [JsonPropertyName("endFrame_")]
        public int EndFrame { get; set; } // Offset 0xC

        [JsonPropertyName("homingRate_")]
        public float HomingRate { get; set; } // Offset 0x10

        [JsonPropertyName("interTime_")]
        public float InterTime { get; set; } // Offset 0x14

        [JsonPropertyName("motSpeed_")]
        public float MotSpeed { get; set; } // Offset 0x18

        [JsonPropertyName("motionId_")]
        public string MotionId { get; set; } // Offset 0x20

        public Em7600Combo()
        {
        }
    }
}
