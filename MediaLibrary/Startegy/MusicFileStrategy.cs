﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.File;
using MediaLibrary.Interfaces;

namespace MediaLibrary.Startegy
{
    class MusicFileStrategy : BaseStrategy
    {
        public override void Play(IFile file)
        {
            // for checking
            Console.WriteLine("Play music file");
        }
    }
}
