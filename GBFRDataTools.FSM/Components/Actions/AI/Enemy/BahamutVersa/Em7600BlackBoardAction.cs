using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600BlackBoardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600BlackBoardAction);

    [JsonPropertyName("actionNo_")]
    public int ActionNo { get; set; } = 0;
}
