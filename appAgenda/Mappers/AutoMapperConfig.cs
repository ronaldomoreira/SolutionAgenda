using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace appAgenda.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToViewModelMappingProfile>();
                x.AddProfile<ViewModelToModelMappingProfile>();
            });
        }

    }
}