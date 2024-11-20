using GBFRDataTools.Entities.Base;

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Scene.Objects;

public class CharacterMaterialSceneObject : ISceneObject
{
    [JsonPropertyName("param_")]
    public Parameter Param { get; set; }

    [JsonPropertyName("targetList_")]
    public BindingList<MaterialsHashInfo> TargetList { get; set; }

    public class /* CharacterMaterialSceneObject::Parameter */ Parameter
    {
        [JsonPropertyName("ambientColor_")]
        public GuiColor AmbientColor { get; set; }

        [JsonPropertyName("ambientIntencityMetal_")]
        public float AmbientIntencityMetal { get; set; }

        [JsonPropertyName("ambientIntensityHair_")]
        public float AmbientIntensityHair { get; set; }

        [JsonPropertyName("ambientIntensitySkin_")]
        public float AmbientIntensitySkin { get; set; }

        [JsonPropertyName("ambientRange_")]
        public float AmbientRange { get; set; }

        [JsonPropertyName("bodyRimColor_")]
        public GuiColor BodyRimColor { get; set; }

        [JsonPropertyName("characterDropShadowColor_")]
        public GuiColor CharacterDropShadowColor { get; set; }

        [JsonPropertyName("directionalLightOffsetX_")]
        public float DirectionalLightOffsetX { get; set; }

        [JsonPropertyName("directionalLightOffsetY_")]
        public float DirectionalLightOffsetY { get; set; }

        [JsonPropertyName("ditherAlpha_")]
        public float DitherAlpha { get; set; }

        [JsonPropertyName("elementalAlphaIntensity_")]
        public float ElementalAlphaIntensity { get; set; }

        [JsonPropertyName("elementalEmissiveIntensity_")]
        public float ElementalEmissiveIntensity { get; set; }

        [JsonPropertyName("emissiveIntensity_")]
        public float EmissiveIntensity { get; set; }

        [JsonPropertyName("enableBooleanMask_")]
        public bool EnableBooleanMask { get; set; }

        [JsonPropertyName("eyeEmissiveColor_")]
        public GuiColor EyeEmissiveColor { get; set; }

        [JsonPropertyName("eyeHighLightColor_")]
        public GuiColor EyeHighLightColor { get; set; }

        [JsonPropertyName("faceCheekRimOffset_")]
        public float FaceCheekRimOffset { get; set; }

        [JsonPropertyName("faceRimColor_")]
        public GuiColor FaceRimColor { get; set; }

        [JsonPropertyName("faceRimIntensity_")]
        public float FaceRimIntensity { get; set; }

        [JsonPropertyName("faceRimLimitOffset_")]
        public float FaceRimLimitOffset { get; set; }

        [JsonPropertyName("hairRimIntensity_")]
        public float HairRimIntensity { get; set; }

        [JsonPropertyName("hairRimRange_")]
        public float HairRimRange { get; set; }

        [JsonPropertyName("iblHairIntensity_")]
        public float IblHairIntensity { get; set; }

        [JsonPropertyName("iblIntensity_")]
        public float IblIntensity { get; set; }

        [JsonPropertyName("iblMetalIntensity_")]
        public float IblMetalIntensity { get; set; }

        [JsonPropertyName("iblOtherIntensity_")]
        public float IblOtherIntensity { get; set; }

        [JsonPropertyName("interDistance_")]
        public float InterDistance { get; set; }

        [JsonPropertyName("lightColor_")]
        public GuiColor LightColor { get; set; }

        [JsonPropertyName("lightIntensity_")]
        public float LightIntensity { get; set; }

        [JsonPropertyName("noseRimIntensity_")]
        public float NoseRimIntensity { get; set; }

        [JsonPropertyName("noseRimOffset_")]
        public float NoseRimOffset { get; set; }

        [JsonPropertyName("otherShadowColor_")]
        public GuiColor OtherShadowColor { get; set; }

        [JsonPropertyName("outlineAlphaCorrection_")]
        public float OutlineAlphaCorrection { get; set; }

        [JsonPropertyName("outlineFarThickness_")]
        public float OutlineFarThickness { get; set; }

        [JsonPropertyName("outlineLuminuss_")]
        public float OutlineLuminuss { get; set; }

        [JsonPropertyName("outlineNearThickness_")]
        public float OutlineNearThickness { get; set; }

        [JsonPropertyName("pointSpecularRange_")]
        public float PointSpecularRange { get; set; }

        [JsonPropertyName("pointSpecularShift_")]
        public float PointSpecularShift { get; set; }

        [JsonPropertyName("rimIntensity_")]
        public float RimIntensity { get; set; }

        [JsonPropertyName("rimRange_")]
        public float RimRange { get; set; }

        [JsonPropertyName("rimShift_")]
        public float RimShift { get; set; }

        [JsonPropertyName("shadowMin_")]
        public float ShadowMin { get; set; }

        [JsonPropertyName("shadowOtherMin_")]
        public float ShadowOtherMin { get; set; }

        [JsonPropertyName("specularHairIntensity_")]
        public float SpecularHairIntensity { get; set; }

        [JsonPropertyName("specularHairLightDirX_")]
        public float SpecularHairLightDirX { get; set; }

        [JsonPropertyName("specularHairLightDirY_")]
        public float SpecularHairLightDirY { get; set; }

        [JsonPropertyName("specularIntensity_")]
        public float SpecularIntensity { get; set; }

        [JsonPropertyName("specularLightColor_")]
        public GuiColor SpecularLightColor { get; set; }

        [JsonPropertyName("specularLightDirX_")]
        public float SpecularLightDirX { get; set; }

        [JsonPropertyName("specularLightDirY_")]
        public float SpecularLightDirY { get; set; }

        [JsonPropertyName("sssColor_")]
        public GuiColor SssColor { get; set; }

        [JsonPropertyName("sssPower_")]
        public float SssPower { get; set; }

        [JsonPropertyName("sssRange_")]
        public float SssRange { get; set; }

        [JsonPropertyName("useAmbientLight_")]
        public bool UseAmbientLight { get; set; }

        [JsonPropertyName("useBlendDropShadow_")]
        public bool UseBlendDropShadow { get; set; }

        [JsonPropertyName("useCharacterLight_")]
        public bool UseCharacterLight { get; set; }

        [JsonPropertyName("useCutRimColor_")]
        public bool UseCutRimColor { get; set; }

        [JsonPropertyName("useCutSceneLight_")]
        public bool UseCutSceneLight { get; set; }

        [JsonPropertyName("useEyeHighLightColor_")]
        public bool UseEyeHighLightColor { get; set; }

        [JsonPropertyName("useOutlineOffset_")]
        public bool UseOutlineOffset { get; set; }

        [JsonPropertyName("useRimLight_")]
        public bool UseRimLight { get; set; }

        [JsonPropertyName("useSpecularLight_")]
        public bool UseSpecularLight { get; set; }

        [JsonPropertyName("wrinkleColor_")]
        public GuiColor WrinkleColor { get; set; }
    }
}

public class MaterialsHashInfo
{
    [JsonPropertyName("objID_")]
    public uint ObjID { get; set; }

    [JsonPropertyName("targetMaterials_")]
    public BindingList<uint> TargetMaterials { get; set; }
}