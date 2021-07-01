using Parcial2.DAL;
using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial2.BLL
{
    public class ClientesBLL
    {
        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            List<Clientes> lista = new List<Clientes>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Clientes.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}
