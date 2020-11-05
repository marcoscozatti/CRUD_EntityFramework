namespace EntityFramework_Pesquisa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CadClis", "RG", c => c.Double(nullable: false));
            AlterColumn("dbo.CadClis", "CPF", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CadClis", "CPF", c => c.Single(nullable: false));
            AlterColumn("dbo.CadClis", "RG", c => c.Single(nullable: false));
        }
    }
}
