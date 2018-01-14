using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.FileManipulation
{
    public class PathManipulation
    {
        public static void Methods()
        {
            string path = @"c:\cwRsync\cwrsync.bat";
            int dotIndex= path.IndexOf('.');
            string extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name w/o extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
