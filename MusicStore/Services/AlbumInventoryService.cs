using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Services
{
    public class AlbumInventoryService
    {
        private List<IAlbum> _albumList = new List<IAlbum>();

        public void Add(IAlbum album)
        {
            _albumList.Add(album);
        }

        public void AddRange(IEnumerable<IAlbum> albums)
        {
            _albumList.AddRange(albums);
        }

        public void ListAlbums()
        {
            for (int i = 0; i < _albumList.Count; i++)
            {
                var album = _albumList[i].GetDetails();
                Console.WriteLine($"{i + 1}. {album}");
            }
        }

        public IAlbum SelectAlbumByIndex(int index)
        {
            return _albumList[index - 1];
        }

    }
}
