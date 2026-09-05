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
    public string? SaveName { get; set; }

    [JsonPropertyName("saveWeaponType_")]
    public int SaveWeaponType { get; set; }

    [JsonPropertyName("saveTribe_")]
    public int SaveTribe { get; set; }

    [JsonPropertyName("saveGender_")]
    public int SaveGender { get; set; }

    [JsonPropertyName("saveElement_")]
    public int SaveElement { get; set; }

    [JsonPropertyName("saveActionType_")]
    public int SaveActionType { get; set; }

    [JsonPropertyName("saveCameraType_")]
    public int SaveCameraType { get; set; }

    [JsonPropertyName("saveLinkAttackType_")]
    public int SaveLinkAttackType { get; set; }

    [JsonPropertyName("characterTagString_")]
    public string? CharacterTagString { get; set; } // cyan::inplace_string<32>

    [JsonPropertyName("motionDefaultInterFrame_")]
    public float MotionDefaultInterFrame { get; set; }

    [JsonPropertyName("linkAttackEnableDistance_")]
    public float LinkAttackEnableDistance { get; set; }

    [JsonPropertyName("linkAttackblendAdjustRate_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float LinkAttackblendAdjustRate { get; set; }

    [JsonPropertyName("specialArtsOffsetDistance_")]
    public float SpecialArtsOffsetDistance { get; set; }

    [JsonPropertyName("autoAttackEnableDistance_")]
    public float AutoAttackEnableDistance { get; set; }

    [JsonPropertyName("autoAttackEnableDistanceAntiAir_")]
    public float AutoAttackEnableDistanceAntiAir { get; set; }

    [JsonPropertyName("setupWeaponSecond_")]
    public float SetupWeaponSecond { get; set; }

    [JsonPropertyName("poseChangeSecond_")]
    public float PoseChangeSecond { get; set; }

    [JsonPropertyName("normalFirstAttackActionId_")]
    public int NormalFirstAttackActionId { get; set; }

    [JsonPropertyName("specialFirstAttackActionId_")]
    public int SpecialFirstAttackActionId { get; set; }

    [JsonPropertyName("airNormalFirstAttackActionId_")]
    public int AirNormalFirstAttackActionId { get; set; }

    [JsonPropertyName("airSpecialFirstAttackActionId_")]
    public int AirSpecialFirstAttackActionId { get; set; }

    [JsonPropertyName("leftAbilityActionId_")]
    public int LeftAbilityActionId { get; set; }

    [JsonPropertyName("upAbilityActionId_")]
    public int UpAbilityActionId { get; set; }

    [JsonPropertyName("rightAbilityActionId_")]
    public int RightAbilityActionId { get; set; }

    [JsonPropertyName("bottomAbilityActionId_")]
    public int BottomAbilityActionId { get; set; }

    [JsonPropertyName("guardActionId_")]
    public int GuardActionId { get; set; }

    [JsonPropertyName("specialArtsHormingType_")]
    public int SpecialArtsHormingType { get; set; }

    [JsonPropertyName("specialArtsEnableDistance_")]
    public float SpecialArtsEnableDistance { get; set; }

    [JsonPropertyName("specialArtsChainEnableDistance_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float SpecialArtsChainEnableDistance { get; set; }

    [JsonPropertyName("spArtsCutInAnimList_")]
    public BindingList<PlayerAnimOverrideParameter> SpArtsCutInAnimList { get; set; } = []; // std::vector<PlayerAnimOverrideParameter>

    [JsonPropertyName("questClearAnimList_")]
    public BindingList<PlayerAnimOverrideParameter> QuestClearAnimList { get; set; } = []; // std::vector<PlayerAnimOverrideParameter>

    [JsonPropertyName("hitVfxBaseScale_")]
    public float HitVfxBaseScale { get; set; }

    [JsonPropertyName("vfxOverrideList_")]
    public BindingList<PlayerHitEffectOverrideParameter> VfxOverrideList { get; set; } = []; // std::vector<PlayerHitEffectOverrideParameter>

    [JsonPropertyName("enableLinkAttackCamera_")]
    public bool EnableLinkAttackCamera { get; set; }

    [JsonPropertyName("enableLinkAttackVFXParentOwner_")]
    public bool EnableLinkAttackVFXParentOwner { get; set; }

    [JsonPropertyName("enableLinkAttackHeightBlend_")]
    public bool EnableLinkAttackHeightBlend { get; set; }

    [JsonPropertyName("enableLinkAttackTestMode_")]
    public bool EnableLinkAttackTestMode { get; set; }

    [JsonPropertyName("enableDamageAbilityFromAIManager_")]
    public bool EnableDamageAbilityFromAIManager { get; set; }

    [JsonPropertyName("linkAttackMotionType_")]
    public int LinkAttackMotionType { get; set; }

    [JsonPropertyName("characterCollisionType_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int CharacterCollisionType { get; set; }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class PlayerAnimOverrideParameter
{
    [JsonPropertyName("weaponId_")]
    public int WeaponId { get; set; }

    [JsonPropertyName("overrideMotId_")]
    public string? OverrideMotId { get; set; }

    [JsonPropertyName("motionSlotNo_")]
    public int MotionSlotNo { get; set; }

    [JsonPropertyName("memo_")]
    public string? Memo { get; set; }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class PlayerHitEffectOverrideParameter
{
    [JsonPropertyName("actionID_")]
    public int ActionID { get; set; }

    [JsonPropertyName("vfxId_")]
    public int VfxId { get; set; }

    [JsonPropertyName("isCoreData_")]
    public bool IsCoreData { get; set; }

    [JsonPropertyName("memo_")]
    [Obsolete("Not used by the game.")]
    public string? Memo { get; set; }

    [JsonPropertyName("isReplaceVfxData_")]
    public bool IsReplaceVfxData { get; set; }

    [JsonPropertyName("vfxScaleRate_")]
    public float VfxScaleRate { get; set; }

    [JsonPropertyName("isCoreDataWeakElement_")]
    public bool IsCoreDataWeakElement { get; set; }

    [JsonPropertyName("isExistWeakElementData_")]
    public bool IsExistWeakElementData { get; set; }

    [JsonPropertyName("weakVfxId_")]
    public int WeakVfxId { get; set; }
}
