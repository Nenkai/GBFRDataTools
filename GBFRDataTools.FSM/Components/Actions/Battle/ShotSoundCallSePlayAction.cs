using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotSoundCallSePlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotSoundCallSePlayAction);

    [JsonPropertyName("defineName_")]
    public string DefineName { get; set; } = string.Empty;

    [JsonPropertyName("isImmediate_")]
    public bool IsImmediate { get; set; } = false;

    public override string GetCaption()
    {
        return DefineName;
    }
}
