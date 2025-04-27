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

public class Em7600OverAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600OverAttackAction);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 3; // Offset 0x3C

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 3f; // Offset 0x44

    [JsonPropertyName("startFrame_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float StartFrame { get; set; }

    [JsonPropertyName("moveFrame_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float MoveFrame { get; set; }

    [JsonPropertyName("places_")]
    public BindingList<Em7600OverAttackActionAttackPlace> Places { get; set; } = []; // Offset 0x58

    public Em7600OverAttackAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600OverAttackActionAttackPlace
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; } // Offset 0x20

        [JsonPropertyName("time_")]
        public float Time { get; set; } // Offset 0x30
    }
}

