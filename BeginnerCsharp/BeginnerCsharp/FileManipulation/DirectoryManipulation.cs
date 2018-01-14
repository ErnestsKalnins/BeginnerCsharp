using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.FileManipulation
{
    public class DirectoryManipulation
    {
        public static void Methods()
        {
            // Directory
            Directory.CreateDirectory(@"c:\temp\folder1");

            string[] files = Directory.GetFiles(@"c:\cwRsync", "*.*", SearchOption.AllDirectories);

            foreach (string file in files)
                Console.WriteLine(file);

            string[] directories = Directory.GetDirectories(@"c:\cwRsync", "*.*", SearchOption.AllDirectories);

            foreach (string directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            // DirectoryInfo
            DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\cwRsync");

            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
