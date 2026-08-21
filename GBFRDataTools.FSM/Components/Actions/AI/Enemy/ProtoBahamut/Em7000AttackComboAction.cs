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

public class Em7000AttackComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000AttackComboAction);

    [JsonPropertyName("firstAnimationInterSec_")]
    public float FirstAnimationInterSec { get; set; } = 1f; 

    [JsonPropertyName("laterAnimationInterSec_")]
    public float LaterAnimationInterSec { get; set; } = 0.3f; 

    [JsonPropertyName("sideIndex_")]
    public int SideIndex { get; set; } = 0; 

    [JsonPropertyName("isMotCancel_")]
    public bool IsMotCancel { get; set; } = true; 

    [JsonPropertyName("lockOnListParams_")]
    [Editable(false)]
    public BindingList<Em7000LockOnListParam> LockOnListParams { get; set; } = [.. Enumerable.Repeat(new Em7000LockOnListParam(), 3)]; 
}
