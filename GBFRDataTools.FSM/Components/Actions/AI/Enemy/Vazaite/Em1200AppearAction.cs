using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Vazaite;

public class Em1200AppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1200AppearAction);

    [JsonPropertyName("appearParams_")]
    public BindingList<AppearParam> AppearParams { get; set; } = []; // Offset 0x38

    [JsonPropertyName("isEndTerminate_")]
    public bool IsEndTerminate { get; set; } = false; // Offset 0x88

    [JsonPropertyName("isAppearSoldier_")]
    public bool IsAppearSoldier { get; set; } = true; // Offset 0x89

    public Em1200AppearAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AppearParam
    {

        [JsonPropertyName("appearType_")]
        public int AppearType { get; set; } // Offset 0x14

        [JsonPropertyName("waitSec_")]
        public float WaitSec { get; set; } // Offset 0x18

        [JsonPropertyName("jumpSpeedY_")]
        public float JumpSpeedY { get; set; } // Offset 0x1C

        [JsonPropertyName("jumpSpeedZ_")]
        public float JumpSpeedZ { get; set; } // Offset 0x20

        public AppearParam()
        {
        }
    }
}
