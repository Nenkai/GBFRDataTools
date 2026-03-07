using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805DischargeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805DischargeAction);

    [JsonPropertyName("createOffset_")]
    public Vector4 CreateOffset { get; set; } = new Vector4(3f, 0f, -7f, 1f); // Offset 0x80

    [JsonPropertyName("omenRadius_")]
    public float OmenRadius { get; set; } = 13f; // Offset 0x90

    [JsonPropertyName("nextThunderArea_")]
    public int NextThunderArea { get; set; } = 2; // Offset 0x94

    [JsonPropertyName("nextThunderAreaSub_")]
    public int NextThunderAreaSub { get; set; } = 3; // Offset 0x98

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = []; // Offset 0xA0

    public Em1805DischargeAction()
    {
    }

    public class Param
    {
        [JsonPropertyName("setRadius_")]
        public float SetRadius { get; set; } // Offset 0x8

        [JsonPropertyName("setAngle_")]
        public float SetAngle { get; set; } // Offset 0xC
    }
}