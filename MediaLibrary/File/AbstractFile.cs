﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaLibrary.Interfaces;

namespace MediaLibrary.File
{
    public abstract class AbstractFile : IFile
    {
        private string _name;
        private string _path;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
