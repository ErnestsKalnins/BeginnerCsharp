using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.FileManipulation
{
    public class FileManipulation
    {
        public static void Methods()
        {
            string path = @"c:\temp\myfile.jpg";

            /** 
             * File. Note: since it has static methods, some security checking is done for each
             * operation, so that can impact performance if a lot of operations are being done on a
             * lot of files.
             */ 
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp\myfile2.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            string content = File.ReadAllText(path);

            // FileInfo 
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }

        }
    }
}
