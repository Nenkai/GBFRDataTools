using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Lyria;

public class Np0000BahamutMotionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Np0000BahamutMotionAction);

    [JsonPropertyName("playerCharacterOffsetPosition01_")]
    public /* cVec4 */ Vector4 PlayerCharacterOffsetPosition01 { get; set; } = Vector4.Zero;

    [JsonPropertyName("playerCharacterOffsetPosition02_")]
    public /* cVec4 */ Vector4 PlayerCharacterOffsetPosition02 { get; set; } = Vector4.Zero;

    [JsonPropertyName("playerCharacterOffsetPosition03_")]
    public /* cVec4 */ Vector4 PlayerCharacterOffsetPosition03 { get; set; } = Vector4.Zero;

    [JsonPropertyName("playerCharacterOffsetPosition04_")]
    public /* cVec4 */ Vector4 PlayerCharacterOffsetPosition04 { get; set; } = Vector4.Zero;
}
