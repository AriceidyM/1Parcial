using Microsoft.EntityFrameworkCore;
using Parcial.Data;
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial.Controller
{
    public class ArticuloController
    {
        public bool Guardar(Articulos articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.Articulos.Add(articulo);
            paso = db.SaveChanges() > 0;


            return paso;
        }

        public List<Articulos> GetUsuarios(Expression<Func<Articulos, bool>> expression)

        {
            List<Articulos> lista = new List<Articulos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Articulos.Where(expression).ToList();
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


        public Articulos Buscar(int id)
        {
            Contexto db = new Contexto();
            Articulos articulo = new Articulos();

            try
            {
                articulo = db.Articulos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return articulo;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Articulos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public bool Modificar(Articulos articulo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {

                db.Entry(articulo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
    }
}

