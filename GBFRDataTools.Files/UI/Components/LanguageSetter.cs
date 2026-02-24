using System.Numerics;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::LanguageSetter
public class LanguageSetter : Component
{
    public bool MultiData { get; set; }
    public string LanguageData { get; set; }
    public string LanguageOverwriteData { get; set; }
    public List<string> ContainerData { get; set; }
    public List<LanguageOverwrite> Overwrites { get; set; }
}

public class LanguageOverwrite
{
    public string Language { get; set; }
    public bool EnableFS { get; set; }
    public int FontSize { get; set; }
    public bool EnableCS { get; set; }
    public float CharacterSpaching { get; set; }
    public bool EnableLS { get; set; }
    public float LineSpaching { get; set; }
    public bool EnableMG { get; set; }
    public Vector4 Margine { get; set; }
    public bool EnableAL { get; set; }
    public int Alignment { get; set; }
}
