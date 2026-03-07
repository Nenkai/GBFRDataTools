using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerBuffParameter
{
    [JsonPropertyName("illusionInInvisibleTime_")]
    public float IllusionInInvisibleTime { get; set; } = 1.0f;

    [JsonPropertyName("aiSelectUseAbilityType_")]
    public int AiSelectUseAbilityType { get; set; } = 0;
}
