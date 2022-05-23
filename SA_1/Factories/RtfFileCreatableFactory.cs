using SA_1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1.Factories
{
    internal class RtfFileCreatableFactory : FileCreatableFactory
    {
        private string _name;
        private string _path;

        public RtfFileCreatableFactory(string name, string path)
        {
            _name = name;
            _path = path;
        }
        public override IFileCreatable GetFileCreatable()
        {
            RtfFileCreatable rtfFileCreatable = new(_name, _path) { };

            rtfFileCreatable.CreateFile();
            return rtfFileCreatable;
        }
    }
}
