namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAboutWriter : DbMigration
    {
        public override void Up() // update-database dersek bu metod çalışacak
        {
            AddColumn("dbo.Writers", "AboutWriter", c => c.String(maxLength: 250));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 300));
        }
        
        public override void Down() // iptal edersek bu metod çalışacak
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
            DropColumn("dbo.Writers", "AboutWriter");
        }
    }
}
