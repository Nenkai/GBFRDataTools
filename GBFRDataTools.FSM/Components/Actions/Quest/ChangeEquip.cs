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

public class ChangeEquip : QuestActionComponent
{
    [JsonPropertyName("specialSettingsHash_")]
    public ulong SpecialSettingsHash { get; set; } = 0;

    [JsonPropertyName("validForChapterSelect_")]
    public bool ValidForChapterSelect { get; set; } = false;
}
