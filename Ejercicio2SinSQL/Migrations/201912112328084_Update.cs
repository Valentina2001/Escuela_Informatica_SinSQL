namespace Ejercicio2SinSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.profesor",
                c => new
                    {
                        DNI = c.Int(nullable: false),
                        Nombre = c.String(),
                        Domicilio = c.String(),
                    })
                .PrimaryKey(t => t.DNI);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.profesor");
        }
    }
}
