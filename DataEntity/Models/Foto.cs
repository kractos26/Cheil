using System;
using System.Collections.Generic;

#nullable disable

namespace DataEntity.Models
{
    public partial class Foto
    {
        public int IdFoto { get; set; }
        public string Ruta { get; set; }
        public int? IdHotel { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; }
    }
}
