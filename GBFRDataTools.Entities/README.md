# GBFRDataTools.Entities

General game entities. The game uses reflection to expose many objects and fields that can be used across FSMs and other text based files.

Most have been dumped through [gbfr.utility.modtools](https://github.com/Nenkai/gbfr.utility.modtools)

Currently handles:

* All scene hierarchy files in `layout/` as `Scene/SceneHierarchyFile.cs`
* All top level player files in `system/player`
* Equip Preset files `system/preset/*.msg` as `Preset/EquipPresetFile.cs`
* Quest BaseInfo files `quest/<quest_id>/baseinfo.msg` as `Quest/BaseInfo.cs`
* Scenario files `system/scenario` as `Scenario/*.cs`
* Serious Voice file `system/table/voice/serious_voice.msg` as `Table/SeriousVoiceCheckDataFile.cs`
* Text files in `system/table` as `TextDataFile.cs`
