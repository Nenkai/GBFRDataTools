using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201ComboAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ComboAction);

    [JsonPropertyName("combos_")]
    public BindingList<Combo> Combos { get; set; } = []; 

    [JsonPropertyName("isCancelLastCombo_")]
    public bool IsCancelLastCombo { get; set; } = false; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Combo
    {
        [JsonPropertyName("comboActivateAiLevel_")]
        public int ComboActivateAiLevel { get; set; } 

        [JsonPropertyName("needParts_")]
        public int NeedParts { get; set; } 

        [JsonPropertyName("animInterTime_")]
        public float AnimInterTime { get; set; } 

        [JsonPropertyName("animStartTime_")]
        public float AnimStartTime { get; set; } 

        [JsonPropertyName("homingRate_")]
        public float HomingRate { get; set; } 

        [JsonPropertyName("continueAngle_")]
        public float ContinueAngle { get; set; } 

        [JsonPropertyName("motionId_")]
        public string? MotionId { get; set; } 
    }
}

