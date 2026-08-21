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

public class Em7600OverDriveSpecial1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600OverDriveSpecial1Action);

    [JsonPropertyName("loopTime1_")]
    public float LoopTime1 { get; set; } = 5f;

    [JsonPropertyName("loopTime2_")]
    public float LoopTime2 { get; set; } = 10f;

    [JsonPropertyName("nextLightTime_")]
    public float NextLightTime { get; set; } = 4f;

    [JsonPropertyName("signTime_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float SignTime { get; set; }

    [JsonPropertyName("places_")]
    public BindingList<Em7600OverDriveSpecial1Place> Places { get; set; } = [];

    [JsonPropertyName("places2_")]
    public BindingList<Em7600OverDriveSpecial1Place> Places2 { get; set; } = [];

    [JsonPropertyName("placesMoveLight_")]
    public BindingList<Em7600OverDriveSpecial1Place> PlacesMoveLight { get; set; } = [];

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600OverDriveSpecial1Place
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("time_")]
        public float Time { get; set; }

        [JsonPropertyName("effectOffset_")]
        public Vector4 EffectOffset { get; set; }
    }
}

