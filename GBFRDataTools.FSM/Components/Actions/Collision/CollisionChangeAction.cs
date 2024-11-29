using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionChangeAction : ActionComponent
{
    [JsonPropertyName("valueName_")] // refers to lib::HashedStringMap<unsigned int,char>::NodeBase::`vftable'?
    public string ValueName { get; set; } = string.Empty;

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = false;
}
