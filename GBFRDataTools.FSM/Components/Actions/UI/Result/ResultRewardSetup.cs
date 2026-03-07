using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Result;

public class ResultRewardSetup : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultRewardSetup);

    [JsonPropertyName("isClear_")]
    public bool IsClear { get; set; } = false; // Offset 0x30

    public ResultRewardSetup()
    {
    }
}
