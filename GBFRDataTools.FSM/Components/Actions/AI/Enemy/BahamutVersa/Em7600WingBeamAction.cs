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

public class Em7600WingBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600WingBeamAction);

    [JsonPropertyName("em7601Places_")]
    public BindingList<Em7601Place> Em7601Places { get; set; } = []; // Offset 0x30

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 18f; // Offset 0x48

    public Em7600WingBeamAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7601Place
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("rot_")]
        [Obsolete("Not used by the game")]
        [Description("Not used by the game")]
        public Vector4 Rot { get; set; } // Offset 0x10

        [JsonPropertyName("isAttack_")]
        public bool IsAttack { get; set; } // Offset 0x20

        public Em7601Place()
        {
        }
    }
}
