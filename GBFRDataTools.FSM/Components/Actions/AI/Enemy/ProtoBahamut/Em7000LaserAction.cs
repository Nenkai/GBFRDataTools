using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7000LaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000LaserAction);

    [JsonPropertyName("animationInterSec_")]
    public float AnimationInterSec { get; set; } = 1f; // Offset 0x44

    [JsonPropertyName("atkRate_")]
    public float AtkRate { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("textShowSec_")]
    public float TextShowSec { get; set; } = -1f; // Offset 0x4C

    [JsonPropertyName("lockOnListParams_")]
    [Editable(false)]
    public BindingList<Em7000LockOnListParam> LockOnListParams { get; set; } = [..Enumerable.Repeat(new Em7000LockOnListParam(), 3)]; // Offset 0x50

    public Em7000LaserAction()
    {
    }
}
