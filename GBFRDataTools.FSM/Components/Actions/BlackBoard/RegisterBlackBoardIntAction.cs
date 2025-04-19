using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[Description("""
    Registers a int blackboard variable to the specified value for initialization purposes.
    If called again for an existing value it will not do anything.

    Not currently required to establish a variable, setting it with a regular blackboard action works fine. 
    Establishing a variable in either manner will allow the variable to be called by the entity that called the FSM. 
    
    Ex. Katalina calls and establishes a variable. Tweyen AI will not be able to reference it, but Katalina will be able to reference it in EVERY fsm she calls.
    """)]
public class RegisterBlackBoardIntAction : RegisterBlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(RegisterBlackBoardIntAction);

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;

    public override string GetCaption()
    {
        return $"{ValueName} = {Value}";
    }
}