using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetFilterSortType : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetFilterSortType);

    [JsonPropertyName("type_")]
    public EnumString<SetFilterSortTypeEnum> Type { get; set; } // Offset 0x30

    public SetFilterSortType()
    {
    }
}

public enum SetFilterSortTypeEnum
{
    ChallengeMission = 4,
}
