using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetBattleKeepState : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBattleKeepState);

    [JsonPropertyName("isBattleKeep_")]
    public bool IsBattleKeep { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}(state: {IsBattleKeep})";
        return str;
    }
}
