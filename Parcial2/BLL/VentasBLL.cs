using Parcial2.DAL;
using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial2.BLL
{
    public class VentasBLL
    {
        public static Ventas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ventas ventas;

            try
            {
                ventas = contexto.Ventas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ventas;

        }
        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> producto)
        {
            List<Ventas> lista = new List<Ventas>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Ventas.Where(producto).ToList();
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
