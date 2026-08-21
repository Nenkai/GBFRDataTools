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
    public BindingList<Em7600Combo> Em7600Combos { get; set; } = []; 

    public Em7600ComboAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600Combo
    {
        [JsonPropertyName("startFrame_")]
        public int StartFrame { get; set; }

        [JsonPropertyName("endFrame_")]
        public int EndFrame { get; set; }

        [JsonPropertyName("homingRate_")]
        public float HomingRate { get; set; }

        [JsonPropertyName("interTime_")]
        public float InterTime { get; set; }

        [JsonPropertyName("motSpeed_")]
        public float MotSpeed { get; set; }

        [JsonPropertyName("motionId_")]
        public string? MotionId { get; set; }
    }
}
