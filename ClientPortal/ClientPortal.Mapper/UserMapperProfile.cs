using AutoMapper;
using ClientPortal.Entities;
using ClientPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientPortal.Mapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => (!string.IsNullOrEmpty(s.FirstName)) ? $"{s.FirstName}" : null))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => (!string.IsNullOrEmpty(s.LastName)) ? $"{s.LastName}" : null))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => (!string.IsNullOrEmpty(s.UserName)) ? $"{s.UserName}" : null))
                .ForMember(d => d.Email, opt => opt.MapFrom(s => (!string.IsNullOrEmpty(s.Email)) ? $"{s.Email}" : null))
                .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(s => (!string.IsNullOrEmpty(s.PhoneNumber)) ? $"{s.PhoneNumber}" : null))
                .ForMember(d => d.ImageUrl, opt => opt.MapFrom(s => (!string.IsNullOrEmpty(s.ImageUrl)) ? $"{s.ImageUrl}" : null))
                .ForMember(d => d.EmailConfirmation, opt => opt.MapFrom(s => (s.EmailConfirmed) ? $"{s.EmailConfirmed}" : null))
                .ForMember(d => d.Role, opt => opt.MapFrom(s => s.UserRole.Select(x => x.Role.Name).FirstOrDefault()));
            CreateMap<UserModel, User>()
                .ForMember(d => d.UserRole, opt => opt.Ignore());
        }
    }
}
