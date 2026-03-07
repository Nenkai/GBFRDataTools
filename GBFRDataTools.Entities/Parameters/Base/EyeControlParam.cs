using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class EyeControlParam
{
    [JsonPropertyName("eyeParamL_")]
    public EyeLimit EyeParamL { get; set; }

    [JsonPropertyName("eyeParamR_")]
    public EyeLimit EyeParamR { get; set; }

    [JsonPropertyName("attenuareHighlightRate_")]
    public /* cVec2 */ Vector2 AttenuareHighlightRate { get; set; }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EyeLimit // EyeControlParam::EyeLimit
    {
        [JsonPropertyName("pupilLimitX_")]
        public ValueRange PupilLimitX { get; set; }

        [JsonPropertyName("pupilLimitY_")]
        public ValueRange PupilLimitY { get; set; }

        [JsonPropertyName("highlightLimitX_")]
        public ValueRange HighlightLimitX { get; set; }

        [JsonPropertyName("highlightLimitY_")]
        public ValueRange HighlightLimitY { get; set; }

        [JsonPropertyName("attenuateThresholdX_")]
        public ValueRange AttenuateThresholdX { get; set; }

        [JsonPropertyName("attenuateThresholdY_")]
        public ValueRange AttenuateThresholdY { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ValueRange // EyeControlParam::ValueRange
    {
        [JsonPropertyName("min_")]
        public float EyeParamL { get; set; }

        [JsonPropertyName("max_")]
        public float Max { get; set; }
    }
}
