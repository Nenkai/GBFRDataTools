using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallTutorialAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallTutorialAction);

    [JsonPropertyName("tutorialType_")]
    public TutorialActionType TutorialType { get; set; } = TutorialActionType.TUTORIAL_ABILITY;
}

/// <summary>
/// From a list of hashes
/// </summary>
// 
public enum TutorialActionType
{
    TUTORIAL_ABILITY, // 41D7B47E
    TUTORIAL_TRADE,   // 1FB7FFEB
    TUTORIAL_WEP_STR, // 57FC1EB3
    TUTORIAL_MENU_FORMATION, // E0E60CA8
    TUTORIAL_MENU_EQUIP,     // E3B9C06C
    TUTORIAL_SIDE_QUEST,     // FC9453CD
    TUTORIAL_QUEST_COUNTER,  // EB00833F
    TUTORIAL_WP_LIMITBREAK,  // 8509BC8B
    TUTORIAL_GEEN_STR,       // BBAC6DDC
    TUTORIAL_MENU_ENHANCE,   // BFC48F84
}
