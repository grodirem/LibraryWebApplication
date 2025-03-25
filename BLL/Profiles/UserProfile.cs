using AutoMapper;
using BLL.DTOs.Requests;
using BLL.DTOs.Responses;
using DAL.Models;

namespace BLL.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterDto, User>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email));

        CreateMap<User, AuthResponseDto>();
    }
}
