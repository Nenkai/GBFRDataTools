using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetBlockUser : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBlockUser);

    [JsonPropertyName("isBlock_")]
    public bool IsBlock { get; set; } = false;

    [JsonPropertyName("nameType_")]
    public EnumString<SetBlockUserType> NameType { get; set; } = new();

    public enum SetBlockUserType
    {
        Type0 = 0, // パーティキャラ
        Type1 = 1, // プレイヤーカード
        Type2 = 2, // サポキャラ
    }
}