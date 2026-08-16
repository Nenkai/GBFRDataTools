using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class PlayerMasterSkillStatusCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerMasterSkillStatusCondition);

    [JsonPropertyName("masterSkillStatusInfo_")]
    public BindingList<MasterSkillStatusInfo_> MasterSkillStatusInfo { get; set; } = [];

    [JsonPropertyName("isSuccessAny_")]
    public bool IsSuccessAny { get; set; } = true;

    public class MasterSkillStatusInfo_ /* PlayerMasterSkillStatusCondition::MasterSkillStatusInfo */
    {
        [JsonPropertyName("flagType_")]
        public int FlagType { get; set; } // Offset 0x8
    
        [JsonPropertyName("isEnable_")]
        public bool IsEnable { get; set; } // Offset 0xC
    
        public MasterSkillStatusInfo_()
        {

        }
    }

}