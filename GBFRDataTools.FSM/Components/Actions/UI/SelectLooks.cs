using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SelectLooks : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SelectLooks);

    [JsonPropertyName("state_")]
    public EnumString<SelectLooksState> State { get; set; } // Offset 0x30

    public override string GetCaption()
    {
        return Utils.GetEnumDescription(State.Index);
    }

    public SelectLooks()
    {
    }
}

public enum SelectLooksState
{
    Gran = 0,
    Djeeta = 1,
}
