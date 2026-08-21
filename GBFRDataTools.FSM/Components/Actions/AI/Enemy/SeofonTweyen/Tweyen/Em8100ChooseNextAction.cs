using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100ChooseNextAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100ChooseNextAction);

    [JsonPropertyName("actionDistanceList_")]
    [Editable(false)]
    public BindingList<float> ActionDistanceList { get; set; } = [.. Enumerable.Repeat(0.0f, 3)]; // std::array<float,3>

    [JsonPropertyName("actionParameterList_")]
    [Editable(false)]
    public BindingList<BindingList<ActionParameter>> ActionParameterList { get; set; } = [.. Enumerable.Repeat(new BindingList<ActionParameter>(), 3)]; // std::array<std::vector<BT::Em8100ChooseNextAction::ActionParameter>, 3>

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ActionParameter /* Em8100ChooseNextAction::ActionParameter */
    {
        [JsonPropertyName("actionId_")]
        public int ActionId { get; set; }
    
        [JsonPropertyName("usePercent_")]
        public int UsePercent { get; set; }
    
        [JsonPropertyName("priority_")]
        public int Priority { get; set; }
    
        [JsonPropertyName("isNormalModeOnly_")]
        public bool IsNormalModeOnly { get; set; }
    
        [JsonPropertyName("isPowerUpModeOnly_")]
        public bool IsPowerUpModeOnly { get; set; }
    
        [JsonPropertyName("isOverDriveModeOnly_")]
        public bool IsOverDriveModeOnly { get; set; }
    }
}