using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl1200Param : PlayerParameterInfo
{
    [JsonPropertyName("addAtkRatByLinkTimeRapidSlash_")]
    public float AddAtkRatByLinkTimeRapidSlash { get; set; }
}
