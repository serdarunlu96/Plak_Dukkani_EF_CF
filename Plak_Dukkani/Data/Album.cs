using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Dukkani.Data
{
    public class Album
    {

        public int Id { get; set; }

        public string AlbumName { get; set; }

        public DateTime Date { get; set; }

        public string Singer { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public string Status { get; set; }
        public virtual ICollection<AdminAlbum> AdminAlbums { get; set; }

    }
}
