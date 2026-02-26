namespace GBFRDataTools.Files.UI.Components.Setters;

// ui::component::LanguageObjSetter
public class LanguageObjSetter : Component
{
    public List<LanguageParamSet> Data { get; set; }
}

public class LanguageParamSet
{
    public List<LanguageParam> Params { get; set; }
    public int Type { get; set; }
    public int Value { get; set; }
}

public class LanguageParam
{
    public string Language { get; set; }
    public bool Actvalue { get; set; }
}
