namespace GBFRDataTools.Files.UI.Components;

// ui::component::Animator
public class Animator : Component
{
    public Custom Base { get; set; }
    public Custom Change { get; set; }
    public List<Layer> Layers { get; set; }
}

// ui::animation::Custom
public class Custom
{
    public string Layer { get; set; }
    public List<int> Indexes { get; set; }
}

// ui::animation::Layer
public class Layer
{
    public string Name { get; set; }
    public List<int> Defaults { get; set; }
    public List<State> States { get; set; }
}

public class State
{
    public bool WriteDefault { get; set; }
    public string AnimationPath { get; set; }
}
