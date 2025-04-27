using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class MoveSubPhase : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MoveSubPhase);

    [JsonPropertyName("subPhaseName_")]
    public string SubPhaseName { get; set; } // Offset 0x48

    public MoveSubPhase()
    {
    }
}
