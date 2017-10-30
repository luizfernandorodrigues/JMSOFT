namespace Repositorio.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VERSAO_DB_131 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Ukey = c.Guid(nullable: false),
                        A10_046_n = c.Int(nullable: false),
                        A10_055_n = c.Int(nullable: false),
                        Adm = c.Int(nullable: false),
                        Email = c.String(maxLength: 80),
                        Horario = c.DateTime(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Porta = c.String(maxLength: 10),
                        Senha = c.String(maxLength: 100),
                        SenhaEmail = c.String(maxLength: 100),
                        ServidorEmail = c.String(maxLength: 100),
                        Ssl = c.Int(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        Usr_001_n = c.Boolean(nullable: false),
                        Usr_002_n = c.Boolean(nullable: false),
                        Usr_003_n = c.Boolean(nullable: false),
                        Usr_004_n = c.Boolean(nullable: false),
                        Usr_005_n = c.Boolean(nullable: false),
                        Usr_006_n = c.Boolean(nullable: false),
                        Usr_007_n = c.Boolean(nullable: false),
                        Usr_008_n = c.Boolean(nullable: false),
                        Usr_009_n = c.Boolean(nullable: false),
                        Usr_010_n = c.Boolean(nullable: false),
                        Usr_011_n = c.Boolean(nullable: false),
                        Login = c.String(nullable: false, maxLength: 50),
                        UsuarioEmail = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Ukey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
