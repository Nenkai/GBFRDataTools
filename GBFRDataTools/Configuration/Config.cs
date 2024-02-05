using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Configuration;

public class Config
{
    public const char Separator = '|';

    private Dictionary<string, string> _values = [];

    public const string DefaultURL = @"https://raw.githubusercontent.com/Nenkai/GBFRDataTools/master/GBFRDataTools/filelist.txt";

    public static Config GetDefault()
    {
        var conf = new Config();
        conf.AddOrUpdateParam("FileListURL", DefaultURL);
        conf.AddOrUpdateParam("FetchNewFileList", true.ToString());
        return conf;
    }

    public void AddOrUpdateParam(string key, string value)
    {
        if (_values.ContainsKey(key))
            _values[key] = value;
        else
            _values.Add(key, value);
    }

    public bool TryGetParam(string key, out string value)
    {
        return _values.TryGetValue(key, out value);
    }

    public bool TryGetParamBool(string key, out bool value)
    {
        value = false;
        return _values.TryGetValue(key, out string strValue) && bool.TryParse(strValue, out value);
    }

    public bool TryGetParamDateTime(string key, out DateTime value)
    {
        value = default;
        return _values.TryGetValue(key, out string strValue) && DateTime.TryParse(strValue, out value);
    }

    public string GetParamOrDefault(string key, string def)
    {
        if (!_values.TryGetValue(key, out string value))
            return def;

        return value;
    }

    public static Config Read(string file)
    {
        var conf = new Config();

        if (!File.Exists(file))
            throw new FileNotFoundException("Config file does not exist.");

        foreach (var line in File.ReadAllLines(file))
        {
            if (line.StartsWith('#') || line.StartsWith("//") || string.IsNullOrEmpty(line))
                continue;

            string[] spl = line.Split(Separator);
            if (spl.Length != 2)
                continue;

            conf.AddOrUpdateParam(spl[0], spl[1]);
        }

        return conf;
    }

    public void Write(string file)
    {
        using var sw = new StreamWriter(file);

        foreach (var param in _values)
        {
            sw.WriteLine($"{param.Key}{Separator}{param.Value}");
        }
    }
}
