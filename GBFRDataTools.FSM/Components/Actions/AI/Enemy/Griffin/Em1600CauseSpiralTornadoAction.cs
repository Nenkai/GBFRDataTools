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

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600CauseSpiralTornadoAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600CauseSpiralTornadoAction);

    [JsonPropertyName("offsetPos_")]
    [Editable(false)]
    public BindingList<Vector4> OffsetPos { get; set; } = [.. Enumerable.Repeat(new Vector4(), 4)];// Offset 0x40

    [JsonPropertyName("offsetRotY_")]
    [Editable(false)]
    public BindingList<float> OffsetRotY { get; set; } = [.. Enumerable.Repeat(0, 3)]; // Offset 0x70

    public Em1600CauseSpiralTornadoAction()
    {
    }
}
