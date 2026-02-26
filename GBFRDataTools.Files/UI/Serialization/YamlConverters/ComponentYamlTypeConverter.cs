using GBFRDataTools.Files.UI.Assets;
using GBFRDataTools.Files.UI.Components;

using System.Numerics;

using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Serialization.YamlConverters;

public class ComponentYamlTypeConverter : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(ComponentThing);
    }

    public object? ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
    {
        parser.Consume<MappingStart>();

        if (!parser.TryConsume<Scalar>(out Scalar componentNameProperty) && componentNameProperty.Value != "ComponentName")
        {
            throw new InvalidOperationException("Invalid component thing type");
        }

        if (!parser.TryConsume<Scalar>(out Scalar componentName))
        {
            throw new InvalidOperationException("Invalid component thing type");
        }
        string componentTypeName = componentName.Value;

        if (!parser.TryConsume<Scalar>(out _) && componentNameProperty.Value != "Component")
        {
            throw new InvalidOperationException("Invalid component thing type");
        }

        var reflectedType = UIComponentSerializationCache.GetOrRegisterType(componentTypeName);
        Component component = (Component)rootDeserializer(reflectedType.Type);

        parser.Consume<MappingEnd>();

        return new ComponentThing()
        {
            ComponentName = componentTypeName,
            Component = component,
        };
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
