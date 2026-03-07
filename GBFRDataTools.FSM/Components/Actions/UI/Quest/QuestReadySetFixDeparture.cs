using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class QuestReadySetFixDeparture : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestReadySetFixDeparture);

    [JsonPropertyName("isFix_")]
    public bool IsFix { get; set; } = false; // Offset 0x30
}

