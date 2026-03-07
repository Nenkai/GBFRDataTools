using System.Numerics;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Serialization.YamlConverters;

public class Vector4ArrayYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(Vector4);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        Scalar scalar = parser.Consume<Scalar>();
        ReadOnlySpan<char> span = scalar.Value.AsSpan();

        Vector4 vec4 = default;
        int idx = 0;
        foreach (var range in span.Split(','))
        {
            if (float.TryParse(span[range], out float value))
            {
                if (idx == 0)
                    vec4.X = value;
                else if (idx == 1)
                    vec4.Y = value;
                else if (idx == 2)
                    vec4.Z = value;
                else if (idx == 3)
                    vec4.W = value;
                else
                    throw new InvalidDataException($"Too many vec4 elements at line {parser.Current.Start.Line}");
            }
            else
            {
                throw new InvalidDataException($"Invalid vec4 at line {parser.Current.Start.Line}");
            }

            idx++;
        }

        if (idx != 4)
            throw new InvalidDataException($"Vec4 must have 4 elements at line {parser.Current.Start.Line}");

        return vec4;
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        var vec = (Vector4)value!;

        emitter.Emit(new Scalar(AnchorName.Empty, TagName.Empty, $"{vec.X}, {vec.Y}, {vec.Z}, {vec.W}", ScalarStyle.Plain, true, false));
    }
}
