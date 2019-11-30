namespace ClinicaMedica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Medico_Id = c.Int(),
                        Paciente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicos", t => t.Medico_Id)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id)
                .Index(t => t.Medico_Id)
                .Index(t => t.Paciente_Id);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Idade = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Especialidade = c.String(),
                        Salario = c.Single(nullable: false),
                        Telefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Idade = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Convenio = c.String(),
                        Telefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Consultas", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Consultas", "Medico_Id", "dbo.Medicos");
            DropIndex("dbo.Consultas", new[] { "Paciente_Id" });
            DropIndex("dbo.Consultas", new[] { "Medico_Id" });
            DropTable("dbo.Pacientes");
            DropTable("dbo.Medicos");
            DropTable("dbo.Consultas");
        }
    }
}
