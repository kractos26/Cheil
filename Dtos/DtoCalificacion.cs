using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
   public class DtoCalificacion
    {
        public int IdCalificacion { get; set; }
        public int? IdHotel { get; set; }
        public int? IdCliente { get; set; }
    }
}
