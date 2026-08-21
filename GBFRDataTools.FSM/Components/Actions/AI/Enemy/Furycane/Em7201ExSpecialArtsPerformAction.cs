using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201ExSpecialArtsPerformAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExSpecialArtsPerformAction);

    [JsonPropertyName("em7201Rot_")]
    public float Em7201Rot { get; set; } = 0f; 

    [JsonPropertyName("em7211Rot_")]
    public float Em7211Rot { get; set; } = 0f;

    [JsonPropertyName("startMotionId_")]
    public string? StartMotionId { get; set; } = "1a51";

    [JsonPropertyName("endMotionId_")]
    public string? EndMotionId { get; set; } = "1a52";

    [JsonPropertyName("showArtsText_")]
    public bool ShowArtsText { get; set; } = false; 

    [JsonPropertyName("playerSetPositions_")]
    public BindingList<PlayerSetPosInfo> PlayerSetPositions { get; set; } = []; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlayerSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 
    }
}
