namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_138_AJUSTE_COLUNA_TIMESTAMP : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Timestamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Timestamp", c => c.DateTime(nullable: false));
        }
    }
}
