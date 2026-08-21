using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801StraightBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801StraightBreathAction);

    [JsonPropertyName("startOffsetPos_")]
    public Vector3 StartOffsetPos { get; set; } = new Vector3(0f, 0f, 0f); 

    [JsonPropertyName("magmaFieldBetweenLength_")]
    public float MagmaFieldBetweenLength { get; set; } = 0f; 

    [JsonPropertyName("magmaFieldCreateDelay_")]
    public float MagmaFieldCreateDelay { get; set; } = 0f; 

    [JsonPropertyName("magmaFieldCreateAddTime_")]
    public float MagmaFieldCreateAddTime { get; set; } = 0f; 

    [JsonPropertyName("magmaFieldDelayReduction_")]
    public float MagmaFieldDelayReduction { get; set; } = 0f; 

    [JsonPropertyName("upHomingRate_")]
    public float UpHomingRate { get; set; } = 0.1f; 

    [JsonPropertyName("downHomingRate_")]
    public float DownHomingRate { get; set; } = 0.1f; 
}
