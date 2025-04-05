using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallFinishSlowStartSound : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallFinishSlowStartSound);

    [JsonPropertyName("seType_")]
    public CallFinishSlowSeType SeType { get; set; } = CallFinishSlowSeType.Type0;
}

public enum CallFinishSlowSeType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
}
