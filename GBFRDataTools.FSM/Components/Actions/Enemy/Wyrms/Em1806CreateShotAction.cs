using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1806CreateShotAction : ActionComponent
{
    [JsonPropertyName("createShotType_")]
    public int CreateShotType { get; set; }

    [JsonPropertyName("createTiming_")]
    public int CreateTiming { get; set; }

    [JsonPropertyName("createNum_")]
    public int CreateNum { get; set; }

    [JsonPropertyName("createSec_")]
    public float CreateSec { get; set; }

    [JsonPropertyName("isCreateStart_")]
    public bool IsCreateStart { get; set; }

    [JsonPropertyName("createOffset_")]
    public cVec4 CreateOffset { get; set; }
}
