using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmBossCutinBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmGroupEscapeAction);

    [JsonPropertyName("isResetCamera_")]
    public bool IsResetCamera { get; set; } = true;

    [JsonPropertyName("canSkipCutin_")]
    public bool CanSkipCutin { get; set; } = false;

    [JsonPropertyName("useCutMax_")]
    public int UseCutMax { get; set; } = 1;

    [JsonPropertyName("motionIdNameList_")]
    public BindingList<string> MotionIdNameList { get; set; } = []; // std::vector<std::basic_string>

    [JsonPropertyName("isUseDarkVfx_")]
    public bool IsUseDarkVfx { get; set; } = true;

    [JsonPropertyName("facialIdMap_")]
    public string[] FacialIdMap { get; set; } // TODO: std::unordered_map<int, string>
}
