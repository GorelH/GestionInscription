namespace GestionInscription.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adherants",
                c => new
                    {
                        AdherantGuid = c.Guid(nullable: false),
                        Nom = c.String(),
                        PreNom = c.String(),
                    })
                .PrimaryKey(t => t.AdherantGuid);
            
            CreateTable(
                "dbo.Inscriptions",
                c => new
                    {
                        AdherantGuid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AdherantGuid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inscriptions");
            DropTable("dbo.Adherants");
        }
    }
}
