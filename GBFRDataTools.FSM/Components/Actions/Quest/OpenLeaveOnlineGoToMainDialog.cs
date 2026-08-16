using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class OpenLeaveOnlineGoToMainDialog : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenLeaveOnlineGoToMainDialog);

    [JsonPropertyName("dialogType_")]
    public LeaveOnlineGoToMainDialog DialogType { get; set; } = 0;

    public enum LeaveOnlineGoToMainDialog
    {
        DLG_4E41B02C_9FBC9B7F = 0,
        DLG_5E2C2716_9FBC9B7F = 1,
        DLG_E29D75B0_91E85E55 = 2,
    }
}
