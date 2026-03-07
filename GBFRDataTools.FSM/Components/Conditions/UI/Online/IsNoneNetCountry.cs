using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class IsNoneNetCountry : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsNoneNetCountry);

    [JsonPropertyName("countryCheckType_")]
    public EnumString<IsNoneNetCountryCheckType> CountryCheckType { get; set; } // Offset 0x38

    public IsNoneNetCountry()
    {
    }
}

public enum IsNoneNetCountryCheckType
{
    // オプションの自国設定 = 0
    // 選択中の自国設定 = 1
    OptionalHomeCountrySetting = 0,
    CurrentHomeCountrySetting = 1,
}