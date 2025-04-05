using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallSkipStageProductionSe : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallSkipStageProductionSe);

    [JsonPropertyName("fadeType_")]
    public CallSkipStageProductionSeFadeType FadeType { get; set; } = CallSkipStageProductionSeFadeType.Type0;
}

public enum CallSkipStageProductionSeFadeType : uint
{
    Type0 = 0,
    Type1 = 1,
}
