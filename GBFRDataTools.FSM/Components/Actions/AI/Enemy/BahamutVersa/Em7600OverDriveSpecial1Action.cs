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
    public float LoopTime1 { get; set; } = 5f; // Offset 0x3C

    [JsonPropertyName("loopTime2_")]
    public float LoopTime2 { get; set; } = 10f; // Offset 0x40

    [JsonPropertyName("nextLightTime_")]
    public float NextLightTime { get; set; } = 4f; // Offset 0x44

    [JsonPropertyName("signTime_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float SignTime { get; set; }

    [JsonPropertyName("places_")]
    public BindingList<Em7600OverDriveSpecial1Place> Places { get; set; } = []; // Offset 0x48

    [JsonPropertyName("places2_")]
    public BindingList<Em7600OverDriveSpecial1Place> Places2 { get; set; } = []; // Offset 0x78

    [JsonPropertyName("placesMoveLight_")]
    public BindingList<Em7600OverDriveSpecial1Place> PlacesMoveLight { get; set; } = []; // Offset 0x60

    public Em7600OverDriveSpecial1Action()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600OverDriveSpecial1Place
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; } // Offset 0x20

        [JsonPropertyName("time_")]
        public float Time { get; set; } // Offset 0x40

        [JsonPropertyName("effectOffset_")]
        public Vector4 EffectOffset { get; set; } // Offset 0x30

        public Em7600OverDriveSpecial1Place()
        {
        }
    }
}

