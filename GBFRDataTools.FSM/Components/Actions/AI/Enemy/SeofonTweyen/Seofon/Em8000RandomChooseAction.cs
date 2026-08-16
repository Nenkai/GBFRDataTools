using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000RandomChooseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000RandomChooseAction);

    [JsonPropertyName("actionParams_")]
    public BindingList<RandomActionParam> ActionParams { get; set; } = []; // std::vector<BT::Em8000RandomChooseAction::RandomActionParam>

    [JsonPropertyName("isCombinationSpArtsDpsCheck_")]
    public bool IsCombinationSpArtsDpsCheck { get; set; } = false;

    public class RandomActionParam /* Em8000RandomChooseAction::RandomActionParam */
    {
        [JsonPropertyName("id_")]
        public int Id { get; set; }
    
        [JsonPropertyName("intervalSec_")]
        public float IntervalSec { get; set; }
    
        [JsonPropertyName("ratio_")]
        public int Ratio { get; set; }
    
        [JsonPropertyName("isNoUseBigWedgeOnly_")]
        public bool IsNoUseBigWedgeOnly { get; set; }
    
        [JsonPropertyName("combinationSpArtsDpsTimer_")]
        public float CombinationSpArtsDpsTimer { get; set; }
    }
}