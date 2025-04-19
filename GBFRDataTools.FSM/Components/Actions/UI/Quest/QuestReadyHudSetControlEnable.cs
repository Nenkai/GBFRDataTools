using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class QuestReadyHudSetControlEnable : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestReadyHudSetControlEnable);

    [JsonPropertyName("isControlEnable_")]
    public bool IsControlEnable { get; set; } = false; // Offset 0x30

    public QuestReadyHudSetControlEnable()
    {
    }
}