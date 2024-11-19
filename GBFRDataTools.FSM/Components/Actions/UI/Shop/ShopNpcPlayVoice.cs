using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Shop;

public class ShopNpcPlayVoice : ActionComponent
{
    [JsonPropertyName("voiceType_")]
    public EnumString VoiceType { get; set; }
}
