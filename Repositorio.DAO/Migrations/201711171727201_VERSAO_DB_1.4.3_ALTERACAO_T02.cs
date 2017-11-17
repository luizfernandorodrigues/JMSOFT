namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_143_ALTERACAO_T02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T02", "T02_001_c", c => c.String(nullable: false, maxLength: 15));
            AddColumn("dbo.T02", "T02_002_c", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.T02", "T02_003_n", c => c.Int(nullable: false));
            AddColumn("dbo.T02", "T02_004_n", c => c.Int(nullable: false));
            AddColumn("dbo.T02", "T02_005_c", c => c.String(maxLength: 30));
            AddColumn("dbo.T02", "T02_006_c", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.T02", "T02_007_n", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.T02", "T01_001_c");
            DropColumn("dbo.T02", "T01_002_c");
            DropColumn("dbo.T02", "T01_003_n");
            DropColumn("dbo.T02", "T01_004_n");
            DropColumn("dbo.T02", "T01_005_c");
            DropColumn("dbo.T02", "T01_006_c");
            DropColumn("dbo.T02", "T01_007_n");
        }
        
        public override void Down()
        {
            AddColumn("dbo.T02", "T01_007_n", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.T02", "T01_006_c", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.T02", "T01_005_c", c => c.String(maxLength: 30));
            AddColumn("dbo.T02", "T01_004_n", c => c.Int(nullable: false));
            AddColumn("dbo.T02", "T01_003_n", c => c.Int(nullable: false));
            AddColumn("dbo.T02", "T01_002_c", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.T02", "T01_001_c", c => c.String(nullable: false, maxLength: 15));
            DropColumn("dbo.T02", "T02_007_n");
            DropColumn("dbo.T02", "T02_006_c");
            DropColumn("dbo.T02", "T02_005_c");
            DropColumn("dbo.T02", "T02_004_n");
            DropColumn("dbo.T02", "T02_003_n");
            DropColumn("dbo.T02", "T02_002_c");
            DropColumn("dbo.T02", "T02_001_c");
        }
    }
}
