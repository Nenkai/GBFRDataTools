using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700CircleThunderAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700CircleThunderAction);

    [JsonPropertyName("isCreateThunder_")]
    public bool IsCreateThunder { get; set; } = false; // Offset 0x64

    [JsonPropertyName("createThunderIntervalTime_")]
    public float CreateThunderIntervalTime { get; set; } = 0.1f; // Offset 0x68

    [JsonPropertyName("createThunderNum_")]
    public int CreateThunderNum { get; set; } = 15; // Offset 0x6C

    [JsonPropertyName("thunderRadius_")]
    public float ThunderRadius { get; set; } = 10f; // Offset 0x70

    [JsonPropertyName("thunderOffsetPos_")]
    public Vector4 ThunderOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x80

    [JsonPropertyName("thunderRandomLength_")]
    public float ThunderRandomLength { get; set; } = 5f; // Offset 0x74

    [JsonPropertyName("thunderScale_")]
    public float ThunderScale { get; set; } = 1f; // Offset 0x90

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0; // Offset 0x98

    public Em1700CircleThunderAction()
    {
    }
}
