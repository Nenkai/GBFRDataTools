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

public class Em1805JudgmentThunderAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805JudgmentThunderAction);

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = []; // Offset 0xA0

    [JsonPropertyName("seedActionWait_")]
    public float SeedActionWait { get; set; } = 0f; // Offset 0xB8

    public Em1805JudgmentThunderAction()
    {
    }

    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector3 Offset { get; set; } // Offset 0x8

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; } // Offset 0x14

        [JsonPropertyName("waitLatterHalfSecond_")]
        public float WaitLatterHalfSecond { get; set; } // Offset 0x18
    }
}

