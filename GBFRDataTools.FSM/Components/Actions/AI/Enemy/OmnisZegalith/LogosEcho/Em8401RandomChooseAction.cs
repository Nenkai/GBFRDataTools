using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401RandomChooseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401RandomChooseAction);

    [JsonPropertyName("actionParams_")]
    public BindingList<RandomActionParam> ActionParams { get; set; } = []; // std::vector<BT::Em8401RandomChooseAction::RandomActionParam>

    [JsonPropertyName("layer_")]
    public int Layer { get; set; } = 0;

    public class RandomActionParam /* Em8401RandomChooseAction::RandomActionParam */
    {
        [JsonPropertyName("id_")]
        public int Id { get; set; }
    
        [JsonPropertyName("intervalSec_")]
        public float IntervalSec { get; set; }
    }
}
