using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.DroitaMother;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So3100ElectricFieldAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So3100ElectricFieldAction);

    [JsonPropertyName("fieldLevelInfo_")]
    public BindingList<FieldLevelInfo_> FieldLevelInfo { get; set; } = [..Enumerable.Repeat(new FieldLevelInfo_(), 6)]; // std::array<BT::So3100ElectricFieldAction::FieldLevelInfo,6>>

    [JsonPropertyName("blackBoardLevelKey_")]
    public string BlackBoardLevelKey { get; set; }

    [JsonPropertyName("blackBoardPhaseKey_")]
    public string BlackBoardPhaseKey { get; set; }

    [JsonPropertyName("seLoopEventName_")]
    public string SeLoopEventName { get; set; }

    [JsonPropertyName("seStopEventName_")]
    public string SeStopEventName { get; set; }

    [JsonPropertyName("seLv1EventName_")]
    public string SeLv1EventName { get; set; }

    [JsonPropertyName("seLv2EventName_")]
    public string SeLv2EventName { get; set; }

    [JsonPropertyName("seLv3EventName_")]
    public string SeLv3EventName { get; set; }

    [JsonPropertyName("seLv4EventName_")]
    public string SeLv4EventName { get; set; }

    [JsonPropertyName("seLv5EventName_")]
    public string SeLv5EventName { get; set; }

    [JsonPropertyName("seLv6EventName_")]
    public string SeLv6EventName { get; set; }

    [JsonPropertyName("seControlName_")]
    public string SeControlName { get; set; }

    public class FieldLevelInfo_ /* So3100ElectricFieldAction::FieldLevelInfo */
    {
        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; }
    
        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; }
    
        [JsonPropertyName("spArtsRate_")]
        public float SpArtsRate { get; set; }
    
        [JsonPropertyName("attackDelaySec_")]
        public float AttackDelaySec { get; set; }
    
        [JsonPropertyName("attackIntervalSec_")]
        public float AttackIntervalSec { get; set; }
    
        [JsonPropertyName("bufferingSec_")]
        public float BufferingSec { get; set; }
    
        [JsonPropertyName("waitingSec_")]
        public float WaitingSec { get; set; }
    
        [JsonPropertyName("attackAfterSec_")]
        public float AttackAfterSec { get; set; }
    
        [JsonPropertyName("attackRadius_")]
        public float AttackRadius { get; set; }
    
        [JsonPropertyName("multiAttackNum_")]
        public int MultiAttackNum { get; set; }
    }
}
