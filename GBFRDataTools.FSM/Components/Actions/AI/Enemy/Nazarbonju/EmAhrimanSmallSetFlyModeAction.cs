using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class EmAhrimanSmallSetFlyModeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallSetFlyModeAction);

    [JsonPropertyName("setModeType_")]
    public ModeType SetModeType { get; set; } = ModeType.Type0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}