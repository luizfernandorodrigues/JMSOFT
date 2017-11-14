namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_141_ADD_TABELA_CAMPOS_PESQUISA : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.T01", name: "DateTime", newName: "Timestamp");
            CreateTable(
                "dbo.T02",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        T01_001_c = c.String(nullable: false, maxLength: 15),
                        T01_002_c = c.String(nullable: false, maxLength: 30),
                        T01_003_n = c.Int(nullable: false),
                        T01_004_n = c.Int(nullable: false),
                        T01_005_c = c.String(maxLength: 30),
                        T01_006_c = c.String(nullable: false, maxLength: 30),
                        T01_007_n = c.String(nullable: false, maxLength: 30),
                        T01_ukey = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        User_note = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.T01", t => t.T01_ukey, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.User_note, cascadeDelete: false)
                .Index(t => t.T01_ukey)
                .Index(t => t.User_note);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T02", "User_note", "dbo.Usuarios");
            DropForeignKey("dbo.T02", "T01_ukey", "dbo.T01");
            DropIndex("dbo.T02", new[] { "User_note" });
            DropIndex("dbo.T02", new[] { "T01_ukey" });
            DropTable("dbo.T02");
            RenameColumn(table: "dbo.T01", name: "Timestamp", newName: "DateTime");
        }
    }
}
