using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Save;

public class SetBlacksmithSavePoint : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBlacksmithSavePoint);

    [JsonPropertyName("isSavePoint_")]
    public bool IsSavePoint { get; set; } = false; // Offset 0x30

    public SetBlacksmithSavePoint()
    {
    }
}
