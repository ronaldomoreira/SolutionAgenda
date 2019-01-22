using Repository.Context;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;

using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ContatoRepository: Repository<Contato>, IContatoRepository
    {

        public ContatoRepository(ContextMain context) : base(context)
        {

        }
            
        public override Contato ObterPorId(Guid? id)
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM Contato c " +
                       "LEFT JOIN Email    e ON c.IdContato = e.IdContato " +
                       "LEFT JOIN Telefone t ON c.IdContato = t.IdContato " +
                       "WHERE c.IdContato = @sid";

            var contatos = new List<Contato>();
            cn.Query<Contato, Email, Telefone, Contato>(sql,
                (c, e, t) => {
                    contatos.Add(c);
                    if (e != null)
                        contatos[0].Emails.Add(e);

                    if (t != null)
                        contatos[0].Telefones.Add(t);

                    return contatos.FirstOrDefault();
                }, new { sid = id }, splitOn: "IdContato, IdEmail, IdTelefone");


            return contatos.FirstOrDefault();
        }
    }


}
