using appAgenda.ViewModels.Agenda;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appAgenda.Mappers
{
    public class ModelToViewModelMappingProfile: Profile
    {
        public ModelToViewModelMappingProfile()
        {
            CreateMap<Contato, ContatoViewModel>();
            CreateMap<Email, EmailViewModel>();
            CreateMap<Telefone, TelefoneViewModel>();
        }    
    }
}