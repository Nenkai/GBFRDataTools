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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005BaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005BaseAction);

    [JsonPropertyName("isComboBefore_")]
    public bool IsComboBefore { get; set; } = false; // Offset 0x30

    [JsonPropertyName("isComboAfter_")]
    public bool IsComboAfter { get; set; } = false; // Offset 0x31

    [JsonPropertyName("isComboAfterNoHitAttack_")]
    public bool IsComboAfterNoHitAttack { get; set; } = false; // Offset 0x32

    public Em0005BaseAction()
    {
    }
}

