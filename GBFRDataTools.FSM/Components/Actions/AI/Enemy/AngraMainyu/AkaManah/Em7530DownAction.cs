using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530DownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530DownAction);

    [JsonPropertyName("fallTime_")]
    public float FallTime { get; set; } = 2f; // Offset 0x68

    [JsonPropertyName("isLightPillerDown_")]
    public bool IsLightPillerDown { get; set; } = false; // Offset 0x6C

    public Em7530DownAction()
    {
    }
}