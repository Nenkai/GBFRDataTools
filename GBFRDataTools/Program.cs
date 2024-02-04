using CommandLine;

namespace GBFRDataTools;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"- GBFRDataTools by Nenkai/WistfulHopes");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("- https://github.com/Nenkai");
        Console.WriteLine("- https://github.com/WistfulHopes");
        Console.WriteLine("-----------------------------------------");

        var p = Parser.Default.ParseArguments<ExtractVerbs, ExtractAllVerbs, ListFilesVerbs, AddExternalFilesVerbs>(args);

        p.WithParsed<ExtractVerbs>(Extract)
         .WithParsed<ExtractAllVerbs>(ExtractAll)
         .WithParsed<ListFilesVerbs>(ListFiles)
         .WithParsed<AddExternalFilesVerbs>(AddExternalFiles)
         .WithNotParsed(HandleNotParsedArgs);

    }

    public static void Extract(ExtractVerbs verbs)
    {
        using var flatark = new FlatArk();

        try
        {
            flatark.Init(verbs.InputPath);
            flatark.ExtractFile(verbs.FileToExtract);

            Console.WriteLine("Done.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to extract {verbs.FileToExtract} - {ex.Message}");
            return;
        }
    }


    public static void ExtractAll(ExtractAllVerbs verbs)
    {
        using var flatark = new FlatArk();
        flatark.Init(verbs.InputPath);

        if (!verbs.ExtractUnknown)
        {
            Console.WriteLine($"Note: Only {flatark.ArchiveFilesHashTable.Count} known files out of {flatark.Index.ArchiveFilesHashTable.Count} will be extracted.");
            foreach (var f in flatark.ArchiveFilesHashTable)
            {
                try
                {
                    flatark.ExtractFile(f.Key);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to extract {f.Key} - {e.Message}");
                }
            }

            Console.WriteLine("Extracting all done.");
        }
        else
        {

        }
    }

    public static void ListFiles(ListFilesVerbs verbs)
    {
        using var flatark = new FlatArk();
        flatark.Init(verbs.InputPath);
        flatark.DebugList();
        Console.WriteLine("Listing files done.");
    }

    public static void AddExternalFiles(AddExternalFilesVerbs verbs)
    {
        using var flatark = new FlatArk();
        flatark.Init(verbs.InputPath);
        flatark.AddExternalFiles(verbs.Folder);

        string output = verbs.OutputFile;
        if (string.IsNullOrWhiteSpace(verbs.OutputFile))
            output = verbs.InputPath;

        if (verbs.InputPath.Equals(output))
        {
            Console.WriteLine("Overwrite data.i? [y/n]");
            if (Console.ReadKey().Key != ConsoleKey.Y)
            {
                Console.WriteLine("Aborted.");
                return;
            }
        }

        flatark.SaveIndex(output);
        Console.WriteLine($"Done. Saved new index as {output}.");
    }

    public static void HandleNotParsedArgs(IEnumerable<Error> errors)
    {

    }

    [Verb("extract", HelpText = "Extract files from a flatark (data.i) archive.")]
    public class ExtractVerbs
    {
        [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
        public string InputPath { get; set; }

        [Option('f', "file", Required = true, HelpText = "File from the archive to extract.")]
        public string FileToExtract { get; set; }
    }

    [Verb("extract-all", HelpText = "Extract all files from a flatark (data.i) archive.")]
    public class ExtractAllVerbs
    {
        [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
        public string InputPath { get; set; }

        [Option('u', "extract-unknown", Required = false, HelpText = "Whether to also extract unknown files.")]
        public bool ExtractUnknown { get; set; }
    }

    [Verb("list-files", HelpText = "List files from a flatark (data.i) archive. Lists will be output to a 'debug' folder.")]
    public class ListFilesVerbs
    {
        [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
        public string InputPath { get; set; }
    }

    [Verb("add-external-files", HelpText = "Adds external files to the data.i file to allow editing files from outside it for modding.")]
    public class AddExternalFilesVerbs
    {
        [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
        public string InputPath { get; set; }

        [Option('f', "folder", Required = true, HelpText = "Folder with files to register as external files in the data.i file.")]
        public string Folder { get; set; }

        [Option('o', "output", HelpText = "Output data.i file. If not provided, input will be overwritten.")]
        public string OutputFile { get; set; }
    }
}
