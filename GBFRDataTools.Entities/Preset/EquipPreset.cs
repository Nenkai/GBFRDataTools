using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

using GBFRDataTools.Entities.Converters;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.Entities.Preset;

/// <summary>
/// tool::character::PresetList
/// </summary>
public class EquipPreset
{
    [JsonPropertyName("presets_")]
    public BindingList<PresetData> Presets { get; set; } = [];
}

/// <summary>
/// tool::character::PresetData
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PresetData
{
    [JsonPropertyName("stageNo_")]
    public int StageNo { get; set; }

    [JsonPropertyName("diff_")]
    public string Diff { get; set; }

    [JsonPropertyName("ultimate_")]
    public bool Ultimate { get; set; }

    [JsonPropertyName("charaID_")]
    public string CharaID { get; set; }

    [JsonPropertyName("charaLevel_")]
    public int CharaLevel { get; set; }

    [JsonPropertyName("costumeNo_")]
    public int CostumeNo { get; set; }

    [JsonPropertyName("weaponID_")]
    public string WeaponID { get; set; }

    [JsonPropertyName("weaponLevel_")]
    public int WeaponLevel { get; set; }

    [JsonPropertyName("weaponLimit_")]
    public int WeaponLimit { get; set; }

    [JsonPropertyName("awake_")]
    public int Awake { get; set; }

    [JsonPropertyName("plus_")]
    public int Plus { get; set; }

    [JsonPropertyName("pendulum_")]
    public BindingList<PendulumPreset> Pendulum { get; set; } = [];

    // NOTE: Type is correct - not sure about this one though, string seems to change but value is always 0 across all files.
    [JsonPropertyName("presetType_")]
    public EnumString<PresetDataType> PresetType { get; set; }

    [JsonPropertyName("gems_")]
    public BindingList<GemPreset> Gems { get; set; } = [];

    [JsonPropertyName("treeAtk_")]
    public int TreeAtk { get; set; }

    [JsonPropertyName("treeDef_")]
    public int Treedef { get; set; }

    [JsonPropertyName("treeWeapons_")]
    public BindingList<int> TreeWeapons { get; set; } = [];

    [JsonPropertyName("meditations_")]
    public BindingList<MeditationPreset> Meditations { get; set; } = [];

    [JsonPropertyName("abilityIDs_")]
    public BindingList<string> AbilityIDs { get; set; } = [];

    [JsonPropertyName("fateEpisode_")]
    public int FateEpisode { get; set; }

    [JsonPropertyName("rangeNo_")]
    public int RangeNo { get; set; }

    [JsonPropertyName("comment_")]
    public string Comment { get; set; }
}

public enum PresetDataType
{
    Default = 0,
}

// tool::character::PendulumPreset
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PendulumPreset
{
    [JsonPropertyName("pskill_")]
    public string PSkill { get; set; }

    [JsonPropertyName("pskillLevel_")]
    public int PSkillLevel { get; set; }
}

/// <summary>
/// tool::character::GemPreset
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class GemPreset
{
    [JsonPropertyName("gemID_")]
    public string GemID { get; set; }

    [JsonPropertyName("gemLevel_")]
    public int GemLevel { get; set; }
}

/// <summary>
/// tool::character::MeditationPreset
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class MeditationPreset
{
    [JsonPropertyName("meditation_")]
    public string Meditation { get; set; }

    [JsonPropertyName("meditationLevel_")]
    public int MeditationLevel { get; set; }
}
