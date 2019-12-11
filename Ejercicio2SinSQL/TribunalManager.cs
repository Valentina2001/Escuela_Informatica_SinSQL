using Ejercicio2SinSQL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    public class TribunalManager
    {
        public List<Tribunal> GetTribunales(string buscarText)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                IQueryable<Tribunal> query = dbContext.Tribunales();
                if (!string.IsNullOrEmpty(buscarText))
                {
                    query = query.Where(c =>
                    c.Lugar_Examen.Contains(buscarText)
                    );
                }
                query = query.OrderBy(tribunal => tribunal.Lugar_Examen);
                return query.ToList();
            }
        }

        public void Write(string lugar_examen, int num_componentes)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Tribunal tribunal = new Tribunal()
                {
                    Lugar_Examen = lugar_examen,
                    Num_Componentes = num_componentes
                };
                dbContext.Add(tribunal);
                dbContext.SaveChanges();
            }
        }

        public void Update(int num, string lugar_examen, int num_componentes)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Tribunal tribunal = dbContext.Tribunales(true)
                    .Where(s => s.Num == num)
                    .FirstOrDefault();
                if (tribunal != null)
                {
                    tribunal.Lugar_Examen = lugar_examen;
                    tribunal.Num_Componentes = num_componentes;

                    dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int num)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                Tribunal tribunal = dbContext.Tribunales(true)
                    .Where(s => s.Num == num)
                    .FirstOrDefault();
                if (tribunal != null)
                {
                    dbContext.Remove(tribunal);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
