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
        public int angleType_ { get; set; }
        public float baseScale_ { get; set; }
        public cVec4 boxOffset_ { get; set; }
        public float boxScale_ { get; set; }
        public int castType_ { get; set; }
        public float controlAngleXMax_ { get; set; }
        public float controlAngleXMin_ { get; set; }
        public float density_ { get; set; }
        public float densityNotSelf_ { get; set; }
        public float fadeDistance_ { get; set; }
        public float fadePower_ { get; set; }
        public float jumpHeight_ { get; set; }
        public cVec4 projectionAngle_ { get; set; }
        public float sampleDisk_ { get; set; }
        public bool selfShadow_ { get; set; }
        public float sphereRadiusBlur_ { get; set; }
        public float sphereRadiusInner_ { get; set; }
        public bool useWeaponSize_ { get; set; }
        public bool xorNormalShadow_ { get; set; }
        public float zBias_ { get; set; }
    }
}


