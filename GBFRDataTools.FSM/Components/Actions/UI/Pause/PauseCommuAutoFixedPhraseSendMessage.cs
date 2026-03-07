using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseCommuAutoFixedPhraseSendMessage : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseCommuAutoFixedPhraseSendMessage);

    [Description("Seems to follow CORE_AUTOTALK_TEXT strings")]
    [JsonPropertyName("modeEnum_")]
    public EnumString<PauseCommuAutoFixedPhraseSendMessageEnum> ModeEnum { get; set; } // Offset 0x30

    public PauseCommuAutoFixedPhraseSendMessage()
    {
    }
}

public enum PauseCommuAutoFixedPhraseSendMessageEnum
{
    QuestReady = 0,
    QuestRequest = 1,
    Type2 = 2,
    QuestDeparture = 3,
    Type4 = 4,
    Type5= 5,
    Type6 = 6,
    Type7 = 7,
    Type8 = 8,
    Type9 = 9,
    Type10 = 10,
    Type11 = 11,
    Type12 = 12,
    Type13 = 13,
    Type14 = 14,
    Type15 = 15,
    Type16 = 16,
    Type17 = 17,
    Type18 = 18,
    Type19 = 19,
}