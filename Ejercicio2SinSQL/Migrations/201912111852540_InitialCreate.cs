namespace Ejercicio2SinSQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.alumno",
                c => new
                    {
                        Num_Matricula = c.Int(nullable: false, identity: true),
                        Dni = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Num_Matricula);
            
            CreateTable(
                "dbo.tribunal",
                c => new
                    {
                        Num = c.Int(nullable: false, identity: true),
                        Lugar_Examen = c.String(),
                        Num_Componentes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Num);
            
            CreateTable(
                "dbo.grupo",
                c => new
                    {
                        Num_grupo = c.Int(nullable: false, identity: true),
                        Nombre_grupo = c.String(),
                        Num_componente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Num_grupo);
            
            CreateTable(
                "dbo.TFC",
                c => new
                    {
                        Num_orden = c.Int(nullable: false, identity: true),
                        Tema = c.String(),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.Num_orden);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TFC");
            DropTable("dbo.grupo");
            DropTable("dbo.tribunal");
            DropTable("dbo.alumno");
        }
    }
}
