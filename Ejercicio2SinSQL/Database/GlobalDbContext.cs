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
            modelBuiler.Configurations.Add(new TribunalModel());
            modelBuiler.Configurations.Add(new GrupoModel());
            modelBuiler.Configurations.Add(new TFCModel());
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

        public IQueryable<Tribunal> Tribunales(bool trackChanges = false)
        {
            IQueryable<Tribunal> query = this.Set<Tribunal>();
            if (!trackChanges)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public IQueryable<Grupo> Grupos(bool trackChanges = false)
        {
            IQueryable<Grupo> query = this.Set<Grupo>();
            if (!trackChanges)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public IQueryable<TFC> TFCs(bool trackChanges = false)
        {
            IQueryable<TFC> query = this.Set<TFC>();
            if (!trackChanges)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

    }
}
