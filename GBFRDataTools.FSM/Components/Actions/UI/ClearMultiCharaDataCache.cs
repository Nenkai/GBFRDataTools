using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ClearMultiCharaDataCache : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ClearMultiCharaDataCache);

    [JsonPropertyName("cacheType_")]
    public EnumString<ClearMultiCharaDataCacheType> CacheType { get; set; } // Offset 0x30

    public ClearMultiCharaDataCache()
    {
    }
}

public enum ClearMultiCharaDataCacheType
{
    // リザルト画面 = 0,
    ResultsScreen = 0,
}
