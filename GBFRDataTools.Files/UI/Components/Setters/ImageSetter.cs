using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::ImageSetter
public class ImageSetter : Component
{
    public int ButtonType { get; set; }
    public string ImageDataPath { get; set; }
    public UIObjectRef Target { get; set; }
}
