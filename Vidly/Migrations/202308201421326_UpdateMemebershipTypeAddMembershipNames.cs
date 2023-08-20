namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemebershipTypeAddMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Pay As You Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Quarterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Annualy' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
