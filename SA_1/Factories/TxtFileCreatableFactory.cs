using SA_1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1.Factories
{
    internal class TxtFileCreatableFactory : FileCreatableFactory
    {
        private string _name;
        private string _path;

        public TxtFileCreatableFactory(string name, string path)
        {
            _name = name;
            _path = path;
        }
        public override IFileCreatable GetFileCreatable()
        {
            TxtFileCreatable txtFileCreatable = new(_name, _path){};

            txtFileCreatable.CreateFile();
            return txtFileCreatable;
        }
    }
}
