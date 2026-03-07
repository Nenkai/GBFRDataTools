using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520StompAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520StompAction);

    [JsonPropertyName("stopTime_")]
    public float StopTime { get; set; } = 2f; // Offset 0x140

    [JsonPropertyName("attackSpeed_")]
    public float AttackSpeed { get; set; } = 10f; // Offset 0x144

    [JsonPropertyName("attackPreSpeed_")]
    public float AttackPreSpeed { get; set; } = 10f; // Offset 0x148

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 3f; // Offset 0x14C

    public Em7520StompAction()
    {
    }
}