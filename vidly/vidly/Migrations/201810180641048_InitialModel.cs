namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql(@"INSERT INTO Customers (Name,IsSubscribedToNewsLetter,MembershipTypeId) Values ('Post Malone',0,2)");
            Sql(@"INSERT INTO Customers (Name,IsSubscribedToNewsLetter,MembershipTypeId) Values ('Anmol Vashistha',1,4)");
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
