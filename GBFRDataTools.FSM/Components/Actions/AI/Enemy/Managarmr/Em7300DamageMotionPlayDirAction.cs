using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300DamageMotionPlayDirAction : EmDamageMotionPlayDirAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DamageMotionPlayDirAction);

    [JsonPropertyName("animIdPowerList_")]
    public BindingList<string> AnimIdPowerList { get; set; } = ["b510", "b511", "b512", "b513"];
}
