using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001CoreSetEnableBattleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001CoreSetEnableBattleAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("enableBattle_")]
    public bool EnableBattle { get; set; } = false; // Offset 0x34

    public Em7001CoreSetEnableBattleAction()
    {
    }
}
