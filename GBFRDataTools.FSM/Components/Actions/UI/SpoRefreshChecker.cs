using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SpoRefreshChecker : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SpoRefreshChecker);

    [JsonPropertyName("modeEnum_")]
    public EnumString<SpoRefreshCheckerMode> ModeEnum { get; set; } // Offset 0x30

    [JsonPropertyName("checkSelectQuestDelete_")]
    public bool CheckSelectQuestDelete { get; set; } = false; // Offset 0x63

    [JsonPropertyName("checkMyQuestDelete_")]
    public bool CheckMyQuestDelete { get; set; } = false; // Offset 0x60

    [JsonPropertyName("checkPtQuestDelete_")]
    public bool CheckPtQuestDelete { get; set; } = false; // Offset 0x61

    [JsonPropertyName("checkQuestChenge_")]
    public bool CheckQuestChenge { get; set; } = false; // Offset 0x62
}

public enum SpoRefreshCheckerMode
{
    WmapQuestTop = 1,
    WmapQuestList = 2,
    QdetlQuestDetail = 3,
    QreqRequestList = 4,
    QacptQuestAccept = 5,
    QCdiscdDiscardDialog = 6,
    GmSessionMattingSetting = 7,
    SQdlgGetShuffleQuest = 8,
    WmapQuestTopIslandItem = 9,
    WmapQuestTopDefficultItem = 10,
    WmapQuestTopCategorytItem = 11,
}
