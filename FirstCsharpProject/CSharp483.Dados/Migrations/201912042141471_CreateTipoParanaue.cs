namespace CSharp483.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTipoParanaue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tipoes");
        }
    }
}
