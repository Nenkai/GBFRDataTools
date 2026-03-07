using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001MotionFlyMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001MotionFlyMoveAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x60

    [JsonPropertyName("dir_")]
    public int Dir { get; set; } = 0; // Offset 0x64

    public Em7001MotionFlyMoveAction()
    {
    }
}
