using GBFRDataTools.Files.UI.Assets;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Gauss
public class Gauss : Component
{
    public SpriteRef Sprite { get; set; }
    public float Rate { get; set; }
    public bool IsFullscreen { get; set; }
}
