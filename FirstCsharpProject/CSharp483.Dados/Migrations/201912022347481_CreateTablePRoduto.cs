namespace CSharp483.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePRoduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Modelo = c.String(),
                        AnoFabricacao = c.DateTime(nullable: false),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoes");
        }
    }
}
