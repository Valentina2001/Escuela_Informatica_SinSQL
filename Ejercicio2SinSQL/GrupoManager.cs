using System;
using System.Collections.Generic;
using Ejercicio2SinSQL.Database;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class GrupoManager
    {
        public List<Grupo> GetGrupos(string buscarText)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                IQueryable<Grupo> query = dbContext.Grupos();
                if (!string.IsNullOrEmpty(buscarText))
                {
                    query = query.Where(c =>
                    c.Nombre_grupo.Contains(buscarText)
                    );
                }

                query = query.OrderBy(grupo => grupo.Nombre_grupo);
                return query.ToList();
            }
        }

        public void Write(string nombre, int num_componente)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Grupo grupo = new Grupo()
                {
                    Nombre_grupo = nombre,
                    Num_componente = num_componente
                };
                dbContext.Add(grupo);
                dbContext.SaveChanges();
            }
        }

        public void Update(int num_grupo, string nombre, int num_componente)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Grupo grupo = dbContext.Grupos(true)
                    .Where(s => s.Num_grupo == num_grupo)
                    .FirstOrDefault();
                if (grupo != null)
                {
                    grupo.Nombre_grupo = nombre;
                    grupo.Num_componente = num_componente;

                    dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int num_grupo)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Grupo grupo = dbContext.Grupos(true)
                    .Where(s => s.Num_grupo == num_grupo)
                    .FirstOrDefault();
                if (grupo != null)
                {
                    dbContext.Remove(grupo);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}