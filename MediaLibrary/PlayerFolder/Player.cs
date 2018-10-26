using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaLibrary.File;
using MediaLibrary.Interfaces;
using MediaLibrary.Startegy;

namespace MediaLibrary
{
    public class Player : IPlayer
    {
        private IFilePlayStrategy _currentStrategy;

        public void Play(IPlaylist file)
        {
            foreach (var item in file)
            {
                _currentStrategy = PlayerHelper.ChooseStrategy(item);
                _currentStrategy.Play(item);
            }
        }
    }
}
