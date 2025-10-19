using System;
using System.IO;
using System.Linq;

namespace BTH2_24520432
{
    internal class Bai2
    {
        public void run()
        {
            Console.Write("Nhap duong dan thu muc: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                Console.WriteLine($"\n Directory of {path}\n");

                DirectoryInfo[] subDirs = dirInfo.GetDirectories("*", SearchOption.TopDirectoryOnly);
                foreach (DirectoryInfo subDir in subDirs)
                {
                    Console.WriteLine($"{subDir.LastWriteTime:dd/MM/yyyy hh:mm tt}    <DIR>          {subDir.Name}");
                }

                FileInfo[] files = dirInfo.GetFiles("*", SearchOption.TopDirectoryOnly);
                long totalBytes = 0; 

                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"{file.LastWriteTime:dd/MM/yyyy hh:mm tt} {file.Length,14:N0} {file.Name}");
                    totalBytes += file.Length; 
                }

               
                Console.WriteLine($"\n{files.Length,16} File(s) {totalBytes,16:N0} bytes");
                Console.WriteLine($"{subDirs.Length,16} Dir(s)");
            }
            else
            {
                Console.WriteLine("Thu muc khong ton tai.");
            }
        }
    }
}