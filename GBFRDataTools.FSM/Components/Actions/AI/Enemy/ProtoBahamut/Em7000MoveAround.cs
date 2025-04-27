using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7000MoveAround : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000MoveAround);

    [JsonPropertyName("moveAroundAnimationInterSec_")]
    public float MoveAroundAnimationInterSec { get; set; } = 1f; // Offset 0x34

    [JsonPropertyName("sideIndex_")]
    public int SideIndex { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("lockOnListParam_")]
    public Em7000LockOnListParam LockOnListParams { get; set; } = new(); // Offset 0x40

    public Em7000MoveAround()
    {
    }
}
