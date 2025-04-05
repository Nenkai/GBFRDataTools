using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ToggleQuestLight : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ToggleQuestLight);

    [JsonPropertyName("isOn_")]
    public bool IsOn { get; set; } = false;

    [JsonPropertyName("lightType_")]
    public int LightType { get; set; } = 0;
}
