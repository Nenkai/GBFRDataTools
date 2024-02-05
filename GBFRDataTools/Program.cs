using CommandLine;
using GBFRDataTools.Archive;
using GBFRDataTools.FlatArk;
using GBFRDataTools.Configuration;

using RestSharp;

namespace GBFRDataTools;

internal class Program
{
    public const string Version = "0.1.0";

    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"- GBFRDataTools {Version} by Nenkai/WistfulHopes");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("- https://github.com/Nenkai");
        Console.WriteLine("- https://github.com/WistfulHopes");
        Console.WriteLine("---------------------------------------------");

        GetLatestFileList();

        var p = Parser.Default.ParseArguments<ExtractVerbs, ExtractAllVerbs, ListFilesVerbs, AddExternalFilesVerbs>(args);

        p.WithParsed<ExtractVerbs>(Extract)
         .WithParsed<ExtractAllVerbs>(ExtractAll)
         .WithParsed<ListFilesVerbs>(ListFiles)
         .WithParsed<AddExternalFilesVerbs>(AddExternalFiles)
         .WithNotParsed(HandleNotParsedArgs);

    }

    public static void Extract(ExtractVerbs verbs)
    {

        if (!File.Exists(verbs.InputPath))
        {
            Console.WriteLine($"ERROR: Index file '{verbs.InputPath}' does not exist.");
            return;
        }

        using var archive = new DataArchive();
        try
        {
            if (!archive.Init(verbs.InputPath))
                return;

            archive.ExtractFile(verbs.FileToExtract);

            Console.WriteLine("Done.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: Failed to extract {verbs.FileToExtract} - {ex.Message}");
            return;
        }
    }


    public static void ExtractAll(ExtractAllVerbs verbs)
    {
        if (!File.Exists(verbs.InputPath))
        {
            Console.WriteLine($"ERROR: Index file '{verbs.InputPath}' does not exist.");
            return;
        }

        using var archive = new DataArchive();
        if (!archive.Init(verbs.InputPath))
            return;

        if (!verbs.ExtractUnknown)
        {
            Console.WriteLine($"NOTE: Only {archive.ArchiveFilesHashTable.Count} known files out of {archive.Index.ArchiveFilesHashTable.Count} will be extracted.");
            foreach (var f in archive.ArchiveFilesHashTable)
            {
                try
                {
                    archive.ExtractFile(f.Key);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: Failed to extract {f.Key} - {e.Message}");
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
        if (!File.Exists(verbs.InputPath))
        {
            Console.WriteLine($"ERROR: Index file '{verbs.InputPath}' does not exist.");
            return;
        }

        using var archive = new DataArchive();
        if (!archive.Init(verbs.InputPath))
            return;

        archive.DebugList();
        Console.WriteLine("Listing files done.");
    }

    public static void AddExternalFiles(AddExternalFilesVerbs verbs)
    {
        if (!File.Exists(verbs.InputPath))
        {
            Console.WriteLine($"ERROR: Index file '{verbs.InputPath}' does not exist.");
            return;
        }

        string dir = Path.GetDirectoryName(Path.GetFullPath(verbs.InputPath));
        string dataDir = Path.Combine(dir, "data");

        if (!Directory.Exists(dataDir))
        {
            Console.WriteLine($"ERROR: Data game directory does not exist next to data.i.");
            return;
        }

        using var archive = new DataArchive();
        if (!archive.Init(verbs.InputPath))
            return;

        archive.AddExternalFiles(dataDir);

        string output = verbs.OutputFile;
        if (string.IsNullOrWhiteSpace(verbs.OutputFile))
            output = verbs.InputPath;

        if (!verbs.Overwrite)
        {
            if (verbs.InputPath.Equals(output))
            {
                Console.Write("Overwrite data.i? Make sure you have a backup of the original. [y/n]");
                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aborted.");
                    return;
                }
                Console.WriteLine();
            }
        }

        archive.SaveIndex(output);
        Console.WriteLine($"Done. Saved new index as {output}.");
    }

    public static void HandleNotParsedArgs(IEnumerable<Error> errors)
    {

    }

    /// <summary>
    /// Downloads the new file list (and updates the config if successful)
    /// </summary>
    public static void GetLatestFileList()
    {
        Config config;
        string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");
        string fileListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "filelist.txt");

        if (!File.Exists(configPath))
        {
            Console.WriteLine($"WARN: Config file is missing at '{configPath}', creating default");
            config = Config.GetDefault();
            try
            {
                config.Write(configPath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Failed to write default config file? {e.Message}");
            }
        }
        else
        {
            try
            {
                config = Config.Read(configPath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Failed to parse config file at '{configPath}'");
                config = Config.GetDefault();
            }
        }

        if (File.Exists(fileListPath)) // We should force download if the file list doesn't exist
        {
            if (!config.TryGetParamBool("FetchNewFileList", out bool shouldFetch) || !shouldFetch)
                return;

            if (config.TryGetParamDateTime("LastFetched", out DateTime dateTime))
            {
                if (DateTime.UtcNow - dateTime <= TimeSpan.FromMinutes(10)) // 10 minutes before trying again
                    return;
            }
        }
        else
            Console.WriteLine("WARN: filelist.txt is missing, it'll be forcefully downloaded");

        var baseUrl = config.GetParamOrDefault("FileListURL", Config.DefaultURL);
        var client = new RestClient(baseUrl);
        var request = new RestRequest();

        string etag = string.Empty;
        try
        {
            var response = client.Head(request);
            HeaderParameter etagParam = response.Headers.FirstOrDefault(e => e.Name == "ETag") ?? throw new Exception("ETag not found in header response.");
            etag = (string)etagParam.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: Failed to fetch file online file list - {e.Message}");
            return;
        }

        if (!string.IsNullOrEmpty(etag) && (config.TryGetParam("LastETag", out string confEtag) || etag != confEtag))
        {
            Console.WriteLine("Downloading new online file list..");

            try
            {
                Console.WriteLine("Downloading new file list..");
                var response = client.Get(request);
                File.WriteAllBytes(fileListPath, response.RawBytes);
                Console.WriteLine("New file list successfully downloaded.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Failed to fetch file online file list - {e.Message}");
                return;
            }

            config.AddOrUpdateParam("LastETag", etag);
        }

        config.AddOrUpdateParam("LastFetched", DateTime.UtcNow.ToString());

        try
        {
            config.Write(configPath);
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: Failed to write config - {e.Message}");
            return;
        }

        Console.WriteLine();
    }
}

[Verb("extract", HelpText = "Extract files from a data.i archive.")]
public class ExtractVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
    public string InputPath { get; set; }

    [Option('f', "file", Required = true, HelpText = "File from the archive to extract.")]
    public string FileToExtract { get; set; }
}

[Verb("extract-all", HelpText = "Extract all files from a data.i archive.")]
public class ExtractAllVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
    public string InputPath { get; set; }

    [Option('u', "extract-unknown", Required = false, HelpText = "Whether to also extract unknown files (TODO).")]
    public bool ExtractUnknown { get; set; }
}

[Verb("list-files", HelpText = "List files from data.i archive. Lists will be output to a 'debug' folder.")]
public class ListFilesVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
    public string InputPath { get; set; }
}

[Verb("add-external-files", HelpText = "Scans the data/ folder and registers them to data.i to allow more files to be modded.")]
public class AddExternalFilesVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input data.i file. The data/ folder must be present next to it.")]
    public string InputPath { get; set; }

    [Option('o', "output", HelpText = "Output data.i file. If not provided, input will be overwritten.")]
    public string OutputFile { get; set; }

    [Option("overwrite", HelpText = "Whether to overwrite anyway when normally prompted.")]
    public bool Overwrite { get; set; }
}