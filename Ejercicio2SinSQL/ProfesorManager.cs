using Ejercicio2SinSQL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class ProfesorManager
    {
        public List<Profesor> GetProfesores(string buscarText)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                IQueryable<Profesor> query = dbContext.Profesores();
                if (!string.IsNullOrEmpty(buscarText))
                {
                    query = query.Where(c =>
                   c.Nombre.Contains(buscarText)
                    );
                }

                query = query.OrderBy(profesor => profesor.Nombre);
                return query.ToList();
            }
        }

        public void Write(int dni, string nombre, string domicilio)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Profesor profesor = new Profesor()
                {
                    DNI = dni,
                    Nombre = nombre,
                    Domicilio = domicilio
                };
                dbContext.Add(profesor);
                dbContext.SaveChanges();
            }
        }

        public void Update(int dni, string nombre, string domicilio)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Profesor profesor = dbContext.Profesores(true)
                    .Where(s => s.DNI == dni)
                    .FirstOrDefault();
                if (profesor != null)
                {
                    profesor.DNI = dni;
                    profesor.Nombre = nombre;
                    profesor.Domicilio = domicilio;

                    dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int dni)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Profesor profesor = dbContext.Profesores(true)
                    .Where(s => s.DNI == dni)
                    .FirstOrDefault();
                if (profesor != null)
                {
                    dbContext.Remove(profesor);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}