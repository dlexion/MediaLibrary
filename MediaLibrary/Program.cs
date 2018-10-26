using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaLibrary.File;
using MediaLibrary.Interfaces;

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlaylist pl = new Playlist();
            pl.Add(new VideoFile());
            pl.Add(new MusicFile());
            pl.Add(new PhotoFile());

            IPlayer player = new Player();
            
            player.Play(pl);

        }
    }
}
