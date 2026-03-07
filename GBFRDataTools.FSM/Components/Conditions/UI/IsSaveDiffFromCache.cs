using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsSaveDiffFromCache : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSaveDiffFromCache);

    [JsonPropertyName("mode_")]
    public EnumString<IsSaveDiffFromCacheMode> Mode { get; set; } // Offset 0x38

    public IsSaveDiffFromCache()
    {
    }
}

public enum IsSaveDiffFromCacheMode
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    OptionAll = 3,
    RequestReload = 4,
}
