using GBFRDataTools.Entities.Parameters.Player;

using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.NPC;

public class NPCRole
{
    [JsonPropertyName("roleNPCList_")]
    public BindingList<NPCRoleObject> RoleNPCList { get; set; } = []; // Offset 0x10

    [JsonPropertyName("priority_")]
    public int Priority { get; set; } // Offset 0x78

    [JsonPropertyName("isWaitAllNpcReady_")]
    public bool IsWaitAllNpcReady { get; set; } // Offset 0x7D

    [JsonPropertyName("isCounter_")]
    public bool IsCounter { get; set; } // Offset 0x7E

    [JsonPropertyName("isFitGround_")]
    public bool IsFitGround { get; set; } // Offset 0x7F

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class NPCRoleObject // NPCRole::NPCRoleObject
    {
        [JsonPropertyName("motionIdNameWait_")]
        public string MotionIdNameWait { get; set; } // Offset 0x30

        [JsonPropertyName("motionIdNameStart_")]
        public string MotionIdNameStart { get; set; } // Offset 0x50

        [JsonPropertyName("motionIdNameLoop_")]
        public string MotionIdNameLoop { get; set; } // Offset 0x70

        [JsonPropertyName("motionIdNameEnd_")]
        public string MotionIdNameEnd { get; set; } // Offset 0x90

        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; } // Offset 0x10

        [JsonPropertyName("rotation_")]
        public Vector3 Rotation { get; set; } // Offset 0x20

        [JsonPropertyName("npcTypeFilter_")]
        public uint NpcTypeFilter { get; set; } // Offset 0xB4

        [JsonPropertyName("shortNPCRotY_")]
        public float ShortNPCRotY { get; set; } // Offset 0xB8

    }
}