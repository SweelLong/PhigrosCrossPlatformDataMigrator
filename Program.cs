using System.Xml;
// 代码写的有点史，不过能运行就好啦
namespace PhigrosCrossPlatformDataMigrator
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string input = "com.PigeonGames.Phigros.v2.playerprefs.xml";
            string output = "games.Pigeon.Phigros.plist";
            Console.Title = "Phigros跨系统存档迁移器";
            Console.WriteLine("欢迎使用Phigros跨系统存档迁移器 - 由SweelLong开发\n\n" +
                "本人高考后入手新iPad想玩该游戏\n发现IOS无法同步之前的数据就几经摸索\n结合多种资料简化出独特方案以快速同步\n因为目前还不打算使用安卓设备，所以没有出逆向转移\n如有该需求可以联系本人sweellong@foxmail.com\n\n" +
                $"功能是将某一系统的存档数据文件转移至目标系统的数据文件\n目前仅支持将安卓存档转移为苹果存档\n旨在解决苹果端不能使用云存档功能\n\n源文件：{input}\n新文件：{output}\n\n" +
                "请耐心等待10s后继续...");
            Thread.Sleep(10000);
            Console.WriteLine("请按Enter以继续...");
            Console.ReadKey();
            Console.WriteLine($"跨系统存档：安卓 -> 苹果\n正在检测{input}文件");
            Thread.Sleep(3000);
            if (!File.Exists(input))
            {
                Console.WriteLine($"找不到目标文件！\n请将{input}文件转移至该文件夹下以继续...");
                Console.ReadLine();
            }
            Console.WriteLine("'迁移进程稍后开始...");
            Thread.Sleep(3000);
            string[] lines = File.ReadAllLines(input);
            List<string> A = new List<string>();
            List<string> B = new List<string>();
            foreach (string line in lines)
            {
                if (line.Contains("string name="))
                {
                    string[] strings = line.Split(new string[] { "<string name=\"", "\">"} , StringSplitOptions.None);
                    A.Add(TryToChangeKey(strings[1]));
                    B.Add(TryToChangeKey(strings[2].Replace("</string>", "")));
                }
            }
            string[] stringsA = A.ToArray();
            string[] stringsB = B.ToArray();
            // 创建Xml文档
            XmlDocument plistDoc = new();
            // 创建plist的根元素（Plist）
            XmlElement rootElement = plistDoc.CreateElement("plist");
            rootElement.SetAttribute("version", "1.0");
            plistDoc.AppendChild(rootElement);
            XmlElement rootDict = plistDoc.CreateElement("dict");
            rootElement.AppendChild(rootDict);
            XmlElement key, value;
            for (int i = 0; i < stringsA.Length; i++)
            {
                key = plistDoc.CreateElement("key");
                key.InnerText = stringsA[i];
                rootDict.AppendChild(key);
                value = plistDoc.CreateElement("string");
                value.InnerText = stringsB[i];
                rootDict.AppendChild(value);
            }
            plistDoc.Save(output);
            Console.WriteLine($"成功迁移至{output}文件！");
            Console.ReadLine();
        }

        internal static string TryToChangeKey(string value)
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
    }
}
