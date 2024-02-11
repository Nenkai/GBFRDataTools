# GBFRDataTools

Data Tool for Granblue Fantasy: Relink archives (data.i)

Features:
* Extraction
  * Extracting singular files (if you know their paths and their hash matches)
  * All known files
* Modding
  * Adding files marked as external files (which means they can be outside `data.X` like files in the data folder)

For an early release build, [here](https://github.com/Nenkai/GBFRDataTools/releases).

## Research Notes

* Currently, `243321` of `280078` (86.8%) game paths are known.
* It is possible to run the game fully unpacked by removing `data.i`, however all game files need to be extracted in a `data` folder - requires the majority of game paths mapped out which is not the case yet.
* `data.i` among other file formats such as models uses FlatBuffers (Cy's internal handler is named FlatArk). It is fully understood and documented in [IndexFile.fbs](https://github.com/Nenkai/GBFRDataTools/blob/master/GBFRDataTools/Entities/IndexFile.fbs).
* Data/Archive file #2 is hardcoded not to be read from.

## Credits

* [WistfulHopes](https://github.com/WistfulHopes) - Research & File Paths
* [AlphaSatanOmega](https://github.com/AlphaSatanOmega), [SheItoon](https://github.com/SheItoon) - Path Finding

## Discord (EN)

Join the Relink Modding Discord For help, guidance & more!

<a href="https://discord.gg/gbsG4CDsru">
  <img src="https://discordapp.com/api/guilds/1203608338344976434/widget.png?style=banner2" alt="Discord Banner 1"/>
</a>

