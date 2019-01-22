using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public enum Tipos
    {
        [Description("Casa")]
        Casa = 1,

        [Description("Trabalho")]
        Trabalho = 2,

        [Description("Outro")]
        Outro = 3

    }
  
}