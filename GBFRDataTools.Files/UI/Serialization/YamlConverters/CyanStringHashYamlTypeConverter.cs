using GBFRDataTools.Files.UI.Types;

using SixLabors.ImageSharp.Drawing;

using System.Globalization;
using System.Numerics;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Serialization.YamlConverters;

public class CyanStringHashYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(CyanStringHash);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        if (!parser.TryConsume<Scalar>(out Scalar scalar))
        {
            throw new InvalidOperationException("Invalid CyanStringHash element");
        }

        if (!uint.TryParse(scalar.Value, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint value))
            return new CyanStringHash(scalar.Value);
        else
            return new CyanStringHash(value);
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        var hash = (CyanStringHash)value!;

        emitter.Emit(new Scalar(AnchorName.Empty, TagName.Empty, hash.String ?? $"{hash.Hash:X8}", ScalarStyle.Plain, true, false));
    }
}
