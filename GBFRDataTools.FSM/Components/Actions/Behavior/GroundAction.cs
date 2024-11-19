using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class GroundAction : ShotHitBaseAction
{
    [JsonPropertyName("startOffset_")]
    public cVec4 StartOffset { get; set; }

    [JsonPropertyName("endOffset_")]
    public cVec4 EndOffset { get; set; }

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; }

    [JsonPropertyName("hitTypeIndex_")]
    public int HitTypeIndex { get; set; }

    [JsonPropertyName("isCheckStart_")]
    public bool IsCheckStart { get; set; }

    [JsonPropertyName("isUpdatePartsMatrix_")]
    public bool IsUpdatePartsMatrix { get; set; }
}
