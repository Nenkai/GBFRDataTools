using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class PlayerDamageLimitParameter : CharaParameterBase
{
    [JsonPropertyName("damageLimitDataList_")]
    public DamageLimitData DamageLimitDataList { get; set; } // std::vector<PlayerDamageLimitParameter::DamageLimitData>

    public class DamageLimitData // PlayerDamageLimitParameter::DamageLimitData
    {
        [JsonPropertyName("index_")]
        public int Index { get; set; }

        [JsonPropertyName("damageLimit_")]
        public int DamageLimit { get; set; }
    }
}
