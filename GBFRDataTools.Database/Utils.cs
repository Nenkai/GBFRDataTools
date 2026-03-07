using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Database;

public class Utils
{
    public static string GetCurrentExecutingPath()
    {
        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        if (string.IsNullOrEmpty(assemblyLocation)) // This may be empty if we compiled the executable as single-file.
            assemblyLocation = Environment.GetCommandLineArgs()[0]!;

        return assemblyLocation;
    }
}
