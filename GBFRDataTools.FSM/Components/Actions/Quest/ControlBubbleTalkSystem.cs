using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ControlBubbleTalkSystem : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlBubbleTalkSystem);

    [JsonPropertyName("systemEnable_")]
    public bool SystemEnable { get; set; } = true;

    public override string GetCaption()
    {
        return $"Enable: {SystemEnable}";
    }
}
