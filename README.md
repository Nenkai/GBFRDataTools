# GBFRDataTools

<div width="100%">
  <a href="https://ko-fi.com/nenkai" width="40%">
    <img src="https://ko-fi.com/img/githubbutton_sm.svg" alt="Support me on Ko-Fi">
  </a>
</div>

Data Tool for Granblue Fantasy: Relink archives (data.i)

Features:
* Extraction
  * Extracting singular files (if you know their paths and their hash matches)
  * All known files
* Modding
  * Adding files marked as external files (which means they can be outside `data.X` like files in the data folder)
* Conversion of `viewb`, `listb`, `texb`, `prfb` to or from `yaml`
  * Note that not all `prfb` files are supported. More details in research notes.
* Conversion of table files `.tbl` <-> `.sqlite`

### Release build [here](https://github.com/Nenkai/GBFRDataTools/releases).

---

## Research Notes

* Currently, 98.2% of all game paths are known (v1.3.1)
* It is possible to run the game fully unpacked by removing `data.i`, however all game files need to be extracted in a `data` folder - requires the majority of game paths mapped out which is not the case yet.
* `data.i` among other file formats such as models uses FlatBuffers (Cy's internal handler is named FlatArk). It is fully understood and documented in [IndexFile.fbs](https://github.com/Nenkai/GBFRDataTools/blob/master/GBFRDataTools.FlatBuffers/IndexFile.fbs).
* Data/Archive file #2 is hardcoded not to be read from. It is only used on console versions.
* All `.xxxb` files are UI declarations with names hashed. Many can be recovered from the internal reflection system (specifically `<type>::createAttr::ObjectTypeBuilder::vftable` uses), but not all properties are present. Basically every `.prfb` file will use an unique UI component that needs to be supported. Refer to [these files](https://github.com/Nenkai/GBFRDataTools/tree/master/GBFRDataTools.Core/UI).

## Credits

* [WistfulHopes](https://github.com/WistfulHopes) - Research & File Paths
* [AlphaSatanOmega](https://github.com/AlphaSatanOmega), [SheItoon](https://github.com/SheItoon) - Path Finding

## Discord (EN)

Join the Relink Modding Discord For help, guidance & more!

<a href="https://discord.gg/gbsG4CDsru">
  <img src="https://discordapp.com/api/guilds/1203608338344976434/widget.png?style=banner2" alt="Discord Banner 1"/>
</a>

You can also refer to the [Relink Modding Site](https://nenkai.github.io/relink-modding/).

