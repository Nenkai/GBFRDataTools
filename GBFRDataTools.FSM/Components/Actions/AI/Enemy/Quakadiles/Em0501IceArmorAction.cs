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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0501IceArmorAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0501IceArmorAction);

    [JsonPropertyName("absorbLoopSeconds_")]
    public float AbsorbLoopSeconds { get; set; } = 1.5f; // Offset 0x74

    [JsonPropertyName("stabLoopSeconds_")]
    public float StabLoopSeconds { get; set; } = 3.5f; // Offset 0x78

    [JsonPropertyName("isGayser_")]
    public bool IsGayser { get; set; } = false; // Offset 0x7C

    [JsonPropertyName("setArmorHead_")]
    [Editable(false)]
    public BindingList<bool> SetArmorHead { get; set; } = [.. Enumerable.Repeat(false, 4)];// Offset 0x7D

    [JsonPropertyName("setArmorBody_")]
    [Editable(false)]
    public BindingList<bool> SetArmorBody { get; set; } = [.. Enumerable.Repeat(false, 4)]; // Offset 0x81

    [JsonPropertyName("setArmorArmR_")]
    [Editable(false)]
    public BindingList<bool> SetArmorArmR { get; set; } = [.. Enumerable.Repeat(false, 4)]; // Offset 0x85

    [JsonPropertyName("setArmorArmL_")]
    [Editable(false)]
    public BindingList<bool> SetArmorArmL { get; set; } = [.. Enumerable.Repeat(false, 4)]; // Offset 0x89

    [JsonPropertyName("setArmorTail_")]
    [Editable(false)]
    public BindingList<bool> SetArmorTail { get; set; } = [.. Enumerable.Repeat(false, 4)]; // Offset 0x8D

    public Em0501IceArmorAction()
    {
    }
}