using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::ImageMultiSetter
public class ImageMultiSetter : Component
{
    public List<string> ImageDataPaths { get; set; }
    public UIObjectRef Target { get; set; }
}
