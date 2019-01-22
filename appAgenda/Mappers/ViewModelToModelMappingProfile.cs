using appAgenda.ViewModels.Agenda;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appAgenda.Mappers
{
    public class ViewModelToModelMappingProfile : Profile
    {
        public ViewModelToModelMappingProfile()
        {
            CreateMap<ContatoViewModel, Contato>();
            CreateMap<EmailViewModel, Email>();
            CreateMap<TelefoneViewModel, Telefone>();
        }
    }
}