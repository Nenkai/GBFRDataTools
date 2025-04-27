using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SupernovaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SupernovaAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x7C

    [JsonPropertyName("isEnableInhole_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public bool IsEnableInhole { get; set; } = false;

    public Em7001SupernovaAction()
    {
    }
}
