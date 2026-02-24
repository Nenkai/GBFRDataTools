using System.Numerics;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Serialization.YamlConverters;

public class Vector2ArrayYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(Vector2);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        Scalar scalar = parser.Consume<Scalar>();
        ReadOnlySpan<char> span = scalar.Value.AsSpan();

        Vector2 vec2 = default;
        int idx = 0;
        foreach (var range in span.Split(','))
        {
            if (float.TryParse(span[range], out float value))
            {
                if (idx == 0)
                    vec2.X = value;
                else if (idx == 1)
                    vec2.Y = value;
                else
                    throw new InvalidDataException($"Too many vec2 elements at line {parser.Current.Start.Line}");
            }
            else
            {
                throw new InvalidDataException($"Invalid vec2 at line {parser.Current.Start.Line}");
            }

            idx++;
        }

        if (idx != 2)
            throw new InvalidDataException($"Vec2 must have 2 elements at line {parser.Current.Start.Line}");

        return vec2;
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        var vec = (Vector2)value!;

        emitter.Emit(new Scalar(AnchorName.Empty, TagName.Empty, $"{vec.X}, {vec.Y}", ScalarStyle.Plain, true, false));
    }
}
