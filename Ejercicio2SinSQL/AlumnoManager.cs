using Ejercicio2SinSQL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class AlumnoManager
    {
        public List<Alumno> GetAlumnos (string buscarText)
        {
            using(GlobalDbContext dbContext = new GlobalDbContext())
            {
                IQueryable<Alumno> query = dbContext.Alumnos();
                if (!string.IsNullOrEmpty(buscarText))
                {
                    query = query.Where (c=>
                    c.Nombre.Contains(buscarText)
                    );
                }

                query = query.OrderBy(alumno => alumno.Nombre);
                return query.ToList();
            }
        }

        public void Write (int dni, string nombre)
        {
            using(GlobalDbContext dbContext = new GlobalDbContext())
            {
                Alumno alumno = new Alumno()
                {
                    Dni = dni,
                    Nombre = nombre
                };
                dbContext.Add(alumno);
                dbContext.SaveChanges();
            }
        }

        public void Update(int num_matricula, int dni, string nombre)
        {
            using(GlobalDbContext dbContext = new GlobalDbContext())
            {
                Alumno alumno = dbContext.Alumnos(true)
                    .Where(s => s.Num_Matricula == num_matricula)
                    .FirstOrDefault();
                if(alumno != null)
                {
                    alumno.Dni = dni;
                    alumno.Nombre = nombre;

                    dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int num_matricula)
        {
            using(GlobalDbContext dbContext = new GlobalDbContext())
            {
                Alumno alumno = dbContext.Alumnos(true)
                    .Where(s => s.Num_Matricula == num_matricula)
                    .FirstOrDefault();
                if(alumno != null)
                {
                    dbContext.Remove(alumno);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
