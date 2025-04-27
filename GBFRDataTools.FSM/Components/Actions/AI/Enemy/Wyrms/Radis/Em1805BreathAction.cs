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

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805BreathAction : Em1800ClawAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805BreathAction);

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = [];

    public Em1805BreathAction()
    {
    }

    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector3 Offset { get; set; }

        [JsonPropertyName("rot_")]
        public float SetAngle { get; set; }

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; }

        [JsonPropertyName("waitTracesSecond_")]
        public float WaitTracesSecond { get; set; }
    }
}

