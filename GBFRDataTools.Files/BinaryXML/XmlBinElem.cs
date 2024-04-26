using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.BinaryXML;

public class XmlBinElem
{
    public ushort NumChild { get; set; }
    public ushort IdxChild { get; set; }
    public ushort NumAttr { get; set; }
    public ushort IdxAttr { get; set; }
}
