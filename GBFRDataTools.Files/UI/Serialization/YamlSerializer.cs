using GBFRDataTools.Files.UI.Serialization.YamlConverters;

using YamlDotNet.Serialization;

using YamlDotNet.Serialization.NamingConventions;

namespace GBFRDataTools.Files.UI.Serialization;

public class YamlSerializer
{
    public static ISerializer GetSerializer()
    {
        var serializer = new SerializerBuilder()
          .WithNamingConvention(PascalCaseNamingConvention.Instance)
          .WithTypeConverter(new Vector2ArrayYamlTypeConverter())
          .WithTypeConverter(new Vector3ArrayYamlTypeConverter())
          .WithTypeConverter(new Vector4ArrayYamlTypeConverter())
          .WithTypeConverter(new CyanStringHashYamlTypeConverter())
          .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
          .Build();

        return serializer;
    }

    public static IDeserializer GetDeserializer()
    {
        var serializer = new DeserializerBuilder()
          .WithNamingConvention(PascalCaseNamingConvention.Instance)
          .WithTypeConverter(new Vector2ArrayYamlTypeConverter())
          .WithTypeConverter(new Vector3ArrayYamlTypeConverter())
          .WithTypeConverter(new Vector4ArrayYamlTypeConverter())
          .WithTypeConverter(new CyanStringHashYamlTypeConverter())
          .WithTypeConverter(new ComponentYamlTypeConverter())
          .Build();

        return serializer;
    }
}
