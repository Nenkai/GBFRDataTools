using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.BinaryXML;

public class XmlBinAttr16
{
    public ushort KeyOffset { get; set; }
    public ushort ValueOffset { get; set; }

    public string Key { get; set; }
    public string Value { get; set; }
}