using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaLibrary.File;
using MediaLibrary.Interfaces;

namespace MediaLibrary
{
    class Playlist : IPlaylist
    {
        private IFile[] _files = new IFile[3];
        private int _position = 0;
        private string _name;

        public IFile this[int index] { get => _files[index]; set => _files[index] = value; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IFile item)
        {
            _files[_position] = item;
            _position++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IFile item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IFile[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IFile> GetEnumerator()
        {
            for (int i = 0; i < 3; i++)
            {

                yield return _files[i];
            }
        }

        public int IndexOf(IFile item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, IFile item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IFile item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
