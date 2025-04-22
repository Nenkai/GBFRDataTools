using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Player;

public class CharacterInfo
{
    [JsonPropertyName("saveName_")]
    public string SaveName { get; set; } // Offset 0x118

    [JsonPropertyName("saveWeaponType_")]
    public int SaveWeaponType { get; set; } // Offset 0x120

    [JsonPropertyName("saveTribe_")]
    public int SaveTribe { get; set; } // Offset 0x124

    [JsonPropertyName("saveGender_")]
    public int SaveGender { get; set; } // Offset 0x128

    [JsonPropertyName("saveElement_")]
    public int SaveElement { get; set; } // Offset 0x12C

    [JsonPropertyName("saveActionType_")]
    public int SaveActionType { get; set; } // Offset 0x130

    [JsonPropertyName("saveCameraType_")]
    public int SaveCameraType { get; set; } // Offset 0x134

    [JsonPropertyName("saveLinkAttackType_")]
    public int SaveLinkAttackType { get; set; } // Offset 0x138

    [JsonPropertyName("characterTagString_")]
    public string CharacterTagString { get; set; } // cyan::inplace_string<32> Offset 0x48

    [JsonPropertyName("motionDefaultInterFrame_")]
    public float MotionDefaultInterFrame { get; set; } // Offset 0x94

    [JsonPropertyName("linkAttackEnableDistance_")]
    public float LinkAttackEnableDistance { get; set; } // Offset 0x98

    [JsonPropertyName("specialArtsOffsetDistance_")]
    public float SpecialArtsOffsetDistance { get; set; } // Offset 0xA0

    [JsonPropertyName("autoAttackEnableDistance_")]
    public float AutoAttackEnableDistance { get; set; } // Offset 0xA4

    [JsonPropertyName("autoAttackEnableDistanceAntiAir_")]
    public float AutoAttackEnableDistanceAntiAir { get; set; } // Offset 0xA8

    [JsonPropertyName("setupWeaponSecond_")]
    public float SetupWeaponSecond { get; set; } // Offset 0xAC

    [JsonPropertyName("poseChangeSecond_")]
    public float PoseChangeSecond { get; set; } // Offset 0xB0

    [JsonPropertyName("normalFirstAttackActionId_")]
    public int NormalFirstAttackActionId { get; set; } // Offset 0x70

    [JsonPropertyName("specialFirstAttackActionId_")]
    public int SpecialFirstAttackActionId { get; set; } // Offset 0x74

    [JsonPropertyName("airNormalFirstAttackActionId_")]
    public int AirNormalFirstAttackActionId { get; set; } // Offset 0x78

    [JsonPropertyName("airSpecialFirstAttackActionId_")]
    public int AirSpecialFirstAttackActionId { get; set; } // Offset 0x7C

    [JsonPropertyName("leftAbilityActionId_")]
    public int LeftAbilityActionId { get; set; } // Offset 0x80

    [JsonPropertyName("upAbilityActionId_")]
    public int UpAbilityActionId { get; set; } // Offset 0x84

    [JsonPropertyName("rightAbilityActionId_")]
    public int RightAbilityActionId { get; set; } // Offset 0x88

    [JsonPropertyName("bottomAbilityActionId_")]
    public int BottomAbilityActionId { get; set; } // Offset 0x8C

    [JsonPropertyName("guardActionId_")]
    public int GuardActionId { get; set; } // Offset 0x90

    [JsonPropertyName("specialArtsHormingType_")]
    public int SpecialArtsHormingType { get; set; } // Offset 0xB4

    [JsonPropertyName("specialArtsEnableDistance_")]
    public float SpecialArtsEnableDistance { get; set; } // Offset 0x9C

    [JsonPropertyName("spArtsCutInAnimList_")]
    public BindingList<PlayerAnimOverrideParameter> SpArtsCutInAnimList { get; set; } = []; // std::vector<PlayerAnimOverrideParameter> - Offset 0xB8

    [JsonPropertyName("questClearAnimList_")]
    public BindingList<PlayerAnimOverrideParameter> QuestClearAnimList { get; set; } = []; // std::vector<PlayerAnimOverrideParameter> - Offset 0xD0

    [JsonPropertyName("hitVfxBaseScale_")]
    public float HitVfxBaseScale { get; set; } // Offset 0xE8

    [JsonPropertyName("vfxOverrideList_")]
    public BindingList<PlayerHitEffectOverrideParameter> VfxOverrideList { get; set; } = []; // std::vector<PlayerHitEffectOverrideParameter> - Offset 0xF0

    [JsonPropertyName("enableLinkAttackCamera_")]
    public bool EnableLinkAttackCamera { get; set; } // Offset 0x108

    [JsonPropertyName("enableLinkAttackVFXParentOwner_")]
    public bool EnableLinkAttackVFXParentOwner { get; set; } // Offset 0x109

    [JsonPropertyName("enableLinkAttackHeightBlend_")]
    public bool EnableLinkAttackHeightBlend { get; set; } // Offset 0x10A

    [JsonPropertyName("enableLinkAttackTestMode_")]
    public bool EnableLinkAttackTestMode { get; set; } // Offset 0x10B

    [JsonPropertyName("enableDamageAbilityFromAIManager_")]
    public bool EnableDamageAbilityFromAIManager { get; set; } // Offset 0x10C

    [JsonPropertyName("linkAttackMotionType_")]
    public int LinkAttackMotionType { get; set; } // Offset 0x110

    public CharacterInfo()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class PlayerAnimOverrideParameter
{
    [JsonPropertyName("weaponId_")]
    public int WeaponId { get; set; } // Offset 0x8

    [JsonPropertyName("overrideMotId_")]
    public string OverrideMotId { get; set; } // Offset 0x10

    [JsonPropertyName("motionSlotNo_")]
    public int MotionSlotNo { get; set; } // Offset 0x30

    [JsonPropertyName("memo_")]
    public string Memo { get; set; } // Offset 0x38

    public PlayerAnimOverrideParameter()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class PlayerHitEffectOverrideParameter
{
    [JsonPropertyName("actionID_")]
    public int ActionID { get; set; } // Offset 0x10

    [JsonPropertyName("vfxId_")]
    public int VfxId { get; set; } // Offset 0x14

    [JsonPropertyName("isCoreData_")]
    public bool IsCoreData { get; set; } // Offset 0x8

    [JsonPropertyName("memo_")]
    [Obsolete("Not used by the game.")]
    public string Memo { get; set; }

    [JsonPropertyName("isReplaceVfxData_")]
    public bool IsReplaceVfxData { get; set; } // Offset 0x9

    [JsonPropertyName("vfxScaleRate_")]
    public float VfxScaleRate { get; set; } // Offset 0xC

    [JsonPropertyName("isCoreDataWeakElement_")]
    public bool IsCoreDataWeakElement { get; set; } // Offset 0x18

    [JsonPropertyName("isExistWeakElementData_")]
    public bool IsExistWeakElementData { get; set; } // Offset 0x19

    [JsonPropertyName("weakVfxId_")]
    public int WeakVfxId { get; set; } // Offset 0x1C

    public PlayerHitEffectOverrideParameter()
    {
    }
}
