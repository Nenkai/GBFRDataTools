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
    /// <summary>
    /// Contains <see cref="JsonStringEnumConverter"/> converter.
    /// </summary>
    public readonly static JsonSerializerOptions InstanceForRead = new();

    /// <summary>
    /// Does not contain <see cref="JsonStringEnumConverter"/> converter.
    /// </summary>
    public readonly static JsonSerializerOptions InstanceForWrite = new();

    static DefaultJsonSerializerOptions()
    {
        InstanceForRead = CreateDefault();
        InstanceForRead.Converters.Add(new JsonStringEnumConverter());

        InstanceForWrite = CreateDefault();
    }

    static JsonSerializerOptions CreateDefault()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow, // To make sure we're not missing anything
            NumberHandling = JsonNumberHandling.AllowReadingFromString, // Because they're stored as strings sometimes
            WriteIndented = true,
        };
        options.Converters.Add(new SupportEffectListConverter()); // ActionInfo::SupportEffect
        options.Converters.Add(new ElementListConverter()); // Converts "Element" arrays to proper arrays/lists
        options.Converters.Add(new ControllerConverter());
        options.Converters.Add(new cVec2Converter());
        options.Converters.Add(new cVec3Converter());
        options.Converters.Add(new cVec4Converter());

        // Scene stuff
        options.Converters.Add(new GuiImportableCurveConverter()); // Converts "Params" to a proper array

        // Scene hierarchy
        options.Converters.Add(new SceneObjectNameConverter());
        options.Converters.Add(new ManipulatableMatrixConverter());
        options.Converters.Add(new UUIDConverter());
        options.Converters.Add(new GuiColorConverter());

        options.Converters.Add(new MapConverter());

        // Required since custom converters won't recursively parse literals as strings
        // (some files store all numerals as string literals)
        options.Converters.Add(new BoolWithStringConverter());
        options.Converters.Add(new IntWithStringConverter());
        options.Converters.Add(new UIntWithStringConverter());
        options.Converters.Add(new SingleWithStringConverter());
        options.Converters.Add(new UShortWithStringConverter());

        return options;
    }
}
