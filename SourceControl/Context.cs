using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class Context: DbContext
    {
        public DbSet<Song> songs { get; set; }
        public DbSet<Artist> artists { get; set; }
    }
}
