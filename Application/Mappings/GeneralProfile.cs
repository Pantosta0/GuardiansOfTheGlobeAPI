﻿using Application.DTOs;
using Application.Features.Heroes.Commands.CreateHeroeCommand;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region DTOs
            CreateMap<Heroe, HeroeDTO>();
            #endregion
            #region Commands
            CreateMap<CreateHeroeCommand, Heroe>();
            #endregion
        }
    }
}
