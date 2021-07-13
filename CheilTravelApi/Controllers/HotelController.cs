using CheilTravelApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CheilTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        // GET: HotelController

        private readonly IBHotel _bhotel;

        public HotelController(IBHotel bhotel)
        {
            _bhotel = bhotel;
        }
       
        /// <summary>
        /// Buscar libros
        /// </summary>
        /// <param name="libro">Contiene los filtros</param>
        /// <returns>Retora la lista de libros</returns>
        [HttpGet()]
        [Route("Buscar")]
        public ActionResult<Response<List<Dtos.DtoHotel>>> Buscar([FromQuery]Dtos.DtoHotel libro)
        {
            Response<List<Dtos.DtoHotel>> response = new Response<List<Dtos.DtoHotel>>();
            try
            {
                response.Entidad = _bhotel.Buscar(libro);
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.Found;
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Buscar libros
        /// </summary>
        /// <param name="libr">Contiene los filtros.</param>
        /// <returns>Retorna la lista de libros.</returns>
        [HttpGet]
        [Route("TraerUno")]
        public ActionResult<Dtos.DtoHotel> TraerUno([FromQuery]Dtos.DtoHotel libr)
        {
            Response<Dtos.DtoHotel> response = new Response<Dtos.DtoHotel>();
            try
            {
                response.Entidad = _bhotel.GetUno(libr);
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Obtiene todos los libros
        /// </summary>
        /// <returns>Lista de libros.</returns>
        [HttpGet]
        [Route("Todos")]
        [Authorize]
        public ActionResult<Dtos.DtoHotel> GetAll()
        {
            Response<List<Dtos.DtoHotel>> response = new Response<List<Dtos.DtoHotel>>();
            try
            {
                response.Entidad = _bhotel.GetAll();
                response.Status = HttpStatusCode.Found;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.BadRequest;
                return BadRequest(response);
            }
        }

        [HttpPost]
        public ActionResult<Dtos.DtoHotel> Crea(Dtos.DtoHotel DtoHotel)
        {
            Response<Dtos.DtoHotel> response = new Response<Dtos.DtoHotel>();
            try
            {
                response.Entidad = _bhotel.Crear(DtoHotel);
                response.Status = HttpStatusCode.Created;

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.BadRequest;
                return BadRequest(response);
            }
        }

        [HttpPut]
        public ActionResult<Dtos.DtoHotel> Modificar(Dtos.DtoHotel DtoHotel)
        {
            Response<Dtos.DtoHotel> response = new Response<Dtos.DtoHotel>();
            try
            {
                response.Entidad = _bhotel.Modificar(DtoHotel);
                response.Status = HttpStatusCode.Created;

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
                response.Status = HttpStatusCode.BadRequest;
                return BadRequest(response);
            }
        }
    }
}
