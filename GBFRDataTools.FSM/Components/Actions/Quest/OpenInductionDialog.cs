using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class OpenInductionDialog : QuestActionComponent
{
    [JsonPropertyName("dialogType_")]
    public InductionDialogType DialogType { get; set; } = 0;

    public enum InductionDialogType
    {
        DLG_STG_BDY_SQ_GUIDE_TO_FRAUX1 = 0,
        DLG_STG_BDY_SQ_GUIDE_TO_FEDIEL1 = 1,
        DLG_STG_KKTN_GUIDE_TO_BACKALLEY = 2,
    }
}
