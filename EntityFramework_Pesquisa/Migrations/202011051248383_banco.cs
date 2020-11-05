namespace EntityFramework_Pesquisa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CadClis", "Cidade", c => c.String());
            AlterColumn("dbo.CadClis", "RG", c => c.Single(nullable: false));
            AlterColumn("dbo.CadClis", "CPF", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CadClis", "CPF", c => c.Int(nullable: false));
            AlterColumn("dbo.CadClis", "RG", c => c.Int(nullable: false));
            DropColumn("dbo.CadClis", "Cidade");
        }
    }
}
