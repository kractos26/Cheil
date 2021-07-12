using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class DtoHotel
    {
        public int IdHotel { get; set; }
        public int? Categoria { get; set; }
        public decimal? Precio { get; set; }

        public List<DtoCalificacion> Calificacions { get; set; }
        public List<DtoFoto> Fotos { get; set; }
    }
}
