using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class CheckDemoVersion : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckDemoVersion);

    [JsonPropertyName("demoVersionEnum_")]
    public EnumString<DemoVersionEnumType> DemoVersionEnum { get; set; } = new();

    public enum DemoVersionEnumType
    {

    }
}
