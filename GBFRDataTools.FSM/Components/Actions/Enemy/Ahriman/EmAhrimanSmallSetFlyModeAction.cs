using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Ahriman;

public class EmAhrimanSmallSetFlyModeAction : Em0500SplineAction
{
    [JsonPropertyName("setModeType_")]
    public ModeType SetModeType { get; set; } = ModeType.Type0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}