using System;
using System.Collections.Generic;

#nullable disable

namespace DataEntity.Models
{
    public partial class Calificacion
    {
        public int IdCalificacion { get; set; }
        public int? IdHotel { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Hotel IdHotelNavigation { get; set; }
    }
}
