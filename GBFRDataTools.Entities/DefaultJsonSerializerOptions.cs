using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Converters;

namespace GBFRDataTools.Entities;

public class DefaultJsonSerializerOptions
{
    public readonly static JsonSerializerOptions Instance = new();

    static DefaultJsonSerializerOptions()
    {
        Instance = new JsonSerializerOptions()
        {
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow, // To make sure we're not missing anything
            NumberHandling = JsonNumberHandling.AllowReadingFromString, // Because they're stored as strings sometimes
        };
        Instance.Converters.Add(new ElementListConverter()); // Converts "Element" arrays to proper arrays/lists
        Instance.Converters.Add(new ControllerConverter());
        Instance.Converters.Add(new cVec2Converter());
        Instance.Converters.Add(new cVec3Converter());
        Instance.Converters.Add(new cVec4Converter());

        // Scene stuff
        Instance.Converters.Add(new GuiImportableCurveConverter()); // Converts "Params" to a proper array

        // Scene hierarchy
        Instance.Converters.Add(new SceneObjectNameConverter());
        Instance.Converters.Add(new ManipulatableMatrixConverter());
        Instance.Converters.Add(new UUIDConverter());
        Instance.Converters.Add(new GuiColorConverter());

        // Required since custom converters won't recursively parse literals as strings
        Instance.Converters.Add(new BoolWithStringConverter());
        Instance.Converters.Add(new IntWithStringConverter()); 
        Instance.Converters.Add(new SingleWithStringConverter());

        // Why isn't this default????
        Instance.Converters.Add(new JsonStringEnumConverter());
    }
}
