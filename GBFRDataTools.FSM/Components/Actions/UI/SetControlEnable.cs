using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetControlEnable : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetControlEnable);

    [JsonPropertyName("viewControllerPairs_")]
    public BindingList<ViewControllerPair> ViewControllerPairs { get; set; } // Offset 0x30 - std::vector<ui::fsm::action::SetControlEnable::ViewControllerPair>

    [JsonPropertyName("enableControl_")]
    public bool EnableControl { get; set; } = true; // Offset 0x60

    public SetControlEnable()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ViewControllerPair
    {
        [JsonPropertyName("view_")]
        public string View { get; set; } // cyan::inplace_string<64>

        [JsonPropertyName("controllers_")]
        public BindingList<string> Controllers { get; set; } = []; // std::vector<cyan::inplace_string<64>>
    }
}
