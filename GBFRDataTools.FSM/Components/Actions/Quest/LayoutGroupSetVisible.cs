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

public class LayoutGroupSetVisible : QuestActionComponent
{
    [JsonPropertyName("groupName_")]
    public string GroupName { get; set; } = string.Empty;

    [JsonPropertyName("isVisible_")]
    public bool IsVisible { get; set; } = true;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
