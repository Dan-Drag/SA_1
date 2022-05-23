 using SA_1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1.Factories
{
    internal class JpegFileCreatableFactory : FileCreatableFactory
    {
        private string _name;
        private string _path;

        public JpegFileCreatableFactory(string name, string path)
        {
            _name = name;
            _path = path;
        }
        public override IFileCreatable GetFileCreatable()
        {
            JpegFileCreatable txtFileCreatable = new(_name, _path) { };

            txtFileCreatable.CreateFile();
            return txtFileCreatable;
        }
    }
}
