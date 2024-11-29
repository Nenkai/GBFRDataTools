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

public class SetUIGuideHideAction : QuestActionComponent
{
    [JsonPropertyName("hudGuideType_")]
    public uint HudGuideType { get; set; } = 0;

    [JsonPropertyName("hideFlag_")]
    public bool HideFlag { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}(hudGuideType: {HudGuideType}, hideFlag: {HideFlag})";

        return str;
    }
}
