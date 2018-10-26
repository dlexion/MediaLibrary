using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaLibrary.File;

namespace MediaLibrary.Interfaces
{
    public interface IPlaylist : IList<IFile>
    {
        string Name { get; set; }
    }
}
