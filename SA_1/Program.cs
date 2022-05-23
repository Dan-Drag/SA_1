using System;
using SA_1.Domain;
using SA_1.Factories;

namespace SA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите какой тип файла вы хотите создать:");
            Console.WriteLine("1. txt");
            Console.WriteLine("2. Doc");
            Console.WriteLine("3. rtf");
            Console.WriteLine("4. jpeg");
            string fileType = Console.ReadLine();
            FileCreatableFactory factory = GetFactory(fileType);
            IFileCreatable fileCreatable = factory.GetFileCreatable();
        }
        public static string GetName()
        {
            Console.WriteLine("Введите название файла: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string GetPath()
        {
            Console.WriteLine("Введите где будет создан файл: ");
            string path = Console.ReadLine();
            return path;
        }

        private static FileCreatableFactory GetFactory(string fileType) => fileType switch
        {
            "1" => new TxtFileCreatableFactory(GetName(), GetPath()),
            "2" => new DocFileCreatableFactory(GetName(), GetPath()),
            "3" => new RtfFileCreatableFactory(GetName(), GetPath()),
            "4" => new JpegFileCreatableFactory(GetName(), GetPath()),
            _ => null
        };
    }
}
