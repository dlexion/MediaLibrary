using MediaLibrary.File;
using MediaLibrary.Interfaces;
using MediaLibrary.Startegy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public static class PlayerHelper
    {
        private static Dictionary<Type, IFilePlayStrategy> strateges = new Dictionary<Type, IFilePlayStrategy>()
        {
            {typeof(MusicFile), new MusicFileStrategy() },
            {typeof(VideoFile), new VideoFileStrategy() },
            {typeof(PhotoFile), new PhotoFileStrategy() }
        };

        public static IFilePlayStrategy ChooseStrategy(IFile file)
        {
            return strateges[file.GetType()];
        }
    }
}
