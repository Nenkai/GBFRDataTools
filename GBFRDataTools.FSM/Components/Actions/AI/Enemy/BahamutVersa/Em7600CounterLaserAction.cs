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

public class Em7600CounterLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600CounterLaserAction);

    [JsonPropertyName("places_")]
    public BindingList<Em7600OLaserPlace> Places { get; set; } = []; // Offset 0x50

    [JsonPropertyName("time_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float Time { get; set; } // Offset 0x10

    public Em7600CounterLaserAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600OLaserPlace
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; } // Offset 0x20

        public Em7600OLaserPlace()
        {
        }
    }

}


