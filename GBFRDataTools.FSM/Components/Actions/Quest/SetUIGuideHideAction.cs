using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetUIGuideHideAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetUIGuideHideAction);

    [JsonPropertyName("hudGuideType_")]
    public uint HudGuideType { get; set; } = 0;

    [JsonPropertyName("hideFlag_")]
    public bool HideFlag { get; set; } = false;

    public override string GetCaption()
    {
        return $"Type: {HudGuideType} - Hide: {HideFlag}";
    }
}
