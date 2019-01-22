using Repository.Context;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class TelefoneRepository: Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(ContextMain context) : base(context)
        {

        }
    }
    
}
