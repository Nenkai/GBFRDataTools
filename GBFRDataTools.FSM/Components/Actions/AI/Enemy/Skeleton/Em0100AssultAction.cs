using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100AssultAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100AssultAction);

    [JsonPropertyName("toTargetTimeOutSec_")]
    public float ToTargetTimeOutSec { get; set; } = 5f; // Offset 0x70

    [JsonPropertyName("attackTimeOutSec_")]
    public float AttackTimeOutSec { get; set; } = 3f; // Offset 0x74

    public Em0100AssultAction()
    {
    }
}
