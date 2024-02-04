# GBFRDataTools

WIP Tool for Granblue Fantasy: Relink archives (data.i)

Features (still TODO):
* Extraction
  * Extracting singular files (if you know their paths and their hash matches)
  * All known files
* Modding
  * Adding files marked as external files (which means they can be outside `data.X` like files in the data folder)

A build will be made when the tool is considered stable enough.

## Research Notes

* Currently, `49544` of `280078` (17%) of game paths are known.
* It is possible to run the game fully unpacked by removing `data.i`, however all game files need to be extracted in a `data` folder - requires the majority of game paths mapped out which is not the case yet.
* `data.i` is fully understood and documented in [FlatArkIndexFile](https://github.com/Nenkai/GBFRDataTools/blob/master/GBFRDataTools/FlatArkIndexFile.cs).
* Data/Archive file #2 is hardcoded not to be read from.
* Some files uses the same type of header called flatark where a table of uint16 offsets points to a table of fields. Notably model info files/`.minfo`.

## Credits

* [WistfulHopes](https://github.com/WistfulHopes) - Research & File Paths
