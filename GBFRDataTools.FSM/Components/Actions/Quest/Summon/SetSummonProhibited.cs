using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetSummonProhibited : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetSummonProhibited);

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = false;

    public override string GetCaption()
    {
        return Flag ? "Summons prohibited" : "Summons allowed";
    }
}
