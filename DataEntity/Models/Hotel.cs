using System;
using System.Collections.Generic;

#nullable disable

namespace DataEntity.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Calificacions = new HashSet<Calificacion>();
            Fotos = new HashSet<Foto>();
        }

        public int IdHotel { get; set; }
        public int? Categoria { get; set; }
        public decimal? Precio { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; }
        public virtual ICollection<Foto> Fotos { get; set; }
    }
}
