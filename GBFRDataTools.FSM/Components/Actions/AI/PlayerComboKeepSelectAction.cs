using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.NavMesh;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

[GameSupport(GameVersion.EndlessRagnarok)]
public class PlayerComboKeepSelectAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerComboKeepSelectAction);

    [JsonPropertyName("comboKeepInfo_")]
    public BindingList<ComboKeepInfo_> ComboKeepInfo { get; set; } = []; // std::vector<BT::PlayerComboKeepSelectAction::ComboKeepInfo>

    public class ComboKeepInfo_ /* PlayerComboKeepSelectAction::ComboKeepInfo */
    {
        [JsonPropertyName("actionId_")]
        public int ActionId { get; set; }
    
        [JsonPropertyName("comboNum_")]
        public int ComboNum { get; set; }
    }
}
