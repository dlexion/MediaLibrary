using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.File;
using MediaLibrary.Interfaces;

namespace MediaLibrary.Startegy
{
    public abstract class BaseStrategy : IFilePlayStrategy
    {
        public abstract void Play(IFile file);
    }
}
