namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1, N'INVESTIGATE LIKE SHERLOCK HOLMES')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(2, N'CODE WITH NGUYỄN ĐÌNH ÁNH')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(3, N'HỌC LÀM GIÀU')");
        }  
        public override void Down()
        {
        }
    }
}
