using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class Program
    {
        static void Main(string[] args) 
        {
            using (var c = new Context())
            {
                var NewSong = c.songs.FirstOrDefault(s => s.Artist.ArtistName == "The Beatles");
                Console.WriteLine(NewSong.Name, NewSong.Duration);
            };

            
        }
    }
}
