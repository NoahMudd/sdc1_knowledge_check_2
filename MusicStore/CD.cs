using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public class CD
    {
        public string Title;

        public string Artist;

        public string Genre;

        public decimal Price;

        public int YearOfRelease;

        public string ToString()
        {
            return $"{Title} by {Artist}";
        }
    }
}
