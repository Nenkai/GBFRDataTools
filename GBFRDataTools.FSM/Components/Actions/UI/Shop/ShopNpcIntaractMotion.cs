using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopNpcIntaractMotion : ActionComponent
{
    [JsonPropertyName("intaract_")]
    public EnumString Intaract { get; set; }

    [JsonPropertyName("motion_")]
    public EnumString Motion { get; set; }
}
