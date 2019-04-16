namespace cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alith : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name_car = c.String(nullable: false),
                        car_number = c.String(nullable: false),
                        Type_car = c.String(nullable: false),
                        Release_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
        }
    }
}
