using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Dukkani.Data
{
    public class AdminAlbum
    { 
        public int AdminId { get; set; }
        public int AlbumId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Album Album { get; set; } 
    }
}

