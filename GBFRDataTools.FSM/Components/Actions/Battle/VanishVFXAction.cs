using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class VanishVFXAction : ActionComponent
{
    [JsonPropertyName("id_")]
    public int Id { get; set; }

    [JsonPropertyName("isVanishAll_")]
    public bool IsVanishAll { get; set; }
}