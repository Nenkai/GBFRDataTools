using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class CheckPlatform : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckPlatform);

    [JsonPropertyName("platformEnum_")]
    public EnumString<PlatformEnum> PlatformEnum { get; set; } // Offset 0x38

    public CheckPlatform()
    {
    }
}

public enum PlatformEnum
{
    Windows = 0,
    PlayStation = 1,
    Steam = 2,
}
