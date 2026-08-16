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

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetCharacterSpoiler : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetCharacterSpoiler);

    [JsonPropertyName("enableFlag_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool EnableFlag { get; set; } = false;

    [JsonPropertyName("characterID_")]
    [eObjId]
    public uint CharacterID { get; set; } = 0;
}
