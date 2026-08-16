using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[GameSupport(GameVersion.EndlessRagnarok)]
[Description("""
    Registers a vector4 blackboard variable to the specified value for initialization purposes.
    If called again for an existing value it will not do anything.

    Not currently required to establish a variable, setting it with a regular blackboard action works fine. 
    Establishing a variable in either manner will allow the variable to be called by the entity that called the FSM. 
    
    Ex. Katalina calls and establishes a variable. Tweyen AI will not be able to reference it, but Katalina will be able to reference it in EVERY fsm she calls.
    """)]
public class RegisterBlackBoardVec4Action : RegisterBlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(RegisterBlackBoardVec4Action);

    [JsonPropertyName("value_")]
    public Vector4 Value { get; set; } = Vector4.UnitW;
}
