using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.EndlessConflux;

[GameSupport(GameVersion.EndlessRagnarok)]
public class IsEndlessResultCitySelect : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsEndlessResultCitySelect);

    [JsonPropertyName("type_")]
    public EnumString<IsEndlessResultCitySelectType> Type { get; set; }

    public enum IsEndlessResultCitySelectType
    {
        Type0 = 0, // [路地裏]に戻る
        Type1 = 1, // [トルダーム宮]に戻る
        Type2 = 2, // [路地裏/街]に戻るかの選択
        Type3 = 3, // トルダーム宮/街]に戻るかの選択
    }
}
