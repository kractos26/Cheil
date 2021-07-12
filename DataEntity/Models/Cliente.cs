using System;
using System.Collections.Generic;

#nullable disable

namespace DataEntity.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Calificacions = new HashSet<Calificacion>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; }
    }
}
