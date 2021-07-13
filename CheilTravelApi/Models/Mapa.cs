using AutoMapper;
using DataEntity.Models;
using Dtos;

namespace CheilTravelApi.Models
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
