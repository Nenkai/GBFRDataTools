using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Converters;
using GBFRDataTools.Entities.Preset;

using MessagePack;

namespace GBFRDataTools.Entities.Scene.Objects;

public class DropShadowSceneObject : ISceneObject
{
    [JsonPropertyName("paramater_")]
    public Paramater Parameter { get; set; }

    [JsonPropertyName("objId_")]
    public uint ObjId { get; set; }

    [JsonPropertyName("useSceneObjectEntityId_")]
    public bool UseSceneObjectEntityId { get; set; }

    [JsonPropertyName("castFace_")]
    public bool CastFace { get; set; }

    [JsonPropertyName("castWeapon_")]
    public bool CastWeapon { get; set; }

    public class /* DropShadowSceneObject::Paramater */ Paramater
    {
        [JsonPropertyName("angleType_")]
        public int AngleType { get; set; }

        [JsonPropertyName("baseScale_")]
        public float BaseScale { get; set; }

        [JsonPropertyName("boxOffset_")]
        public /* cVec4 */ Vector4 BoxOffset { get; set; }

        [JsonPropertyName("boxScale_")]
        public float BoxScale { get; set; }

        [JsonPropertyName("castType_")]
        public int CastType { get; set; }

        [JsonPropertyName("controlAngleXMax_")]
        public float ControlAngleXMax { get; set; }

        [JsonPropertyName("controlAngleXMin_")]
        public float ControlAngleXMin { get; set; }

        [JsonPropertyName("density_")]
        public float Density { get; set; }

        [JsonPropertyName("densityNotSelf_")]
        public float DensityNotSelf { get; set; }

        [JsonPropertyName("fadeDistance_")]
        public float FadeDistance { get; set; }

        [JsonPropertyName("fadePower_")]
        public float FadePower { get; set; }

        [JsonPropertyName("jumpHeight_")]
        public float JumpHeight { get; set; }

        [JsonPropertyName("projectionAngle_")]
        public /* cVec4 */ Vector4 ProjectionAngle { get; set; }

        [JsonPropertyName("sampleDisk_")]
        public float SampleDisk { get; set; }

        [JsonPropertyName("selfShadow_")]
        public bool SelfShadow { get; set; }

        [JsonPropertyName("sphereRadiusBlur_")]
        public float SphereRadiusBlur { get; set; }

        [JsonPropertyName("sphereRadiusInner_")]
        public float SphereRadiusInner { get; set; }

        [JsonPropertyName("useWeaponSize_")]
        public bool UseWeaponSize { get; set; }

        [JsonPropertyName("xorNormalShadow_")]
        public bool XorNormalShadow { get; set; }

        [JsonPropertyName("zBias_")]
        public float ZBias { get; set; }
    }
}


