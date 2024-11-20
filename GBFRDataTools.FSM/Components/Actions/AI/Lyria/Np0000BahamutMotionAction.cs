using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Lyria;

public class Np0000BahamutMotionAction : ActionComponent
{
    [JsonPropertyName("playerCharacterOffsetPosition01_")]
    public cVec4 PlayerCharacterOffsetPosition01 { get; set; }

    [JsonPropertyName("playerCharacterOffsetPosition02_")]
    public cVec4 PlayerCharacterOffsetPosition02 { get; set; }

    [JsonPropertyName("playerCharacterOffsetPosition03_")]
    public cVec4 PlayerCharacterOffsetPosition03 { get; set; }

    [JsonPropertyName("playerCharacterOffsetPosition04_")]
    public cVec4 PlayerCharacterOffsetPosition04 { get; set; }
}
