using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerAbilityUIParameter
{
    [JsonPropertyName("dataVersion_")]
    public string DataVersion { get; set; }

    [JsonPropertyName("abilityUIInfoList_")]
    public BindingList<AbilityUIInfo> AbilityUIInfoList { get; set; } = [];
}

/// <summary>
/// PlayerAbilityUIParameter::AbilityUIInfo
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class AbilityUIInfo
{
    [JsonPropertyName("abilityTag_")]
    public string AbilityTag { get; set; }

    [JsonPropertyName("statusTypeList_")]
    public BindingList<int> StatusTypeList { get; set; } = [];

    [JsonPropertyName("statusInfoList_")]
    public BindingList<StatusUIInfo> StatusInfoList { get; set; } = [];
}

/// <summary>
/// PlayerAbilityUIParameter::StatusUIInfo
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class StatusUIInfo
{
    [JsonPropertyName("statusType_")]
    public int StatusType { get; set; }

    [JsonPropertyName("parameterType_")]
    public int ParameterType { get; set; }

    [JsonPropertyName("parameter01_")]
    public float Parameter01 { get; set; }

    [JsonPropertyName("parameter02_")]
    public float Parameter02 { get; set; }

    [JsonPropertyName("parameter03_")]
    public float Parameter03 { get; set; }
}
