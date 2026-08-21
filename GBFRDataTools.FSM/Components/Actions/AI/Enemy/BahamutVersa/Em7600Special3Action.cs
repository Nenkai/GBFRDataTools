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
    public BindingList<Em7600Special3AttackPlace> Places { get; set; } = [];

    [JsonPropertyName("isMultiMode_")]
    public bool IsMultiMode { get; set; } = false;

    [JsonPropertyName("multiEndTime_")]
    public float MultiEndTime { get; set; } = 60f;

    [JsonPropertyName("signTime_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float SignTime { get; set; }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600Special3AttackPlace
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("time_")]
        public float Time { get; set; }
    }
}

