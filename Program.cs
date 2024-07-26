using System.Xml;
// 代码写的有点史，不过能运行就好啦
namespace PhigrosCrossPlatformDataMigrator
{
    internal class Program
    {
        internal static void Main()
        {
            string Android = "com.PigeonGames.Phigros.v2.playerprefs.xml";
            string IOS = "games.Pigeon.Phigros.plist";
            Console.Title = "Phigros跨系统存档迁移器";
            Console.WriteLine($"欢迎使用Phigros跨系统存档迁移器 - 由SweelLong开发\n请在https://github.com/SweelLong/PhigrosCrossPlatformDataMigrator查看使用教程哦！\n安卓文件：{Android}\n苹果文件：{IOS}");
            Console.WriteLine("请选择迁移模式：\n输入【1】安卓 -> 苹果\n输入【2】苹果 -> 安卓");
            string mode = Console.ReadLine() ?? "";
            List<string> GetNames = new();
            List<string> GetValues = new();
            string[] lines, Names, Values;
            if (mode.Contains('1'))
            {
                Console.WriteLine($"跨系统存档：安卓 -> 苹果\n正在检测{Android}文件");
                Thread.Sleep(3000);
                if (!File.Exists(Android))
                {
                    Console.WriteLine($"找不到目标文件！\n请将{Android}文件转移至该文件夹下以继续...");
                    Console.ReadLine();
                }
                Console.WriteLine("'迁移进程稍后开始...");
                Thread.Sleep(3000);
                lines = File.ReadAllLines(Android);
                foreach (string line in lines)
                {
                    if (line.Contains("string name="))
                    {
                        string[] strings = line.Split(new string[] { "<string name=\"", "\">" }, StringSplitOptions.None);
                        GetNames.Add(ToIOS_Mode(strings[1]));
                        GetValues.Add(ToIOS_Mode(strings[2].Replace("</string>", "")));
                    }
                }
                Names = GetNames.ToArray();
                Values = GetValues.ToArray();
                XmlDocument plistDoc = new();
                XmlElement rootElement = plistDoc.CreateElement("plist");
                rootElement.SetAttribute("version", "1.0");
                plistDoc.AppendChild(rootElement);
                XmlElement rootDict = plistDoc.CreateElement("dict");
                rootElement.AppendChild(rootDict);
                XmlElement key, value;
                for (int i = 0; i < Names.Length; i++)
                {
                    key = plistDoc.CreateElement("key");
                    key.InnerText = Names[i];
                    rootDict.AppendChild(key);
                    value = plistDoc.CreateElement("string");
                    value.InnerText = Values[i];
                    rootDict.AppendChild(value);
                }
                plistDoc.Save(IOS);
                Console.WriteLine($"成功迁移至{IOS}文件！");
            }
            else
            {
                Console.WriteLine($"跨系统存档：苹果 -> 安卓\n正在检测{IOS}文件");
                Thread.Sleep(3000);
                if (!File.Exists(IOS))
                {
                    Console.WriteLine($"找不到目标文件！\n请将{IOS}文件转移至该文件夹下以继续...");
                    Console.ReadLine();
                }
                Console.WriteLine("迁移进程稍后开始...");
                Thread.Sleep(3000);
                lines = File.ReadAllLines(IOS);
                foreach (string line in lines)
                {
                    if (line.Contains("<key>"))
                    {
                        string[] strings = line.Split(new string[] { "<key>", "</key>" }, StringSplitOptions.None);
                        GetNames.Add(ToIOS_Mode(strings[1]));
                    }
                    if (line.Contains("<string>"))
                    {
                        string[] strings = line.Split(new string[] { "<string>", "</string>" }, StringSplitOptions.None);
                        GetValues.Add(ToIOS_Mode(strings[1]));
                    }
                }
                Names = GetNames.ToArray();
                Values = GetValues.ToArray();
                StreamWriter streamWriter = new(Android);
                streamWriter.WriteLine("<?xml version='1.0' encoding='utf-8' standalone='yes' ?>");
                streamWriter.WriteLine("<map>");
                if (Names.Length != Values.Length)
                {
                    Console.WriteLine("XML文件出错");
                    Console.ReadLine();
                    return;
                }
                for (int i = 0; i < Names.Length; i++)
                {
                    streamWriter.WriteLine($"\t<string name=\"{GetNames[i]}\">{GetValues[i]}</string>");
                }
                streamWriter.WriteLine("</map>");
                streamWriter.Flush();
                streamWriter.Dispose();
                Console.WriteLine($"成功迁移至{Android}文件！");
            }
            Console.ReadLine();
        }

        internal static string ToIOS_Mode(string value)
        {
            if (value.Contains("%2B"))
            {
                value = value.Replace("%2B", "+");
            }
            if (value.Contains("%3D"))
            {
                value = value.Replace("%3D", "=");
            }
            if (value.Contains("%2F"))
            {
                value = value.Replace("%2F", "/");
            }
            return value;
        }

        internal static string ToAndroid_Mode(string value)
        {
            if (value.Contains('+'))
            {
                value = value.Replace("+", "%2B");
            }
            if (value.Contains('='))
            {
                value = value.Replace("=", "%3D");
            }
            if (value.Contains('/'))
            {
                value = value.Replace("/", "%2F");
            }
            return value;
        }
    }
}