using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public interface IAlbum
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public int YearOfRelease { get; set; }

        public string GetDetails();
    }
}
