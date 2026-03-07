using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300SpArtsAroundAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300SpArtsAroundAction);

    [JsonPropertyName("angleSpeed_")]
    public float AngleSpeed { get; set; } = 90f; // Offset 0x50

    [JsonPropertyName("aroundRadius_")]
    public float AroundRadius { get; set; } = 45f; // Offset 0x54

    [JsonPropertyName("aroundY_")]
    public Vector4 AroundY { get; set; } = new Vector4(5f, 6f, 5f, 4f); // Offset 0x60

    public We7300SpArtsAroundAction()
    {
    }
}
