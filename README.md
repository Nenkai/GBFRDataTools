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

It is possible to run the game fully unpacked by removing `data.i`, however all game files need to be extracted in a `data` folder - requires the majority of game paths mapped out which is not the case yet.

Currently, `49544` of `280078` (17%) of game paths are known.

## Credits

* [WistfulHopes](https://github.com/WistfulHopes) - Research & File Paths
