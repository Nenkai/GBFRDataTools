using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Quest;

public class QuestReadyIsMeetStartRequirements : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestReadyIsMeetStartRequirements);

    [JsonPropertyName("mode_")]
    public EnumString<QuestReadyIsMeetStartRequirementsMode> Mode { get; set; } // Offset 0x38

    public QuestReadyIsMeetStartRequirements()
    {
    }
}

public enum QuestReadyIsMeetStartRequirementsMode
{
    OK = 0,
    NG = 1,
}