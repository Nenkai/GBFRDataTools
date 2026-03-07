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

public class Em1805TailAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805TailAction);

    [JsonPropertyName("paramThunder_")]
    public BindingList<Param> ParamThunder { get; set; } = []; // Offset 0x78

    public Em1805TailAction()
    {
    }

    public class Param
    {
        [JsonPropertyName("setRadius_")]
        public float SetRadius { get; set; } // Offset 0x8

        [JsonPropertyName("setAngle_")]
        public float SetAngle { get; set; } // Offset 0xC

        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; } // Offset 0x10

        [JsonPropertyName("userCustomType_")]
        public int UserCustomType { get; set; } // Offset 0x14
    }
}
