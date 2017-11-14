namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_140_ADD_TABELA_PESQUISA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T01",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        T01_001_c = c.String(nullable: false, maxLength: 20),
                        T01_002_c = c.String(nullable: false, maxLength: 50),
                        T01_003_c = c.String(nullable: false, unicode: false, storeType: "text"),
                        DateTime = c.DateTime(nullable: false),
                        User_note = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Ukey)
                .ForeignKey("dbo.Usuarios", t => t.User_note, cascadeDelete: true)
                .Index(t => t.User_note);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T01", "User_note", "dbo.Usuarios");
            DropIndex("dbo.T01", new[] { "User_note" });
            DropTable("dbo.T01");
        }
    }
}
