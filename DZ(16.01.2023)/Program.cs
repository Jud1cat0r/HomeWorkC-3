using System.Formats.Tar;
using System.IO;

namespace DZ_16._01._2023_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckDirectory.Check();
        }
    }

    static class CheckDirectory
    {

        static public void Check()
        {
            Console.WriteLine("Введите путь к директории:");
            DirectoryInfo directoryInfo = new DirectoryInfo(Console.ReadLine());
            FileInfo[] file = directoryInfo.GetFiles();
            Console.WriteLine("Список файлов:");
            foreach (var e in file)
            {
                Console.WriteLine($"Имя файла: {e.Name} / Размер файла: {e.Length} байт / Дата создания файла: {e.CreationTime}");
            }
        }


    }





}