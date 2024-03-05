using AutoMapper;
using LivraiZone.Application.Commands.User;
using LivraiZone.Application.DTO;
using LivraiZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.AutoMapper
{
    public class UserAM : Profile
    {
        public UserAM() 
        {
            CreateMap<AppUser, UserReadDto>();

            CreateMap<UserCreateDto, AppUser>();

            CreateMap<AddUserCommand, AppUser>();

            //CreateMap<AppUser, LoginUserCommand>();
            CreateMap<LoginUserCommand, AppUser>();

            CreateMap<ForgotPasswordCommand, AppUser>();

            //CreateMap<AppUser,ForgotPasswordCommand>();

        }
    }
}
