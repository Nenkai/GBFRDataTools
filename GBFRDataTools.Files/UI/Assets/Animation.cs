namespace GBFRDataTools.Files.UI.Assets;

// animb - ui::asset::AnimationClip
public class Animation
{
    public List<AnimationCurve> Curves { get; set; }
    public bool Loop { get; set; }
    public float Time { get; set; }
}

// ui::component::AnimationCurve
public class AnimationCurve
{
    public string Attribute { get; set; }
    public string ObjectRef { get; set; }
    public string ComponentName { get; set; }

    // default = ui::asset::AnimationKey
    // 11 = ui::asset::AnimationSpriteKey
    // 12 = ui::asset::AnimationSoundKey
    // 13 = ui::asset::AnimationEventKey
    public int KeyType { get; set; }

    public List<AnimationElement> Elements { get; set; }
}

public class AnimationElement
{
    public List<AnimationKey> Keys { get; set; }
}

public class AnimationKey
{
    public float Time { get; set; }
    public float Value { get; set; }
    public float InSlope { get; set; }
    public float OutSlope { get; set; }
    public sbyte CurveType { get; set; }
    public bool InConstant { get; set; }
    public bool OutConstant { get; set; }
    public SpriteRef Sprite { get; set; } // Type 11 (ui::asset::AnimationSpriteKey)
    public int Id { get; set; } // Type 12 (ui::asset::AnimationSoundKey)
    public int Event { get; set; } // Type 13 (ui::asset::AnimationEventKey)
}