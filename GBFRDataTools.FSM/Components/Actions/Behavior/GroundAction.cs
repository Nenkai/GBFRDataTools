using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class GroundAction : ShotHitBaseAction
{
    [JsonPropertyName("startOffset_")]
    public /* cVec4 */ Vector4 StartOffset { get; set; } = new Vector4(0.0f, 1.0f, 0.0f, 1.0f);

    [JsonPropertyName("endOffset_")]
    public /* cVec4 */ Vector4 EndOffset { get; set; } = new Vector4(0.0f, -1.0f, 0.0f, 1.0f);

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; } = -1;

    [JsonPropertyName("hitTypeIndex_")]
    public int HitTypeIndex { get; set; } = 0;
    
    [JsonPropertyName("isCheckStart_")]
    public bool IsCheckStart { get; set; } = true;

    [JsonPropertyName("isUpdatePartsMatrix_")]
    public bool IsUpdatePartsMatrix { get; set; } = false;
}
