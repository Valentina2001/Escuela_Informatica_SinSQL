using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL.Database
{
    public class TribunalModel : EntityTypeConfiguration<Tribunal>
    {
        public TribunalModel()
        {
            this.ToTable("tribunal");
        }
    }
}

