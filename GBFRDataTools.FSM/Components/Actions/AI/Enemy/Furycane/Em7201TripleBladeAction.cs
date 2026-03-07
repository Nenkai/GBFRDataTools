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

public class Em7201TripleBladeAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201TripleBladeAction);

    [JsonPropertyName("strongWindType_")]
    public int StrongWindType { get; set; } = 0; // Offset 0x4C0

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x4C8

    [JsonPropertyName("shotSpd_")]
    public float ShotSpd { get; set; } = 12f; // Offset 0x4D0

    [JsonPropertyName("shotLifeTime_")]
    public float ShotLifeTime { get; set; } = 20f; // Offset 0x4D4

    [JsonPropertyName("shotOffset_")]
    public Vector4 ShotOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x4E0

    public Em7201TripleBladeAction()
    {
    }
}





