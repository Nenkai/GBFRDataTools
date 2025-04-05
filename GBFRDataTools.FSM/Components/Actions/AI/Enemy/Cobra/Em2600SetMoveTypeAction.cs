using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Cobra;

public class Em2600SetMoveTypeAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600SetMoveTypeAction);

    [JsonPropertyName("setMoveType_")]
    public ModeType SetMoveType { get; set; } = ModeType.Type0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}
