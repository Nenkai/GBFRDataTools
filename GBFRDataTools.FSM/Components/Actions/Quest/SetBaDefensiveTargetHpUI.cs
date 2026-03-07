using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetBaDefensiveTargetHpUI : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBaDefensiveTargetHpUI);

    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = true; // Offset 0x48

    public SetBaDefensiveTargetHpUI()
    {
    }
}
