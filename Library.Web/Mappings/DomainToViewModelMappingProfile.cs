﻿using AutoMapper;
using Library.Model;
using Library.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Category,CategoryViewModel>();
            Mapper.CreateMap<Gadget, GadgetViewModel>();
        }
    }
}