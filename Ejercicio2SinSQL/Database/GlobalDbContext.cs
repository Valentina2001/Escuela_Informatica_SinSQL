using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL.Database
{
    public class GlobalDbContext: DbContext
    {
        public GlobalDbContext() : base("Ejercicio2")
        {

        }

        public void Add<T>(T theElement) where T : class
        {
            this.Set<T>().Add(theElement);
        }

        public void Remove <T>(T theElement) where T : class
        {
            this.Set<T>().Remove(theElement);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuiler)
        {
            modelBuiler.Configurations.Add(new AlumnoModel());
        }

        public IQueryable<Alumno> Alumnos(bool trackChanges = false)
        {
            IQueryable<Alumno> query = this.Set<Alumno>();
            if (!trackChanges)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

    }
}
