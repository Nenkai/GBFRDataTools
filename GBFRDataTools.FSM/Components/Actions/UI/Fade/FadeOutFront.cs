using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fade;

[GameSupport(GameVersion.EndlessRagnarok)]
public class FadeOutFront : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FadeOutFront);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0f;

    [JsonPropertyName("colorType_")]
    public EnumString<FadeType> ColorType { get; set; }
}
