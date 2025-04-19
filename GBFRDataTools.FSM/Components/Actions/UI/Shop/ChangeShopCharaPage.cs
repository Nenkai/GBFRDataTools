using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ChangeShopCharaPage : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeShopCharaPage);

    [JsonPropertyName("mode_")]
    public EnumString<ChangeShopCharaPageType> Mode { get; set; } // Offset 0x30

    public ChangeShopCharaPage()
    {
    }
}

public enum ChangeShopCharaPageType
{
    Status = 0,
    Skill = 1,
    Command = 2,
    Weapon = 3,
}