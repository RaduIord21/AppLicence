using AutoMapper;
using AppLicence.DataModels;
using System.ComponentModel.DataAnnotations;
using AppLicence.Models;
namespace AppLicence.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
