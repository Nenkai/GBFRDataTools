using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

public class SetNeedMaterialMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetNeedMaterialMode);

    [JsonPropertyName("shop_")]
    public EnumString<SetNeedMaterialModeShop> Shop { get; set; } = new();

    [JsonPropertyName("mode_")]
    public EnumString<SetNeedMaterialModeEnum> Mode { get; set; } = new();
}

public enum SetNeedMaterialModeShop
{
    // 武器の上限解放 = 0,
    // ジーン強化 = 1,

    WeaponLimitRelease = 0,
    GeenEnhancement = 1,
}

public enum SetNeedMaterialModeEnum
{
    // トレジャー = 0,
    Treasure = 0,
}