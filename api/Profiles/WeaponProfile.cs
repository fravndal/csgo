using Api.Models;
using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Profiles
{
    public class WeaponProfile : Profile
    {
        public WeaponProfile()
        {
            CreateMap<Weapon, WeaponDto>()
                .ForMember(x => x.WeaponImageName, y => y.MapFrom(src => src.WeaponImage.WeaponImageName));
        }
    }
}
