using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaz
{
    public interface IBHotel
    {
        DtoHotel Crear(DtoHotel dtoHotel);
        DtoHotel Modificar(DtoHotel dtoHotel);
        List<DtoHotel> GetAll();
        DtoHotel GetUno(DtoHotel dtoHotel);
        List<DtoHotel> Buscar(DtoHotel dtoHotel);
    }
}
