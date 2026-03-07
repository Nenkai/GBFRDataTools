using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.VulkanBolla;

public class Em7100SetMovePosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100SetMovePosAction);

    [JsonPropertyName("destPos_")]
    public Vector4 DestPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x50

    [JsonPropertyName("destDegreeY_")]
    public float DestDegreeY { get; set; } = 0f; // Offset 0x60

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0; // Offset 0x64

    [JsonPropertyName("addIndex_")]
    public int AddIndex { get; set; } = 0; // Offset 0x68

    [JsonPropertyName("addIndexRandomMin_")]
    public int AddIndexRandomMin { get; set; } = 0; // Offset 0x6C

    [JsonPropertyName("addIndexRandomMax_")]
    public int AddIndexRandomMax { get; set; } = 0; // Offset 0x70

    public Em7100SetMovePosAction()
    {
    }
}
