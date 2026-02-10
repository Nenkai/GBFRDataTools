using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.YamlConverters;

public class Vector2ArrayYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(Vector2);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        throw new NotImplementedException();
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        var vec = (Vector2)value!;

        emitter.Emit(new Scalar(AnchorName.Empty, TagName.Empty, $"{vec.X}, {vec.Y}", ScalarStyle.Plain, true, false));
    }
}
