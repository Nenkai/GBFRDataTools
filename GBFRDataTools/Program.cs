using System;
using System.Xml;
using System.Text;
using System.Text.Json;
using System.Reflection;

using RestSharp;

using YamlDotNet.RepresentationModel;

using CommandLine;

using GBFRDataTools.Archive;
using GBFRDataTools.Configuration;
using GBFRDataTools.Files.UI;
using GBFRDataTools.Files.BinaryXML;
using GBFRDataTools.Hashing;
using GBFRDataTools.Database;
using GBFRDataTools.FlatBuffers;
using GBFRDataTools.Files.Textures;
using GBFRDataTools.Files.UI.Types;
using GBFRDataTools.FSM;
using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Textures.TextureFormats;

using MessagePack;
using SixLabors.ImageSharp.Textures;

namespace GBFRDataTools;

internal class Program
{
    public static readonly Version Version = Assembly.GetEntryAssembly().GetName().Version;
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"- GBFRDataTools {Version} by Nenkai/WistfulHopes");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("- https://github.com/Nenkai");
        Console.WriteLine("- https://github.com/WistfulHopes");
        Console.WriteLine("---------------------------------------------");

        if (args.Length == 1 && File.Exists(args[0]))
        {
            string ext = Path.GetExtension(args[0]);
            if (IsUiBinaryFile(ext) || ext.EndsWith("yaml") || ext.EndsWith("wtb") || ext.EndsWith("texture") || ext.EndsWith("bxm") || ext.EndsWith("xml"))
            {
                BConvert(new BConvertVerbs() { Input = args[0] });
                return;
            }
        }
        else if (args.Length == 1 && Directory.Exists(args[0]))
        {
            // Bulk convert .texb
            foreach (var file in Directory.GetFiles(args[0], "*", SearchOption.AllDirectories))
            {
                string ext = Path.GetExtension(file);
                if (ext.EndsWith("texb"))
                {
                    BConvert(new BConvertVerbs() { Input = file });
                }
            }
        }

        var p = Parser.Default.ParseArguments<
            ExtractVerbs, 
            ExtractAllVerbs, 
            ListFilesVerbs, 
            AddExternalFilesVerbs, 
            BruteforceStringVerbs,
            HashStringVerbs,
            BConvertVerbs,
            SqliteToTblVerbs,
            TblToSqliteVerbs,
            TexToDdsVerbs,
            ImgToTexVerbs,
            BxmToXmlVerbs,
            XmlToBxmVerbs,
            MakeDebugFsmVerbs
            >(args);

        p.WithParsed<ExtractVerbs>(Extract)
         .WithParsed<ExtractAllVerbs>(ExtractAll)
         .WithParsed<ListFilesVerbs>(ListFiles)
         .WithParsed<AddExternalFilesVerbs>(AddExternalFiles)
         .WithParsed<BruteforceStringVerbs>(BruteforceStr)
         .WithParsed<BConvertVerbs>(BConvert)
         .WithParsed<HashStringVerbs>(HashString)
         .WithParsed<SqliteToTblVerbs>(SqliteToTbl)
         .WithParsed<TblToSqliteVerbs>(TblToSqlite)
         .WithParsed<TexToDdsVerbs>(TexToDds)
         .WithParsed<ImgToTexVerbs>(ImgToTex)
         .WithParsed<BxmToXmlVerbs>(BxmToXml)
         .WithParsed<XmlToBxmVerbs>(XmlToBxm)
         .WithParsed<MakeDebugFsmVerbs>(MakeDebugFsm)
         .WithNotParsed(HandleNotParsedArgs);
    }

    static void MakeDebugFsm(MakeDebugFsmVerbs verbs)
    {
        if (string.IsNullOrEmpty(verbs.Output))
            verbs.Output = Path.ChangeExtension(Path.GetFileNameWithoutExtension(verbs.Input) + "_debug", ".json");

        FSMParser parser = new FSMParser();
        byte[] bytes = File.ReadAllBytes(verbs.Input);
        parser.Parse(bytes, verbs.Input.EndsWith(".msg"));

        string json;
        if (verbs.Input.EndsWith(".msg"))
        {
            json = MessagePackSerializer.ConvertToJson(bytes);
        }
        else
            json = Encoding.UTF8.GetString(bytes);

        // System.Text.Json is not capable of parsing json with same keys
        // Newtonsoft.Json can, but then refuses to add nodes with same names.
        // Just.. Paste it directly in the json lmao.
        if (json.EndsWith("}"))
            json = json.Substring(0, json.Length - 1);

        json = json.Trim() + ',';

        for (int i = 0; i < parser.AllNodes.Count; i++)
        {
            FSM.Entities.FSMNode node = parser.AllNodes[i];
            if (node.ExecutionComponents.Count > 0)
            {
                DebugPrintAction debugPrintAction = new DebugPrintAction()
                {
                    ParentGuid = node.Guid,
                    Guid = (uint)Random.Shared.Next(),
                    SaveString = $"{string.Join(", ", node.ExecutionComponents.Select(e => e.ComponentName))}",
                };

                string str = JsonSerializer.Serialize(new Dictionary<string, object>() { [debugPrintAction.ComponentName] = debugPrintAction }, DefaultJsonSerializerOptions.InstanceForRead);
                string str2 = "  " + str.TrimStart('{').TrimEnd('}').TrimEnd() + ",\n";
                json += str2;
            }
        }

        json = json.TrimEnd().TrimEnd(',');
        json += "}";
        File.WriteAllText(verbs.Output, json);
    }

    private static bool IsUiBinaryFile(string ext)
    {
        switch (ext)
        {
            case ".listb":
            case ".texb":
            case ".viewb":
            case ".prfb":
            case ".matb":
            case ".langb":
            case ".animb":
            case ".imageb":
                return true;
        }

        return false;
    }

    public static void Extract(ExtractVerbs verbs)
    {
        GetLatestFileList();

        if (!File.Exists(verbs.InputPath))
        {
            Console.WriteLine($"ERROR: Index file '{verbs.InputPath}' does not exist.");
            return;
        }

        string inputDir = Path.GetDirectoryName(Path.GetFullPath(verbs.InputPath));
        if (string.IsNullOrEmpty(verbs.OutputPath))
            verbs.OutputPath = Path.Combine(inputDir, "data");
        else
            verbs.OutputPath = Path.GetFullPath(verbs.OutputPath);

        using var archive = new DataArchive();
        try
        {
            if (!archive.Init(verbs.InputPath))
                return;

            archive.ExtractFile(verbs.FileToExtract, verbs.OutputPath);

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
        GetLatestFileList();

        if (!File.Exists(verbs.InputPath))
        {
            Console.WriteLine($"ERROR: Index file '{verbs.InputPath}' does not exist.");
            return;
        }

        using var archive = new DataArchive();
        if (!archive.Init(verbs.InputPath))
            return;

        bool checkFilter = !string.IsNullOrEmpty(verbs.Filter);
        if (checkFilter)
            verbs.Filter = verbs.Filter.Replace('\\', '/');

        string inputDir = Path.GetDirectoryName(Path.GetFullPath(verbs.InputPath));

        if (string.IsNullOrEmpty(verbs.OutputPath))
            verbs.OutputPath = Path.Combine(inputDir, "data");
        else
            verbs.OutputPath = Path.GetFullPath(verbs.OutputPath);

        if (!verbs.ExtractUnknown)
        {
            Console.WriteLine($"NOTE: Only {archive.ArchiveFilesHashTable.Count} known files out of {archive.Index.ArchiveFileHashes.Count} will be extracted.");

            int i = 0;
            foreach (KeyValuePair<string, int> file in archive.ArchiveFilesHashTable)
            {
                try
                {
                    if (checkFilter && !file.Key.Contains(verbs.Filter))
                    {
                        i++;
                        continue;
                    }

                    Console.WriteLine($"[{i + 1}/{archive.ArchiveFilesHashTable.Count}] Extracting: {file.Key}");
                    i++;

                    if (!verbs.Overwrite && File.Exists(Path.Combine(verbs.OutputPath, file.Key)))
                    {
                        Console.WriteLine($"Skipping: {file.Key} - already extracted");
                        continue;
                    }

                    archive.ExtractFile(file.Key, verbs.OutputPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: Failed to extract {file.Key} - {e.Message}");
                }
            }

            Console.WriteLine("Extracting all done.");
        }
        else
        {
            for (int i = 0;  i < archive.Index.ArchiveFileHashes.Count; i++)
            {
                if (archive.HashToArchiveFile.ContainsKey(archive.Index.ArchiveFileHashes[i]))
                    continue;

                Console.WriteLine($"Extracting unknown: {archive.Index.ArchiveFileHashes[i]:X16}");
                archive.ExtractFile(archive.Index.ArchiveFileHashes[i], verbs.OutputPath);
            }
        }
    }

    public static void ListFiles(ListFilesVerbs verbs)
    {
        GetLatestFileList();

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
        GetLatestFileList();

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

    public static void BruteforceStr(BruteforceStringVerbs verbs)
    {
        uint hash = uint.Parse(verbs.Hash, System.Globalization.NumberStyles.HexNumber);

        int maxlength = verbs.Length;
        if (maxlength >= 6)
            Console.WriteLine(">= 6 length can take a very long while!");

        string ValidChars = "";
        for (int i = 32; i <= 90; i++)
            ValidChars += (char)i;

        string match = Dive("", 0);
        if (!string.IsNullOrEmpty(match))
        {
            Console.WriteLine($"Found: {match}");
        }
        else
        {
            Console.WriteLine("Not found.");
        }

        string Dive(string prefix, int level)
        {
            if (level == 1 || level == 2)
                Console.WriteLine($"Current prefix: {prefix}..");

            level += 1;
            foreach (char c in ValidChars)
            {
                string str = prefix + c;
                if (hash == XXHash32Custom.Hash(str))
                {
                    Console.WriteLine($"Matched: {str}, is this correct? [y/n]");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Done");
                        return str;
                    }
                }

                if (level < maxlength)
                {
                    string s = Dive(prefix + c, level);
                    if (s != null)
                        return s;
                }
            }

            return null;
        }
    }

    public static void HashString(HashStringVerbs verbs)
    {
        uint hash = XXHash32Custom.Hash(verbs.Str);
        Console.WriteLine($"'{verbs.Str}' -> 0x{hash:X8}");
    }

    public static void BConvert(BConvertVerbs verbs)
    {
        try
        {
            string ext = Path.GetExtension(verbs.Input);
            if (IsUiBinaryFile(ext))
            {
                var fs = File.OpenRead(verbs.Input);
                var bulk = new BulkReader(fs);
                var root = bulk.ReadRootObject();
                bulk.ResolveHashReferencesRecursive(root);

                // TODO: Assign root name
                string rootName = ext switch
                {
                    ".listb" => "AssetList",
                    ".prfb" => "Prefab",
                    ".langb" => "LanguageData",
                    ".viewb" => "View",
                    ".texb" => "Texture",
                    ".matb" => "Material",
                    ".animb" => "Animation",
                    ".imageb" => "ImageData",
                    _ => throw new ArgumentException()
                };

                var yamlStream = new YamlStream();
                var props = new YamlMappingNode();

                foreach (var prop in root.Children.Values)
                {
                    var n = prop.GetYamlNode();
                    props.Add(prop.Name, n);
                }

                if (string.IsNullOrEmpty(verbs.Output))
                    verbs.Output = Path.ChangeExtension(verbs.Input, ".yaml");

                using var writer = File.CreateText(verbs.Output);
                var doc = new YamlDocument(props);
                yamlStream.Add(doc);
                yamlStream.Save(writer, false);

                Console.WriteLine($"Converted '{verbs.Input}' to .yaml.");

                if (ext.Equals(".texb"))
                {
                    string fileName = verbs.Input.Replace(".tex.texb", string.Empty);
                    string wtb = fileName + ".wtb";
                    if (File.Exists(wtb))
                    {
                        Console.WriteLine($"Processing .wtb file.");

                        var textureBin = TextureBin.FromFile(wtb);
                        var texture = textureBin.GetByIndex(0);
                        byte[] dds = texture.GetData();
                        var six = SixLabors.ImageSharp.Textures.Texture.Load(dds);
                        var flat = six as FlatTexture;
                        var mip = flat.MipMaps[0];
                        using var img = mip.GetImage();

                        Directory.CreateDirectory(fileName);

                        UIObjectArray sprites = root["Sprites"] as UIObjectArray;
                        foreach (UIObject sprite in sprites.Array)
                        {
                            UIString name = sprite["Name"] as UIString;
                            UIVec4 uv = sprite["Uv"] as UIVec4;

                            // v is flipped.
                            int x1 = (int)(img.Width * uv.Vector.X);
                            int y1 = img.Height - (int)(img.Height * uv.Vector.Y);
                            int x2 = (int)(img.Width * uv.Vector.Z);
                            int y2 = img.Height - (int)(img.Height * uv.Vector.W);
                            (y2, y1) = (y1, y2);

                            Console.WriteLine($"-> {name.Value} (0x{XXHash32Custom.Hash(name.Value):X8}) @ {x1},{y1} ({x2-x1}x{y2-y1})");

                            var newImg = img.Clone(e => e.Crop(new Rectangle(x1, y1, x2 - x1, y2 - y1)));
                            newImg.SaveAsPng(Path.Combine(fileName, name.Value + ".png"));
                        }
                    }
                }
            }
            else if (ext == ".yaml")
            {
                using var txt = File.OpenText(verbs.Input);

                var yamlStream = new YamlStream();
                yamlStream.Load(txt);

                var bulkWriter = new BulkWriter();

                if (string.IsNullOrEmpty(verbs.Output))
                    verbs.Output = Path.ChangeExtension(verbs.Input, ".xxxb");

                bulkWriter.Write(verbs.Output, yamlStream.Documents[0].RootNode);

                Console.WriteLine($"Converted to {verbs.Output}.");
            }
            else if (ext == ".bxm")
            {
                ConvertBxmToXml(verbs.Input, verbs.Output);
            }
            else if (ext == ".xml")
            {
                ConvertXmlToBxm(verbs.Input, verbs.Output);
            }
            else if (ext == ".wtb" || ext == ".texture")
            {
                ConvertWTextureBinToDds(verbs.Input, verbs.Output);
            }
            else
                Console.WriteLine("ERROR: Unrecognized file extension.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: {e.Message}");
        }
    }

    public static void TblToSqlite(TblToSqliteVerbs verbs)
    {
        if (!Directory.Exists(verbs.Input))
        {
            Console.WriteLine($"ERROR: Folder '{verbs.Input}' containing tables does not exist.");
            return;
        }

        if (!System.Version.TryParse(verbs.Version, out Version version))
        {
            Console.WriteLine($"ERROR: Invalid version input string '{verbs.Version}'. Example: 1.0.0");
            return;
        }

        var db = new GameDatabase();
        db.Load(verbs.Input, version);

        if (string.IsNullOrEmpty(verbs.Output))
            verbs.Output = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(verbs.Input)), "db.sqlite");

        Console.WriteLine($"Converting '{verbs.Input}' to sqlite..");

        using var exporter = new SQLiteExporter(db);
        string idsFile = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(verbs.Input)), "ids.txt");
        exporter.ExportTables(verbs.Output);
        Console.WriteLine("Done.");
    }

    public static void SqliteToTbl(SqliteToTblVerbs verbs)
    {
        if (File.Exists(verbs.Output))
        {
            Console.WriteLine($"ERROR: Output '{verbs.Input}' is a file, not a directory.");
            return;
        }

        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(verbs.Output)));

        if (!System.Version.TryParse(verbs.Version, out Version version))
        {
            Console.WriteLine($"ERROR: Invalid version input string '{verbs.Version}'. Example: 1.0.0");
            return;
        }

        using var importer = new SQLiteImporter(verbs.Input);
        GameDatabase gameDb = importer.Import(version);
        gameDb.SaveTo(verbs.Output);

        Console.WriteLine("Creating ids.txt with hash strings..");
        using var sw = new StreamWriter(Path.Combine(verbs.Output, "ids.txt"));
        sw.WriteLine("// Generated by GBFRDataTools.");
        sw.WriteLine("// Do not delete this. It is required to load known key/hash strings.");
        foreach (var hashString in importer.HashStrings)
            sw.WriteLine($"{hashString.Key:X8}|ID|{hashString.Value}");

        Console.WriteLine("Done.");
    }

    public static void TexToDds(TexToDdsVerbs verbs)
    {
        if (Directory.Exists(verbs.Input))
        {
            foreach (var file in Directory.GetFiles(verbs.Input, "*", SearchOption.AllDirectories))
                ConvertWTextureBinToDds(file, verbs.Output);
        }
        else if (File.Exists(verbs.Input))
        {
            ConvertWTextureBinToDds(verbs.Input, verbs.Output);
        }
        else
        {
            Console.WriteLine($"ERROR: {verbs.Input} does not exist");
        }
    }

    public static void ImgToTex(ImgToTexVerbs verbs)
    {
        TextureBuilder builder = new TextureBuilder();

        try
        {
            if (Directory.Exists(verbs.Input))
            {
                foreach (var file in Directory.GetFiles(verbs.Input))
                {
                    Console.WriteLine($"Adding image file: {file}");
                    builder.AddImage(Path.GetFileNameWithoutExtension(file), file);
                }
            }
            else if (File.Exists(verbs.Input))
            {
                Console.WriteLine($"Adding image file: {verbs.Input}");
                builder.AddImage(Path.GetFileNameWithoutExtension(verbs.Input), verbs.Input);
            }
            else
            {
                Console.WriteLine($"ERROR: {verbs.Input} does not exist");
                return;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: Failed to add image: {e.Message}");
            return;
        }

        Console.WriteLine($"Building texture binary ({builder.Textures.Count} texture(s))");

        var bin = builder.Build();

        if (string.IsNullOrWhiteSpace(verbs.Output))
            verbs.Output = Path.ChangeExtension(verbs.Input, ".wtb");

        using var fs = File.Create(verbs.Output);
        bin.Write(fs);

        Console.WriteLine($"Texture binary built.");
    }

    public static void BxmToXml(BxmToXmlVerbs verbs)
    {
        if (Directory.Exists(verbs.Input))
        {
            foreach (var file in Directory.GetFiles(verbs.Input, "*", SearchOption.AllDirectories))
                ConvertBxmToXml(file, verbs.Output);
        }
        else if (File.Exists(verbs.Input))
        {
            ConvertBxmToXml(verbs.Input, verbs.Output);
        }
        else
        {
            Console.WriteLine($"ERROR: {verbs.Input} does not exist");
        }
    }

    public static void XmlToBxm(XmlToBxmVerbs verbs)
    {
        if (Directory.Exists(verbs.Input))
        {
            foreach (var file in Directory.GetFiles(verbs.Input))
                ConvertXmlToBxm(file, verbs.Output);
        }
        else if (File.Exists(verbs.Input))
        {
            ConvertXmlToBxm(verbs.Input, verbs.Output);
        }
        else
        {
            Console.WriteLine($"ERROR: {verbs.Input} does not exist");
        }
    }

    private static void ConvertWTextureBinToDds(string input, string output)
    {
        string ext = Path.GetExtension(input);
        if (ext != ".tex" && ext != ".wtb" && ext != ".texture")
        {
            Console.WriteLine($"Skipping {input} - extension is not tex/wtb/texture");
            return;
        }

        try
        {
            var texBin = TextureBin.FromFile(input);
            int numTextures = texBin.GetNumTextures();

            Console.WriteLine($"Converting {input} ({texBin.GetNumTextures()} textures)");

            for (int i = 0; i < numTextures; i++)
            {
                Files.Textures.Texture tex = texBin.GetByIndex(i);
                byte[] dds = tex.GetData();

                if (numTextures == 1)
                {
                    if (string.IsNullOrEmpty(output))
                        output = Path.ChangeExtension(input, ".dds");
                }
                else
                {
                    if (string.IsNullOrEmpty(output))
                        output = Path.ChangeExtension(input + $"_{i}", ".dds");
                    else
                        output = Path.ChangeExtension(input, $".{i}.dds");
                }

                File.WriteAllBytes(output, dds);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to convert {input} - {e}");
        }
    }

    private static void ConvertBxmToXml(string input, string output)
    {
        string ext = Path.GetExtension(input);
        if (ext != ".bxm")
        {
            Console.WriteLine($"Skipping {input} - extension is not bxm");
            return;
        }

        try
        {
            using var fs = File.Open(input, FileMode.Open);
            if (string.IsNullOrEmpty(output))
                output = Path.ChangeExtension(input, ".xml");

            var doc = XmlBin.Read(fs);
            doc.Save(output);

            Console.WriteLine($"Converted to {output}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to convert {input} - {e}");
        }
    }

    private static void ConvertXmlToBxm(string input, string output)
    {
        string ext = Path.GetExtension(input);
        if (ext != ".xml")
        {
            Console.WriteLine($"Skipping {input} - extension is not xml");
            return;
        }

        try
        {
            if (string.IsNullOrEmpty(output))
                output = Path.ChangeExtension(input, ".bxm");

            XmlDocument doc = new XmlDocument();
            doc.Load(input);

            using var outputStream = File.OpenWrite(output);
            XmlBin.Write(outputStream, doc);

            Console.WriteLine($"Converted to {output}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to convert {input} - {e}");
        }
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

        if (string.IsNullOrEmpty(etag) || !config.TryGetParam("LastETag", out string confEtag) || etag != confEtag)
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

    [Option('o', "output", Required = false, HelpText = "Output directory for the file. Defaults to data folder next to data.i.")]
    public string OutputPath { get; set; }

    [Option('f', "file", Required = true, HelpText = "File from the archive to extract.")]
    public string FileToExtract { get; set; }
}

[Verb("extract-all", HelpText = "Extract files from a data.i archive.")]
public class ExtractAllVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input data.i file.")]
    public string InputPath { get; set; }

    [Option('o', "output", Required = false, HelpText = "Output directory for files. Defaults to data folder next to data.i.")]
    public string OutputPath { get; set; }

    [Option('u', "extract-unknown", Required = false, HelpText = "Whether to extract unknown files.")]
    public bool ExtractUnknown { get; set; }

    [Option('f', "filter", Required = false, HelpText = "Filter. Only paths starting with the specified filter will be extracted.")]
    public string Filter { get; set; }

    [Option("overwrite", Required = false, HelpText = "Whether to overwrite if files have already been extracted.")]
    public bool Overwrite { get; set; }
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

[Verb("bruteforce-string", HelpText = "Advanced users only. Try to bruteforce a string hash.")]
public class BruteforceStringVerbs
{
    [Option('h', "hash", Required = true, HelpText = "Hash integer i.e 3FA67E6D.")]
    public string Hash { get; set; }

    [Option('l', "length", Required = true, HelpText = "Max string length.")]
    public int Length { get; set; }
}

[Verb("hash-string", HelpText = "Advanced users only. Hash a string to XXHash32 custom.")]
public class HashStringVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input string.")]
    public string Str { get; set; }
}

[Verb("b-convert", HelpText = "Converts .xxxb <-> yaml.")]
public class BConvertVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input file.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output file.")]
    public string Output { get; set; }
}

[Verb("tbl-to-sqlite", HelpText = "Converts a folder containing .tbl files to a SQLite database.")]
public class TblToSqliteVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input folder containing .tbl files.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output SQLite database file.")]
    public string Output { get; set; }

    [Option('v', "version", Required = true, HelpText = "Game version. Example: 1.0.5")]
    public string Version { get; set; }
}

[Verb("sqlite-to-tbl", HelpText = "Converts a SQLite database to .tbl files.")]
public class SqliteToTblVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input SQLite database file.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output folder for .tbl files.")]
    public string Output { get; set; }

    [Option('v', "version", Required = true, HelpText = "Game version. Example: 1.0.5")]
    public string Version { get; set; }
}

[Verb("tex-to-dds", HelpText = "Converts .tex files (PlatinumGames .wtb/.texture) to .dds.")]
public class TexToDdsVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input file or folder.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output folder for .dds files.")]
    public string Output { get; set; }
}

[Verb("img-to-tex", HelpText = "Converts images files to PlatinumGames .wtb/.tex")]
public class ImgToTexVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input file or folder.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output .wtb file.")]
    public string Output { get; set; }
}

[Verb("bxm-to-xml", HelpText = "Converts .bxm files to .xml.")]
public class BxmToXmlVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input file or folder.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output folder for .xml files.")]
    public string Output { get; set; }
}

[Verb("xml-to-bxm", HelpText = "Converts .xml files to .bxm.")]
public class XmlToBxmVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input file or folder.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output folder for .bxm files.")]
    public string Output { get; set; }
}

[Verb("make-debug-fsm", HelpText = "Adds DebugPrintAction to all nodes in a FSM.")]
public class MakeDebugFsmVerbs
{
    [Option('i', "input", Required = true, HelpText = "Input fsm msg or json file.")]
    public string Input { get; set; }

    [Option('o', "output", HelpText = "Output json file.")]
    public string Output { get; set; }
}