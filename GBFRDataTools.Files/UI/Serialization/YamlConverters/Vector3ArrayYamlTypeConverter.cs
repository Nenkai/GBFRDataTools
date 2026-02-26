using System.Numerics;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Serialization.YamlConverters;

public class Vector3ArrayYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(Vector3);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        Scalar scalar = parser.Consume<Scalar>();
        ReadOnlySpan<char> span = scalar.Value.AsSpan();

        Vector3 vec3 = default;
        int idx = 0;
        foreach (var range in span.Split(','))
        {
            if (float.TryParse(span[range], out float value))
            {
                if (idx == 0)
                    vec3.X = value;
                else if (idx == 1)
                    vec3.Y = value;
                else if (idx == 2)
                    vec3.Z = value;
                else
                    throw new InvalidDataException($"Too many vec3 elements at line {parser.Current.Start.Line}");
            }
            else
            {
                throw new InvalidDataException($"Invalid vec3 at line {parser.Current.Start.Line}");
            }

            idx++;
        }

        if (idx != 3)
            throw new InvalidDataException($"Vec3 must have 3 elements at line {parser.Current.Start.Line}");

        return vec3;
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        var vec = (Vector3)value!;

        emitter.Emit(new Scalar(AnchorName.Empty, TagName.Empty, $"{vec.X}, {vec.Y}, {vec.Z}", ScalarStyle.Plain, true, false));
    }
}
