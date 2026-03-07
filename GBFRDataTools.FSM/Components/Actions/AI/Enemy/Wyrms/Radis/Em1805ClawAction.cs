using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805ClawAction : Em1800ClawAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805ClawAction);

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = [];

    public Em1805ClawAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("setRadius_")]
        public float SetRadius { get; set; }

        [JsonPropertyName("setAngle_")]
        public float SetAngle { get; set; }

        [JsonPropertyName("userCustomType_")]
        public int UserCustomType { get; set; }
    }
}

