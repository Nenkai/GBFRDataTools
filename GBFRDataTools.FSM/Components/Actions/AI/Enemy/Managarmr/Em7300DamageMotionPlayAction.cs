using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300DamageMotionPlayAction : EmDamageMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DamageMotionPlayAction);

    [JsonPropertyName("animIdPower_")]
    public string AnimIdPower { get; set; } = "b000";
}
