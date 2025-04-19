using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetPlayerSelectScreen : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPlayerSelectScreen);

    [JsonPropertyName("type_")]
    public EnumString<SetPlayerSelectScreenType> Type { get; set; } // Offset 0x30
}

public enum SetPlayerSelectScreenType
{
    Select = 1,
    Name = 2,
    Check = 3,
    CheckCancel = 4,
    Complete = 5,
}
