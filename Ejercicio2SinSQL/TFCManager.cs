using System;
using System.Collections.Generic;
using Ejercicio2SinSQL.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL
{
    class TFCManager
    {
        public List<TFC> GetTFC (string buscarText)
        {
            using(GlobalDbContext dbContext = new GlobalDbContext())
            {
                IQueryable<TFC> query = dbContext.TFCs();
                if (!string.IsNullOrEmpty(buscarText))
                {
                    query = query.Where(c =>
                   c.Tema.Contains(buscarText)
                    );
                }

                query = query.OrderBy(tfc => tfc.Tema);
                return query.ToList();
            }
        }

        public void Write (string tema, string fecha)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                TFC tfc = new TFC()
                {
                    Tema = tema,
                    Fecha = fecha
                };
                dbContext.Add(tfc);
                dbContext.SaveChanges();
            }
        }

        public void Update(int num_orden, string tema, string fecha)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                TFC tfc = dbContext.TFCs(true)
                    .Where(s => s.Num_orden == num_orden)
                    .FirstOrDefault();
                if (tfc != null)
                {
                    tfc.Tema = tema;
                    tfc.Fecha = fecha;

                    dbContext.SaveChanges();
                }
            }
        }

        public void Delete(int num_orden)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                TFC tfc = dbContext.TFCs(true)
                    .Where(s => s.Num_orden == num_orden)
                    .FirstOrDefault();
                if (tfc != null)
                {
                    dbContext.Remove(tfc);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
