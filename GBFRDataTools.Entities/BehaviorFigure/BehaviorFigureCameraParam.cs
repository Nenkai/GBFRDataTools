using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.BehaviorFigure;

public class BehaviorFigureCameraParam
{
    [JsonPropertyName("details_")]
    public Map<uint, Detail> Details { get; set; } = new(); // std::map<uint,BehaviorFigureCameraParam::Detail>

    [JsonPropertyName("em2100GunPos_")]
    public Vector3 Em2100GunPos { get; set; }

    [JsonPropertyName("em2100AxePos_")]
    public Vector3 Em2100AxePos { get; set; }

    [JsonPropertyName("em2100CanePos_")]
    public Vector3 Em2100CanePos { get; set; }

    [JsonPropertyName("em2100SpearPos_")]
    public Vector3 Em2100SpearPos { get; set; }

    [JsonPropertyName("em2100GunRot_")]
    public Vector3 Em2100GunRot { get; set; }

    [JsonPropertyName("em2100AxeRot_")]
    public Vector3 Em2100AxeRot { get; set; }

    [JsonPropertyName("em2100CaneRot_")]
    public Vector3 Em2100CaneRot { get; set; }

    [JsonPropertyName("em2100SpearRot_")]
    public Vector3 Em2100SpearRot { get; set; }

    [JsonPropertyName("em8400ElementCoreOffsets_")]
    public BindingList<Offset> Em8400ElementCoreOffsets { get; set; } = [];

    [JsonPropertyName("em2500Offsets_")]
    public BindingList<Offset> Em2500Offsets { get; set; } = [];

    [JsonPropertyName("plSpColorEyeEmissive_")]
    [Editable(false)]
    public BindingList<float> PlSpColorEyeEmissive { get; set; } = [.. Enumerable.Repeat(0.0f, 4)]; // std::array<float, 4>

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Detail /* BehaviorFigureCameraParam::Detail */
    {
        [JsonPropertyName("objPos_")]
        public Vector3 ObjPos { get; set; }
    
        [JsonPropertyName("objRot_")]
        public Vector3 ObjRot { get; set; }
    
        [JsonPropertyName("p0Pos_")]
        public Vector3 P0Pos { get; set; }
    
        [JsonPropertyName("p0Rot_")]
        public Vector3 P0Rot { get; set; }
    
        [JsonPropertyName("p1Pos_")]
        public Vector3 P1Pos { get; set; }
    
        [JsonPropertyName("p1Rot_")]
        public Vector3 P1Rot { get; set; }
    
        [JsonPropertyName("pos_")]
        public Vector3 Pos { get; set; }
    
        [JsonPropertyName("rotX_")]
        public float RotX { get; set; }
    
        [JsonPropertyName("maxX_")]
        public float MaxX { get; set; }
    
        [JsonPropertyName("maxY_")]
        public float MaxY { get; set; }
    
        [JsonPropertyName("minY_")]
        public float MinY { get; set; }

        [JsonPropertyName("distMax_")]
        public float DistMax { get; set; }
    
        [JsonPropertyName("distMin_")]
        public float DistMin { get; set; }
    
        [JsonPropertyName("distRate_")]
        public float DistRate { get; set; }
    
        [JsonPropertyName("moveRateX_")]
        public float MoveRateX { get; set; }
    
        [JsonPropertyName("moveRateY_")]
        public float MoveRateY { get; set; }
    
        [JsonPropertyName("rotRateX_")]
        public float RotRateX { get; set; }
    
        [JsonPropertyName("rotRateY_")]
        public float RotRateY { get; set; }
    
        [JsonPropertyName("rotMaxX_")]
        public float RotMaxX { get; set; }
    
        [JsonPropertyName("rotMinX_")]
        public float RotMinX { get; set; }
    
        [JsonPropertyName("fovY_")]
        public float FovY { get; set; }
    
        [JsonPropertyName("areaName_")]
        public string? AreaName { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Offset /* BehaviorFigureCameraParam::Offset */
    {
        [JsonPropertyName("pos_")]
        public Vector3 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector3 Rot { get; set; }
    }
}
