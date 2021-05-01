using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8FilesTask3
{
    public class FileActions
    {
        public void DeleteFiles(string folder)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            DirectoryInfo[] directories = dirInfo.GetDirectories();
            FileInfo[] FI = dirInfo.GetFiles();

            if (dirInfo.Exists)
            {
                try
                {
                    foreach (FileInfo file in FI)
                    {
                        TimeSpan fileTime = DateTime.Now - file.CreationTime;
                        if (fileTime.Minutes > 2)
                        {
                            file.Delete();
                        }
                    }
                    foreach (DirectoryInfo DI in directories)
                    {
                        DeleteFiles(DI.FullName);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

        public long FileSizeCount(string folder)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            DirectoryInfo[] directories = dirInfo.GetDirectories();
            FileInfo[] FI = dirInfo.GetFiles();
            long allFileSize = 0;

            if (dirInfo.Exists)
            {
                try
                {
                    foreach (FileInfo file in FI)
                    {
                        allFileSize += file.Length;
                    }
                    foreach (DirectoryInfo DI in directories)
                    {
                        allFileSize += FileSizeCount(DI.FullName);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return allFileSize;
        }
    }
}

