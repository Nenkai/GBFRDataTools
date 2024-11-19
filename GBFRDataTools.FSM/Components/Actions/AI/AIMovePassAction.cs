using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIMovePassAction : ActionComponent
{
    [JsonPropertyName("params_")]
    public BindingList<PassParam> Params { get; set; }

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; }

    public class PassParam // BT::AIMovePassAction::PassParam
    {
        [JsonPropertyName("pos_")]
        public cVec4 Pos { get; set; }

        [JsonPropertyName("pointNum_")]
        public int PointNum { get; set; }

        [JsonPropertyName("useNavMesh_")]
        public bool UseNavMesh { get; set; }

        [JsonPropertyName("useDash_")]
        public bool UseDash { get; set; }
    }
}
