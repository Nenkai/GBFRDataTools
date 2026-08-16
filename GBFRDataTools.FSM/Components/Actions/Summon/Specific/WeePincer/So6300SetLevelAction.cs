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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.WeePincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So6300SetLevelAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So6300SetLevelAction);

    [JsonPropertyName("setIndex_")]
    public int SetIndex { get; set; } = 0;

    [JsonPropertyName("levelParams_")]
    public BindingList<LevelParam> LevelParams { get; set; } = []; // std::vector<BT::So6300SetLevelAction::LevelParam>

    public class LevelParam /* So6300SetLevelAction::LevelParam */
    {
        [JsonPropertyName("level_")]
        public int Level { get; set; }
    
        [JsonPropertyName("collectCount_")]
        public int CollectCount { get; set; }
    }
}