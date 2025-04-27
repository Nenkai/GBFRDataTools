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

public class Em7200ComboAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200ComboAction);

    [JsonPropertyName("combos_")]
    public BindingList<Combo> Combos { get; set; } = []; // Offset 0x508

    [JsonPropertyName("isCancelLastCombo_")]
    public bool IsCancelLastCombo { get; set; } = false; // Offset 0x500

    public Em7200ComboAction()
    {
    }

    public class Combo
    {
        [JsonPropertyName("comboActivateAiLevel_")]
        public int ComboActivateAiLevel { get; set; } // Offset 0x8

        [JsonPropertyName("needParts_")]
        public int NeedParts { get; set; } // Offset 0xC

        [JsonPropertyName("animInterTime_")]
        public float AnimInterTime { get; set; } // Offset 0x10

        [JsonPropertyName("animStartTime_")]
        public float AnimStartTime { get; set; } // Offset 0x14

        [JsonPropertyName("homingRate_")]
        public float HomingRate { get; set; } // Offset 0x18

        [JsonPropertyName("continueAngle_")]
        public float ContinueAngle { get; set; } // Offset 0x1C

        [JsonPropertyName("continueAngleOffset_")]
        public float ContinueAngleOffset { get; set; } // Offset 0x20

        [JsonPropertyName("continueMinDistance_")]
        public float ContinueMinDistance { get; set; } // Offset 0x24

        [JsonPropertyName("continueMaxDistance_")]
        public float ContinueMaxDistance { get; set; } // Offset 0x28

        [JsonPropertyName("motionId_")]
        public string MotionId { get; set; } // Offset 0x30

        public Combo()
        {
        }
    }
}




