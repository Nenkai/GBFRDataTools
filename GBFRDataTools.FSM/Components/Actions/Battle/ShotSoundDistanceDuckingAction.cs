using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShotSoundDistanceDuckingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotSoundDistanceDuckingAction);

    [JsonPropertyName("rtpcName_")]
    [Obsolete("Not exposed by the game.")]
    public string RTPCName { get; set; }

    [JsonPropertyName("defaultRtpcValue_")]
    [Obsolete("Not exposed by the game.")]
    public float DefaultRTPCValue { get; set; }

    [JsonPropertyName("duckingRange_")]
    [Obsolete("Not exposed by the game.")]
    public float DuckingRange { get; set; }

}

