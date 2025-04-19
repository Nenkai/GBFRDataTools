using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Cutscene;

public class SetCutFlowState : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetCutFlowState);

    [JsonPropertyName("state_")]
    public EnumString<SetCutFlowStateType> State { get; set; } // Offset 0x30
}

public enum SetCutFlowStateType
{
    Main = 1,
    SubFlow = 2,
    Choice = 3,
}