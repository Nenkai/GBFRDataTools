using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmEvacuateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmEvacuateAction);

    [JsonPropertyName("motionIdWait_")]
    public string MotionIdWait { get; set; } // Offset 0x98

    [JsonPropertyName("motionIdBackWalkStart_")]
    public string MotionIdBackWalkStart { get; set; } // Offset 0xB8

    [JsonPropertyName("motionIdBackWalkLoop_")]
    public string MotionIdBackWalkLoop { get; set; } // Offset 0xD8

    [JsonPropertyName("motionIdBackWalkEnd_")]
    public string MotionIdBackWalkEnd { get; set; } // Offset 0xF8

    [JsonPropertyName("motionIdFrontWalkStart_")]
    public string MotionIdFrontWalkStart { get; set; } // Offset 0x118

    [JsonPropertyName("motionIdFrontWalkLoop_")]
    public string MotionIdFrontWalkLoop { get; set; } // Offset 0x138

    [JsonPropertyName("motionIdFrontWalkEnd_")]
    public string MotionIdFrontWalkEnd { get; set; } // Offset 0x158

    [JsonPropertyName("motionIdJumpStart_")]
    public string MotionIdJumpStart { get; set; } // Offset 0x178

    [JsonPropertyName("motionIdJumpRaise_")]
    public string MotionIdJumpRaise { get; set; } // Offset 0x198

    [JsonPropertyName("motionIdJumpTop_")]
    public string MotionIdJumpTop { get; set; } // Offset 0x1B8

    [JsonPropertyName("motionIdJumpFall_")]
    public string MotionIdJumpFall { get; set; } // Offset 0x1D8

    [JsonPropertyName("motionIdJumpLanding_")]
    public string MotionIdJumpLanding { get; set; } // Offset 0x1F8

    [JsonPropertyName("motionIdDiscover_")]
    public string MotionIdDiscover { get; set; } // Offset 0x218

    [JsonPropertyName("waitLen_")]
    public float WaitLen { get; set; } = 1f; // Offset 0x238

    [JsonPropertyName("backLen_")]
    public float BackLen { get; set; } = 10f; // Offset 0x23C

    [JsonPropertyName("moveTurnRate_")]
    public float MoveTurnRate { get; set; } = 0.1f; // Offset 0x240

    [JsonPropertyName("jumpSeqFlag_")]
    public int JumpSeqFlag { get; set; } = 16; // Offset 0x244

    public EmEvacuateAction()
    {
    }
}