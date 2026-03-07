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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600Special3Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600Special3Action);

    [JsonPropertyName("places_")]
    public BindingList<Em7600Special3AttackPlace> Places { get; set; } = []; // Offset 0x38

    [JsonPropertyName("isMultiMode_")]
    public bool IsMultiMode { get; set; } = false; // Offset 0x64

    [JsonPropertyName("multiEndTime_")]
    public float MultiEndTime { get; set; } = 60f; // Offset 0x5C

    [JsonPropertyName("signTime_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float SignTime { get; set; }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600Special3AttackPlace
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; } // Offset 0x20

        [JsonPropertyName("time_")]
        public float Time { get; set; } // Offset 0x30

        public Em7600Special3AttackPlace()
        {
        }
    }
}

