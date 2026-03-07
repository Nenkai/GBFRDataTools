using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::MaskImageSetter
public class MaskImageSetter : Component
{
    public string ImageDataPath { get; set; }
    public UIObjectRef Mask { get; set; }
}
