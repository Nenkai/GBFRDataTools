using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class RegisterBlackBoardBoolAction : RegisterBlackBoardAction
{
    [JsonPropertyName("value_")]
    public bool Value { get; set; }
}