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
    public float Em7201Rot { get; set; } = 0f; // Offset 0x7C

    [JsonPropertyName("em7211Rot_")]
    public float Em7211Rot { get; set; } = 0f; // Offset 0x80

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x38

    [JsonPropertyName("endMotionId_")]
    public string EndMotionId { get; set; } // Offset 0x58

    [JsonPropertyName("showArtsText_")]
    public bool ShowArtsText { get; set; } = false; // Offset 0x78

    [JsonPropertyName("playerSetPositions_")]
    public BindingList<PlayerSetPosInfo> PlayerSetPositions { get; set; } = []; // Offset 0x88

    public Em7201ExSpecialArtsPerformAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlayerSetPosInfo
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        public PlayerSetPosInfo()
        {
        }
    }
}
