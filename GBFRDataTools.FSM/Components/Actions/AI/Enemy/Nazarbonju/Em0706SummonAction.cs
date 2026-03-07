using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706SummonAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706SummonAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x54

    [JsonPropertyName("spawnParams_")]
    public BindingList<SpawnParam> SpawnParams { get; set; } = []; // Offset 0x58

    public Em0706SummonAction()
    {
    }

    public class SpawnParam
    {
        [JsonPropertyName("offsetPos_")]
        public Vector4 OffsetPos { get; set; } // Offset 0x20

        [JsonPropertyName("type_")]
        public int Type { get; set; } // Offset 0x30

        public SpawnParam()
        {
        }
    }
}