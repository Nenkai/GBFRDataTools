using CommandLine;

namespace GBFRDataTools;

internal class Program
{
    static void Main(string[] args)
    {
        var p = Parser.Default.ParseArguments<ExtractVerbs>(args);

        p.WithParsed<ExtractVerbs>(Extract)
          .WithNotParsed(HandleNotParsedArgs);

    }

    public static void Extract(ExtractVerbs verbs)
    {
        var flatark = new FlatArk();
        flatark.Open(verbs.InputPath);
    }

    public static void HandleNotParsedArgs(IEnumerable<Error> errors)
    {

    }

    [Verb("extract", HelpText = "Extract files from a flatark (data.i) archive.")]
    public class ExtractVerbs
    {
        [Option('i', "input", Required = true, HelpText = "Input file.")]
        public string InputPath { get; set; }
    }
}
