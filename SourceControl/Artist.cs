using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class Artist
    {
        public string ArtistName { get; set; }
        public List<Song> SongList { get; set; }

        public Artist(string ArtistName, List<Song> SongList)
        {
            this.ArtistName = ArtistName;
            this.SongList = SongList;
        }
    }
}
