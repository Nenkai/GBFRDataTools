using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class LayoutGroupSetVisible : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LayoutGroupSetVisible);

    [JsonPropertyName("groupName_")]
    public string GroupName { get; set; } = string.Empty;

    [JsonPropertyName("isVisible_")]
    public bool IsVisible { get; set; } = true;

    public override string GetCaption()
    {
        return $"{GroupName} ({IsVisible})";
    }
}
