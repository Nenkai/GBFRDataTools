using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

public class AppraiserArchive : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AppraiserArchive);

    [JsonPropertyName("type_")]
    public EnumString<AppraiserArchiveType> Type { get; set; } = new();
}

public enum AppraiserArchiveType
{
    // 通常のアーカイブ入手
    RegularArchiveAcquisition = 0,

    // 最後のアーカイブ入手
    LastArchiveAcquisition = 1,
}
