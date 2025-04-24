using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmFlyEvacuateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFlyEvacuateAction);

    [JsonPropertyName("motionIdWait_")]
    public string MotionIdWait { get; set; } // Offset 0xB8

    [JsonPropertyName("motionIdFlyWait_")]
    public string MotionIdFlyWait { get; set; } // Offset 0xD8

    [JsonPropertyName("motionIdBackWalkStart_")]
    public string MotionIdBackWalkStart { get; set; } // Offset 0xF8

    [JsonPropertyName("motionIdBackWalkLoop_")]
    public string MotionIdBackWalkLoop { get; set; } // Offset 0x118

    [JsonPropertyName("motionIdBackWalkEnd_")]
    public string MotionIdBackWalkEnd { get; set; } // Offset 0x138

    [JsonPropertyName("motionIdFrontWalkStart_")]
    public string MotionIdFrontWalkStart { get; set; } // Offset 0x158

    [JsonPropertyName("motionIdFrontWalkLoop_")]
    public string MotionIdFrontWalkLoop { get; set; } // Offset 0x178

    [JsonPropertyName("motionIdFrontWalkEnd_")]
    public string MotionIdFrontWalkEnd { get; set; } // Offset 0x198

    [JsonPropertyName("motionIdTakeOff_")]
    public string MotionIdTakeOff { get; set; } // Offset 0x1B8

    [JsonPropertyName("motionIdLanding_")]
    public string MotionIdLanding { get; set; } // Offset 0x1D8

    [JsonPropertyName("motionIdDiscover_")]
    public string MotionIdDiscover { get; set; } // Offset 0x1F8

    [JsonPropertyName("waitLen_")]
    public float WaitLen { get; set; } = 1f; // Offset 0x218

    [JsonPropertyName("backLen_")]
    public float BackLen { get; set; } = 10f; // Offset 0x21C

    [JsonPropertyName("flySpeed_")]
    public float FlySpeed { get; set; } = 0f; // Offset 0x220

    [JsonPropertyName("flyUpSpeed_")]
    public float FlyUpSpeed { get; set; } = 2f; // Offset 0x224

    [JsonPropertyName("moveTurnRate_")]
    public float MoveTurnRate { get; set; } = 0.1f; // Offset 0x228

    [JsonPropertyName("takeOffSeqFlag_")]
    public int TakeOffSeqFlag { get; set; } = 13; // Offset 0x22C

    [JsonPropertyName("landingSeqFlag_")]
    public int LandingSeqFlag { get; set; } = 12; // Offset 0x230

    [JsonPropertyName("isReachActionEnd_")]
    public bool IsReachActionEnd { get; set; } = false; // Offset 0x235

    [JsonPropertyName("isAppearAgainReachOnly_")]
    public bool IsAppearAgainReachOnly { get; set; } = false; // Offset 0x236

    public EmFlyEvacuateAction()
    {
    }
}
