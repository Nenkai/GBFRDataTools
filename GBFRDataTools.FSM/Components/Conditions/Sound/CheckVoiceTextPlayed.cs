using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Sound;

public class CheckVoiceTextPlayed : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckVoiceTextPlayed);

    [JsonPropertyName("sceneID_")]
    public string SceneID { get; set; } = string.Empty;
}