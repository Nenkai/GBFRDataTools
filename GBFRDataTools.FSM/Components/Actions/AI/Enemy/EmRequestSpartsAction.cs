using GBFRDataTools.FSM.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmRequestSpartsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmRequestSpartsAction);

    [JsonPropertyName("isIgnoreCoolTime_")]
    public bool IsIgnoreCoolTime { get; set; } = false; // Offset 0x30

    public EmRequestSpartsAction()
    {
    }
}
