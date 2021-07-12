using AutoMapper;
using DataEntity.Models;
using DataModelo.Models;
using Dtos;

namespace CheilTravel.Models
{
    public class UserProfile:Profile
    {
      public UserProfile()
        {
            CreateMap<DtoHotel, Hotel>();

            CreateMap<Hotel, DtoHotel>();

        }
    }
}
