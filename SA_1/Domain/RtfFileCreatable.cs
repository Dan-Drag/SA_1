using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SA_1.Domain
{
    internal class RtfFileCreatable : IFileCreatable
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public RtfFileCreatable(string name, string path)
        { Name = name; Path = path; }
        public void CheckName()
        {

        }

        public void CheckPath()
        {
            string path = Path;
            if (Directory.Exists(path))
            {

                Path = path + @"\";
            }
            else
            {
                Console.WriteLine("Такой директории не существует");
            }
        }
        public string FullPath()
        {
            CheckName();
            CheckPath();
            return $"{Path}\\{Name}.rtf";
        }

        public void CreateFile()
        {
            string str = FullPath();
            File.Create($@"{str}");

        }
    }
}

