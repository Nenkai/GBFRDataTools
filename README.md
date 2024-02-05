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

* Currently, `51943` of `280078` (18.5%) of game paths are known.
* It is possible to run the game fully unpacked by removing `data.i`, however all game files need to be extracted in a `data` folder - requires the majority of game paths mapped out which is not the case yet.
* `data.i` is fully understood and documented in [IndexFile.cs](https://github.com/Nenkai/GBFRDataTools/blob/master/GBFRDataTools/Archive/IndexFile.cs).
* Data/Archive file #2 is hardcoded not to be read from.
* Some files uses the same type of header called flatark where a table of uint16 offsets points to a table of fields. Notably model info files/`.minfo`.

## Credits

* [WistfulHopes](https://github.com/WistfulHopes) - Research & File Paths
