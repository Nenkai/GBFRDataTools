namespace GBFRDataTools.Files.UI.Assets;

// ui::asset::List
// note: file D62165EDB7CB75D3 & more has it in msg format
public class List
{
    public Language TextureData { get; set; }
    public Language AtlasData { get; set; }
    public List<string> Materials { get; set; }
    public List<string> Animations { get; set; }
    public List<string> ImageData { get; set; }
    public List<string> LanguageData { get; set; }
    public List<string> _9029CEE4 { get; set; }
}

public class Language
{
    public List<string> Common { get; set; }
    public List<string> Eng { get; set; }
    public List<string> Jpn { get; set; }
    public List<string> Deu { get; set; }
    public List<string> Fra { get; set; }
    public List<string> Esp { get; set; }
    public List<string> Ita { get; set; }
    public List<string> Por { get; set; }
    public List<string> Kor { get; set; }
    public List<string> Cht { get; set; }
    public List<string> Chs { get; set; }
}