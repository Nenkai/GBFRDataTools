using GBFRDataTools.Files.UI.Types;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Mask
public class Mask : Component
{
    public UIObjectRef Sprite { get; set; }
    public Vector2 Offset { get; set; }
    public Vector4 ChannelWeights { get; set; }
    public bool InvertMask { get; set; }
    public bool InvertOutsides { get; set; }
}
