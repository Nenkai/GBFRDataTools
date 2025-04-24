using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100CounterAction);

    [JsonPropertyName("motionIdNameParley_")]
    public string MotionIdNameParley { get; set; } // Offset 0x38

    [JsonPropertyName("motionIdNameAttack_")]
    public string MotionIdNameAttack { get; set; } // Offset 0x40

    public Em0100CounterAction()
    {
    }
}
