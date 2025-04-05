using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetPlayerPointRate : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPlayerPointRate);

    [JsonPropertyName("whichGauge_")]
    public int WhichGauge { get; set; } = 0;

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } = 0;

    [JsonPropertyName("playerIndex_")]
    public int PlayerIndex { get; set; } = 0;

    [JsonPropertyName("isNoCrisisEffect_")]
    public bool IsNoCrisisEffect { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
