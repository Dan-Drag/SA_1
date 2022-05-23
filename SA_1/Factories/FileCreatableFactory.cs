using SA_1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1.Factories
{
    internal abstract class FileCreatableFactory
    {
        public abstract IFileCreatable GetFileCreatable();

    }
}
