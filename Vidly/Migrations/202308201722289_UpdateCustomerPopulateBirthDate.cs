namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerPopulateBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '03/06/1993' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
