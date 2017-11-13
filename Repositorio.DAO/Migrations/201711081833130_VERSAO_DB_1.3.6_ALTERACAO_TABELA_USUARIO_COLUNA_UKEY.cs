namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_136_ALTERACAO_TABELA_USUARIO_COLUNA_UKEY : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "Ukey", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Usuarios", "Ukey");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "Ukey", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Usuarios", "Ukey");
        }
    }
}
