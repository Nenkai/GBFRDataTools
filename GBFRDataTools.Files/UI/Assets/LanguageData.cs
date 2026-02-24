namespace GBFRDataTools.Files.UI.Assets;

// langb - ui::asset::LanguageData
// note: file 43286F3E023A5B1D has it in msg format
public class LanguageData
{
    public List<LanguageDataElement> FontSettings { get; set; }
}

// ui::asset::LanguageDataElement
public class LanguageDataElement
{
    public string Language { get; set; }
    public string Font { get; set; }
    public string Material { get; set; }
    public int FontSizeOffset { get; set; }
    public float CharacterSpacingOffset { get; set; }
    public float LineSpacingOffset { get; set; }
    public bool Force { get; set; }
}