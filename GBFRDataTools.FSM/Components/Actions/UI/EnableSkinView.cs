using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class EnableSkinView : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EnableSkinView);

    [JsonPropertyName("enableWeaponSkin_")]
    public bool EnableWeaponSkin { get; set; } = true;

    [JsonPropertyName("forceEnableSkinTag_")]
    public bool ForceEnableSkinTag { get; set; } = false;

    [JsonPropertyName("enableWeaponEffectOff_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool EnableWeaponEffectOff { get; set; } = false;

    [JsonPropertyName("finNodeNotDelFlag_")]
    public bool FinNodeNotDelFlag { get; set; } = false;
}
