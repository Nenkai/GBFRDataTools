using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900RushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900RushAction);

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 30f; // Offset 0x6C

    public Em1900RushAction()
    {
    }
}



