using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Interfaces
{
    public interface IFile
    {
        string Name { get; set; }
        string Path { get; set; }
    }
}
