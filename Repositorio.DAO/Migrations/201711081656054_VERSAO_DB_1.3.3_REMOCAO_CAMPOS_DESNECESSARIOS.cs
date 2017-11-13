namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_133_REMOCAO_CAMPOS_DESNECESSARIOS : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "A10_046_n");
            DropColumn("dbo.Usuarios", "A10_055_n");
            DropColumn("dbo.Usuarios", "Adm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Adm", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "A10_055_n", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "A10_046_n", c => c.Int(nullable: false));
        }
    }
}
