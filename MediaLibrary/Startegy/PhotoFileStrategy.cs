using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;

namespace MediaLibrary.Startegy
{
    public class PhotoFileStrategy : BaseStrategy
    {
        public override void Play(IFile file)
        {
            // for checking
            Console.WriteLine("Play photo file");
        }
    }
}
