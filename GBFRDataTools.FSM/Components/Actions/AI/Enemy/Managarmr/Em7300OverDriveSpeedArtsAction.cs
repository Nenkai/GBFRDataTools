using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300OverDriveSpeedArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300OverDriveSpeedArtsAction);

    [JsonPropertyName("setInterval_")]
    public /* cVec4 */ Vector4 SetInterval { get; set; } = new Vector4(0.5f, 0.0f, 0.0f, 1.0f);

    [JsonPropertyName("slashInterval_")]
    public /* cVec4 */ Vector4 SlashInterval { get; set; } = new Vector4(0.8f, 0.8f, 0.8f, 1.0f);

    [JsonPropertyName("slashEndTime_")]
    public float SlashEndTime { get; set; } = 2.0f;

    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; } = false;
}
