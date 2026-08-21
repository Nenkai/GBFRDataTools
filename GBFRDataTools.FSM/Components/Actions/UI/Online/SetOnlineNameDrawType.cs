using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class SetOnlineNameDrawType : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetOnlineNameDrawType);

    [JsonPropertyName("type_")]
    public EnumString<SetOnlineNameDrawTypeEnum> Type { get; set; } = new();

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; 
}

public enum SetOnlineNameDrawTypeEnum
{
    // プレイヤー名 = 0,
    PlayerName = 0,
}
