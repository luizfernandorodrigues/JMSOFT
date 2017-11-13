namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_132_REMOCAO_DOS_CAMPOS_DE_ACESSO_DESNECESSARIO : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "Usr_001_n");
            DropColumn("dbo.Usuarios", "Usr_002_n");
            DropColumn("dbo.Usuarios", "Usr_003_n");
            DropColumn("dbo.Usuarios", "Usr_004_n");
            DropColumn("dbo.Usuarios", "Usr_005_n");
            DropColumn("dbo.Usuarios", "Usr_006_n");
            DropColumn("dbo.Usuarios", "Usr_007_n");
            DropColumn("dbo.Usuarios", "Usr_008_n");
            DropColumn("dbo.Usuarios", "Usr_009_n");
            DropColumn("dbo.Usuarios", "Usr_010_n");
            DropColumn("dbo.Usuarios", "Usr_011_n");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Usr_011_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_010_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_009_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_008_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_007_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_006_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_005_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_004_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_003_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_002_n", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "Usr_001_n", c => c.Boolean(nullable: false));
        }
    }
}
