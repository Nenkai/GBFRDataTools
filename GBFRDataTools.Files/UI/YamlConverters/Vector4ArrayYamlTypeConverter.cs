using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.YamlConverters;

public class Vector4ArrayYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(Vector4);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        throw new NotImplementedException();
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        var vec = (Vector4)value!;

        emitter.Emit(new Scalar(AnchorName.Empty, TagName.Empty, $"{vec.X}, {vec.Y}, {vec.Z}, {vec.W}", ScalarStyle.Plain, true, false));
    }
}
