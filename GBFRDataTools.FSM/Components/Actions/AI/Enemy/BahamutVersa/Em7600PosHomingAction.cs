using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600PosHomingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600PosHomingAction);

    // had an hard time determining the defaults for this one, but i think it's correct.

    [JsonPropertyName("em7600PosHomings_")]
    public BindingList<Em7600PosHoming> Em7600PosHomings { get; set; } = [new Em7600PosHoming()];

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600PosHoming // Em7600PosHomingAction::Em7600PosHoming
    {
        [JsonPropertyName("homingSpeed_")]
        public float HomingSpeed { get; set; } = 1.0f;

        [JsonPropertyName("startFrame_")]
        public int StartFrame { get; set; } = 0;

        [JsonPropertyName("endFrame_")]
        public int EndFrame { get; set; } = 0;

        [JsonPropertyName("offsetTargetPos_")]
        public /* cVec4 */ Vector4 OffsetTargetPos { get; set; } = Vector4.Zero; // Is this UnitW? doesn't seem to be

        [JsonPropertyName("useOrigin_")]
        public bool UseOrigin { get; set; } = false;
    }
}


