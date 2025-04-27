using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520DownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520DownAction);

    [JsonPropertyName("fallTime_")]
    public float FallTime { get; set; } = 2f; // Offset 0x68

    [JsonPropertyName("isLightPillerDown_")]
    public bool IsLightPillerDown { get; set; } = false; // Offset 0x6C

    public Em7520DownAction()
    {
    }
}
