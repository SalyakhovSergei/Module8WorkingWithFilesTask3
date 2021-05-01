using System;
using System.IO;

namespace Module8FilesTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileActions test = new FileActions();
            Console.WriteLine($"Общий размер папки: {test.FileSizeCount("C:/Users/Анатолий/Desktop/testFolder")}");
            Console.WriteLine($"Очищено: {test.FileSizeCount("C:/Users/Анатолий/Desktop/testFolder")}");
            test.DeleteFiles("C:/Users/Анатолий/Desktop/testFolder");
            Console.WriteLine($"Текущий размер папки: {test.FileSizeCount("C:/Users/Анатолий/Desktop/testFolder")}");

        }
    }
}

