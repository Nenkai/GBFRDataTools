using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

[Description("""
    Managarmr Jumps off screen, before assaulting the battlefield with player tracking dash attacks. Calls em7300_od_arts_speed_slash_fsm_ingame after each slash interval timer.
    """)]
public class Em7300OverDriveSpeedArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300OverDriveSpeedArtsAction);

    [Description("Amount of time to wait inbetween sets of 4 FSM calls")]
    [JsonPropertyName("setInterval_")]
    public /* cVec4 */ Vector4 SetInterval { get; set; } = new Vector4(0.5f, 0.0f, 0.0f, 1.0f);

    [Description("The amount of time to wait inbetween FSM Calls")]
    [JsonPropertyName("slashInterval_")]
    public /* cVec4 */ Vector4 SlashInterval { get; set; } = new Vector4(0.8f, 0.8f, 0.8f, 1.0f);

    [Description("The amount of time to wait after the final slash call before reappearing on the map")]
    [JsonPropertyName("slashEndTime_")]
    public float SlashEndTime { get; set; } = 2.0f;

    [Description("Slash Attacks will be created in the center of the map instead of on a player, creating a large X")]
    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; } = false;
}
