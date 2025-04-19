using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

public static class Utils
{
    public static string GetEnumDescription(Enum value)
    {
        if (value == null)
            return string.Empty;

        var type = value.GetType();
        var field = type.GetField(value.ToString());
        var custAttr = field?.GetCustomAttributes(typeof(DescriptionAttribute), false);
        DescriptionAttribute attribute = custAttr?.SingleOrDefault() as DescriptionAttribute;
        return attribute == null ? value.ToString() : attribute.Description;
    }
}
