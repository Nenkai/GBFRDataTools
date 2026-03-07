using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Menu;

// ui::component::Menu
public class Menu : Component
{
    public int Operation { get; set; }
    public int Output { get; set; }
    public int ItemMax { get; set; }
    public int ViewCount { get; set; }
    public bool Repeat { get; set; }
    public int Band { get; set; }
    public int Margin { get; set; }
    public List<MenuObj> Objs { get; set; }
    public UIObjectRef ScrollBar { get; set; }
    public bool Centering { get; set; }
}

public class MenuObj
{
    public UIObjectRef Obj { get; set; }
    public CyanStringHash Event { get; set; }
}
