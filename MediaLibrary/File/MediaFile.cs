using MediaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.File
{
    public abstract class MediaFile : AbstractFile, IDurationContainer
    {
        private string _duration;
        public readonly double koef=1.0;


        protected MediaFile(string duration, double koef)
        {
            Duration = duration;
            this.koef = koef;
        }

        protected MediaFile()
        {
        }

        public string Duration { get => (10*koef).ToString(); set => _duration=value; }
    }
}
