using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1.Domain
{
    internal interface IFileCreatable
    {
        string Name { get; set; }
        string Path { get; set; }

        void CheckName();
        void CheckPath();
        string FullPath();
        void CreateFile();
    }
}
