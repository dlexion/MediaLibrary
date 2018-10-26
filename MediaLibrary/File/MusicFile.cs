using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.File
{
    class MusicFile : MediaFile
    {
        public MusicFile()
        {
        }

        public MusicFile(string aughtor, string album, string d, double koef) : base(d, koef)
        {
            Aughtor = aughtor;
            Album = album;
        }

        public string Aughtor { get; set; }
        public string Album { get; set; }
    }
}
