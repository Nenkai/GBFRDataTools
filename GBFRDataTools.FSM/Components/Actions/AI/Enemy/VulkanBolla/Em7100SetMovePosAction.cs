using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.VulkanBolla;

public class Em7100SetMovePosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100SetMovePosAction);

    [JsonPropertyName("destPos_")]
    public Vector4 DestPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("destDegreeY_")]
    public float DestDegreeY { get; set; } = 0f; 

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0; 

    [JsonPropertyName("addIndex_")]
    public int AddIndex { get; set; } = 0; 

    [JsonPropertyName("addIndexRandomMin_")]
    public int AddIndexRandomMin { get; set; } = 0; 

    [JsonPropertyName("addIndexRandomMax_")]
    public int AddIndexRandomMax { get; set; } = 0; 
}
