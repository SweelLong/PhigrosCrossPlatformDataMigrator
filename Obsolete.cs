// 过时的旧版本
//    internal class Program
//    {
//        internal static void Main(string[] args)
//        {
//            string fileName = "com.PigeonGames.Phigros.v2.playerprefs.xml";
//            string[] lines = File.ReadAllLines(fileName);
//            List<string> A = new List<string>();
//            List<string> B = new List<string>();
//            foreach (string line in lines)
//            {
//                if (line.Contains("string name="))
//                {
//                    string[] strings = line.Split(new string[] { "<string name=\"", "\">"} , StringSplitOptions.None);
//                    A.Add(TryToChangeKey(strings[1]));
//                    B.Add(TryToChangeKey(strings[2].Replace("</string>", "")));
//                }
//            }
//            string[] stringsA = A.ToArray();
//            string[] stringsB = B.ToArray();
//            StreamWriter streamWriter = new("NotBinaryEncoded.plist");
//            streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
//            streamWriter.WriteLine("<!DOCTYPE plist PUBLIC \"-//Apple//DTD PLIST 1.0//EN\" \"http://www.apple.com/DTDs/PropertyList-1.0.dtd\">");
//            streamWriter.WriteLine("<plist version=\"1.0\">");
//            streamWriter.WriteLine("<dict>");
//            if (stringsA.Length != stringsB.Length)
//            {
//                Console.WriteLine("XML文件出错");
//                Console.ReadLine();
//                return;
//            }
//            for (int i = 0; i < stringsA.Length; i++)
//            {
//                streamWriter.WriteLine($"\t<key>{stringsA[i]}</key>\r\n\t<string>{stringsB[i]}</string>");
//            }
//            streamWriter.WriteLine("</dict>");
//            streamWriter.WriteLine("</plist>");
//            streamWriter.Flush();
//            streamWriter.Dispose();
//            Console.WriteLine("");
//        }

//        internal static string TryToChangeKey(string value)
//        {
//            if (value.Contains("%2B"))
//            {
//                value = value.Replace("%2B", "+");
//            }
//            if (value.Contains("%3D"))
//            {
//                value = value.Replace("%3D", "=");
//            }
//            if (value.Contains("%2F"))
//            {
//                value = value.Replace("%2F", "/");
//            }
//            return value;
//        }
//    }
//}
