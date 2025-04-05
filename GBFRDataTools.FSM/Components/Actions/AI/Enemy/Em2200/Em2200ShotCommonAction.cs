using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Em2200;

public class Em2200ShotCommonAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2200ShotCommonAction);

    [JsonPropertyName("shotType_")]
    [Description("Valid: 1, 5, 6, 7, 8, 9, 11, 13, 14, 15, 16, 17, 19")]
    public ShotType ShotType { get; set; } = 0;
}
