using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class DialogInfomationByID : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogInfomationByID);

    [JsonPropertyName("informationIDString_")]
    public string InformationIDString { get; set; }

    [JsonPropertyName("openSeOff_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool OpenSeOff { get; set; } = false;
}