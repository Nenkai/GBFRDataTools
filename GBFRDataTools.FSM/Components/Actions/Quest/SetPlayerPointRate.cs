using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetPlayerPointRate : QuestActionComponent
{
    [JsonPropertyName("whichGauge_")]
    public int WhichGauge { get; set; }

    [JsonPropertyName("rate_")]
    public float Rate { get; set; }

    [JsonPropertyName("playerIndex_")]
    public int PlayerIndex { get; set; }

    [JsonPropertyName("isNoCrisisEffect_")]
    public bool IsNoCrisisEffect { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";

        return str;
    }
}
