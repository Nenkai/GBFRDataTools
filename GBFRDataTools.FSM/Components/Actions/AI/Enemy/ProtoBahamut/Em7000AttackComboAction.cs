using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7000AttackComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000AttackComboAction);

    [JsonPropertyName("firstAnimationInterSec_")]
    public float FirstAnimationInterSec { get; set; } = 1f; // Offset 0x30

    [JsonPropertyName("laterAnimationInterSec_")]
    public float LaterAnimationInterSec { get; set; } = 0.3f; // Offset 0x34

    [JsonPropertyName("sideIndex_")]
    public int SideIndex { get; set; } = 0; // Offset 0x58

    [JsonPropertyName("isMotCancel_")]
    public bool IsMotCancel { get; set; } = true; // Offset 0x5C

    [JsonPropertyName("lockOnListParams_")]
    public BindingList<Em7000LockOnListParam> LockOnListParams { get; set; } = [.. Enumerable.Repeat(new Em7000LockOnListParam(), 3)]; // Offset 0x60

    public Em7000AttackComboAction()
    {
    }
}
