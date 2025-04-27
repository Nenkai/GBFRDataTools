using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7000SpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000SpecialArtsAction);

    [JsonPropertyName("animationInterSec_")]
    public float AnimationInterSec { get; set; } = 1f; // Offset 0x34

    [JsonPropertyName("sideIndex_")]
    public int SideIndex { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("finishEffectPos_")]
    public Vector4 FinishEffectPos { get; set; } = new Vector4(-5.7f, 3.5f, 51f, 1f); // Offset 0x40

    public Em7000SpecialArtsAction()
    {
    }
}
