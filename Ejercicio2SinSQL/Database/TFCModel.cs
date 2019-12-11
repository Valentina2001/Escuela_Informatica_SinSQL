using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2SinSQL.Database
{
    class TFCModel : EntityTypeConfiguration<TFC>
    {
        public TFCModel()
        {
            this.ToTable("TFC");
        }
    }
}
