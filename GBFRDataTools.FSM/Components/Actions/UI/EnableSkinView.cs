using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class EnableSkinView : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EnableSkinView);

    [JsonPropertyName("enableWeaponSkin_")]
    public bool EnableWeaponSkin { get; set; } = true; // Offset 0x30

    [JsonPropertyName("forceEnableSkinTag_")]
    public bool ForceEnableSkinTag { get; set; } = false; // Offset 0x31

    [JsonPropertyName("finNodeNotDelFlag_")]
    public bool FinNodeNotDelFlag { get; set; } = false; // Offset 0x32

    public EnableSkinView()
    {
    }
}
