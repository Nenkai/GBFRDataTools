using GBFRDataTools.Entities.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700CutinBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700CutinBaseAction);

    [JsonPropertyName("isResetCamera_")]
    public bool IsResetCamera { get; set; } = true; 

    [JsonPropertyName("canSkipCutin_")]
    public bool CanSkipCutin { get; set; } = false; 

    [JsonPropertyName("useCutMax_")]
    public int UseCutMax { get; set; } = 1; 

    [JsonPropertyName("motionIdNameList_")]
    public BindingList<string> MotionIdNameList { get; set; } = [];

    [JsonPropertyName("isUseDarkVfx_")]
    public bool IsUseDarkVfx { get; set; } = true;

    [JsonPropertyName("facialIdMap_")]
    public Map<int, string> FacialIdMap { get; set; } = new(); // unordered_map
}