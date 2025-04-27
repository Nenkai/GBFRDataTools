using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803JumpBreathAction : Em1800JumpBreathAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803JumpBreathAction);

    [JsonPropertyName("firstOffsetPos_")]
    public Vector4 FirstOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x50

    [JsonPropertyName("firstOffsetRotY_")]
    public float FirstOffsetRotY { get; set; } = 0f; // Offset 0x60

    [JsonPropertyName("secondOffsetPos_")]
    public Vector4 SecondOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x70

    [JsonPropertyName("secondOffsetRotY_")]
    public float SecondOffsetRotY { get; set; } = 0f; // Offset 0x80

    [JsonPropertyName("thirdOffsetPos_")]
    public Vector4 ThirdOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x90

    [JsonPropertyName("thirdOffsetRotY_")]
    public float ThirdOffsetRotY { get; set; } = 0f; // Offset 0xA0

    public Em1803JumpBreathAction()
    {
    }
}
