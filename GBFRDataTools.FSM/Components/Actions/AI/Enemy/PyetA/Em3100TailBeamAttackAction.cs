using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.PyetA;

public class Em3100TailBeamAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3100TailBeamAttackAction);

    [JsonPropertyName("isRight_")]
    public bool IsRight { get; set; } = true; // Offset 0x50

    public Em3100TailBeamAttackAction()
    {
    }
}

