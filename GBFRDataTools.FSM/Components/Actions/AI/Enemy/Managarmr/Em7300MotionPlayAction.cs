using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300MotionPlayAction : MotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300MotionPlayAction);

    [JsonPropertyName("motionIdNamePower_")]
    public /* sys::String */ string MotionIdNamePower { get; set; } = "b000";
}
