using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Movie
public class Movie : Component
{
    public UIObjectRef Image { get; set; }
    public string FileName { get; set; }
    public UIObjectRef FadeImage { get; set; }
    public bool Loop { get; set; }
    public float FadeTime { get; set; }
}
