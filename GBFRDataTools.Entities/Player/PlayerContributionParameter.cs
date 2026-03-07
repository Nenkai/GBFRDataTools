using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerContributionParameter
{
    /// <summary>
    /// 20 elements max
    /// </summary>
    [JsonPropertyName("contributionPointArray_")]
    public BindingList<float> ContributionPointArray { get; set; } = [];
}