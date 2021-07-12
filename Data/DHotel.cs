using DataEntity.Models;
using DataModelo.Models;
using DataRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DHotel : IRepositorioHotel
    {
        private readonly Repositorio<Hotel> repocitorio;

        public DHotel()
        {
            repocitorio = new Repositorio<Hotel>(new CheilTravelContext());

        }
        public Hotel Adicionar(Hotel Entidad)
        {
            this.repocitorio.Adicionar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public List<Hotel> Buscar(Expression<Func<Hotel, bool>> predicado)
        {
            return this.repocitorio.Buscar(predicado);
        }

        public Hotel Eliminar(Hotel Entidad)
        {
            this.repocitorio.Eliminar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public List<Hotel> GetAll()
        {
            return this.repocitorio.GetAll();
        }

        public void Guardar()
        {
            this.repocitorio.Guardar();
        }

        public Hotel Modificar(Hotel Entidad)
        {

            this.repocitorio.Modificar(Entidad);
            this.repocitorio.Guardar();
            return Entidad;
        }

        public Hotel TraerUltimo(Expression<Func<Hotel, bool>> predicado)
        {
            return this.repocitorio.TraerUltimo(predicado);
        }

        public Hotel TraerUno(Expression<Func<Hotel, bool>> predicado)
        {
            return this.repocitorio.TraerUno(predicado);
        }
    }
}
