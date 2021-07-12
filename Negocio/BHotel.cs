using AutoMapper;
using DataEntity.Models;
using DataRepositorio;
using Dtos;
using Negocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BHotel : IBHotel
    {
        private readonly IRepositorioHotel _repositorioHotel;

        private readonly IMapper _mapper;
        public BHotel(IRepositorioHotel repositorioHotel, IMapper mapper)
        {
            _repositorioHotel = repositorioHotel;
            _mapper = mapper;
        }
        public List<DtoHotel> Buscar(DtoHotel dtoHotel)
        {
            try
            {
                List<Hotel> hotels = _repositorioHotel.Buscar(x => x.IdHotel == (dtoHotel.IdHotel > 0 ? dtoHotel.IdHotel : x.IdHotel) && x.Precio == (dtoHotel.Precio ?? x.Precio)
                       && x.Categoria == (dtoHotel.Categoria ?? x.Categoria)
                      );
                List<DtoHotel> lshotels = _mapper.Map<List<DtoHotel>>(hotels);
                return lshotels;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DtoHotel Crear(DtoHotel dtoHotel)
        {
            try
            {
                Hotel objHotel = _mapper.Map<Hotel>(dtoHotel);

                objHotel = this._repositorioHotel.Adicionar(objHotel);
                DtoHotel dtoHote = _mapper.Map<DtoHotel>(objHotel);
                return dtoHote;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<DtoHotel> GetAll()
        {
            try
            {
                List<Hotel> hotels = _repositorioHotel.GetAll();
                return _mapper.Map<List<DtoHotel>>(hotels);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DtoHotel GetUno(DtoHotel dtoHotel)
        {

            try
            {
                Hotel hotel = _repositorioHotel.TraerUno(x => x.IdHotel == (dtoHotel.IdHotel > 0 ? dtoHotel.IdHotel : x.IdHotel) && x.Precio == (dtoHotel.Precio ?? x.Precio)
                       && x.Categoria == (dtoHotel.Categoria ?? x.Categoria)
                      );
               DtoHotel hotels = _mapper.Map<DtoHotel>(hotel);
                return hotels;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DtoHotel Modificar(DtoHotel dtoHotel)
        {
            throw new NotImplementedException();
        }
    }
}
