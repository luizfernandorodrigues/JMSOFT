namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_134_AJUSTES_ANOTACOES : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 100));
        }
    }
}
