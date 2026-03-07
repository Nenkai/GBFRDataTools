namespace GBFRDataTools.Files.UI.Components;

// ui::component::AnimationHandle
public class AnimationHandle : Component
{
    public int Offset { get; set; }
    public List<AnimationHandleObj> Handles { get; set; } = [];
}

// ui::component::AnimationHandleObj
public class AnimationHandleObj
{
    public string LayerName { get; set; }
    public List<string> Clips { get; set; }
    public bool Skip { get; set; }
}
