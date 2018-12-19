using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

/*
 * iniファイルを読み込むためのメソッド
 */

namespace MediaConverter
{
    class IniFile
    {
        [DllImport("kernel32.dll")]
        public static extern uint GetPrivateProfileString(
        string lpAppName, string lpKeyName, string lpDefault,
        StringBuilder lpReturnedString, uint nSize, string lpFileName);

        private readonly StringBuilder _builder = new StringBuilder(255);
        public string FullName { get; set; }

        public IniFile(string filePath)
        {
            FullName = Path.GetFullPath(filePath);
        }

        public string Read(string section, string key, string defaultValue = null)
        {
            _builder.Clear();
            GetPrivateProfileString(section, key, defaultValue, _builder, 255, FullName);
            return _builder.ToString();
        }
    }

    class HandmadeIniFile
    {
        private class SectionData
        {
            public String SectionName;
            public Dictionary<String, String> Values;

            public SectionData()
            {
                SectionName = "";
                Values = new Dictionary<string, string>();
            }

            public override string ToString()
            {
                String str = "";

                str += "Section: " + SectionName + "\n";
                foreach(var v in Values)
                {
                    str += v.Key + " : " + v.Value + "\n";
                }
                return str;
            }
        }

        private List<SectionData> Sections;

        public HandmadeIniFile(String FileName)
        {
            if (!File.Exists(FileName))
            {
                //存在しないファイルが指定されたら例外を投げる
                System.Diagnostics.Debug.WriteLine("Unknown File.");
                throw new FileNotFoundException();
            }

            Sections = new List<SectionData>();

            using (StreamReader r = new StreamReader(FileName))
            {
                //1行ずつ
                String line;
                int linec = 1;
                while ((line = r.ReadLine()) != null)
                {
                    if(line.Length >= 3)
                    {
                        //System.Diagnostics.Debug.Write(line[0].ToString() + line.Last().ToString() + "\n");
                        if(line[0] == '[' && line.Last() == ']')
                        {
                            String sectionName = line.Substring(1, line.Length - 2);
                            System.Diagnostics.Debug.WriteLine(sectionName);

                            Sections.Add(new SectionData() { SectionName = sectionName });
                        }
                        else if(line[0] != ';')
                        {
                            Match m = Regex.Match(line, "(?<key>.*?)=(?<value>.*)");
                            String Key = m.Groups["key"].ToString(), Value = m.Groups["value"].ToString();
                            if(Key.Length > 0 && Value.Length > 0)
                            {
                                Sections.Last().Values.Add(Key, Value);
                            }
                            else
                            {
                                System.Diagnostics.Debug.WriteLine("Wrong Data : L" + linec.ToString());
                            }
                        }
                    }
                    linec++;
                }
            }

            foreach(var v in Sections)
            {
                System.Diagnostics.Debug.WriteLine(v.ToString());
            }
            
        }

        public String Read(string section, string key, string defaultValue = null)
        {
            String Value = "";

            if(Sections.Exists(p => p.SectionName == section))
            {
                if(Sections.Find(p => p.SectionName == section).Values.ContainsKey(key))
                {
                    Value = Sections.Find(p => p.SectionName == section).Values[key];
                }
            }

            return Value;
        }
    }

}
