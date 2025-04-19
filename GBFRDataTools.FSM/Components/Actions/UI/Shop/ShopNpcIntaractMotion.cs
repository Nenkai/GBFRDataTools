using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopNpcIntaractMotion : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShopNpcIntaractMotion);

    [JsonPropertyName("intaract_")]
    public EnumString<ShopNpcIntaractMotionInteractType> Intaract { get; set; } = new();

    [JsonPropertyName("motion_")]
    public EnumString<ShopNpcIntaractMotionMotionType> Motion { get; set; } = new();
}

public enum ShopNpcIntaractMotionInteractType
{
    // 待機 = 1,
    Type0 = 0,
    Wait = 1,
    Type2 = 2,
}

public enum ShopNpcIntaractMotionMotionType
{
    None = 0,
    // Guessed based on code
    c113 = 1,
    c153 = 2,
    e040 = 3,
    e040_2 = 4,
    Type5 = 5,
    // End of guessed based on code
    Wait2 = 6,
}