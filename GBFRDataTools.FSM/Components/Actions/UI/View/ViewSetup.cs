using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

public class ViewSetup : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewSetup);

    [JsonPropertyName("infos_")]
    public BindingList<ViewSetupInfo> Infos { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("skip_")]
    public bool Skip { get; set; } = false;

    public override string GetCaption()
    {
        return string.Join("\n", Infos.Select(e => e.View));
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ViewSetupInfo
    {
        [JsonPropertyName("view_")]
        public string View { get; set; } = string.Empty;

        [JsonPropertyName("layerNo_")]
        public int LayerNo { get; set; } = 0;
    }
}
