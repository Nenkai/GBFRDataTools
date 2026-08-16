using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class SetIsPauseMenuTop : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetIsPauseMenuTop);

    [JsonPropertyName("startOnly_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool StartOnly { get; set; } = false;
}
