using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1806CreateShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806CreateShotAction);

    [JsonPropertyName("createShotType_")]
    public int CreateShotType { get; set; } = 0;

    [JsonPropertyName("createTiming_")]
    public int CreateTiming { get; set; } = 0;

    [JsonPropertyName("createNum_")]
    public int CreateNum { get; set; } = 1;

    [JsonPropertyName("createSec_")]
    public float CreateSec { get; set; } = 0.5f;

    [JsonPropertyName("isCreateStart_")]
    public bool IsCreateStart { get; set; } = false;

    [JsonPropertyName("createOffset_")]
    public /* cVec4 */ Vector4 CreateOffset { get; set; } = Vector4.UnitW;
}
