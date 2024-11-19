using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmCameraAlphaAction : EmDamageMotionPlayDirAction
{
    [JsonPropertyName("isIgnore_")]
    public bool IsIgnore { get; set; }

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; }

    [JsonPropertyName("applyToChildRecursively_")]
    public bool ApplyToChildRecursively { get; set; }
}
