using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public Artist Artist { get; set; }

        public Song (string Name, int Duration, Artist Artist)
        {
            this.Duration = Duration;
            this.Name = Name;
            this.Artist = Artist;
        }
    }
}
