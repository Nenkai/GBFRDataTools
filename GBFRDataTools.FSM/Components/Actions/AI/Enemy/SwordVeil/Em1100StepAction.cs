using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class Em1100StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1100StepAction);

    [JsonPropertyName("originDirType_")]
    public int OriginDirType { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("isCancel_")]
    public bool IsCancel { get; set; } = false; // Offset 0x38

    public Em1100StepAction()
    {
    }
}
