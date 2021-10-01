using Microsoft.EntityFrameworkCore;
using AcmeNotas.App.Dominio;
namespace AcmeNotas.App.Persistencia

{
   public class AppContext : DbContext
{
    public DbSet<Persona> Personas {get; set;}
    public DbSet<Administrador> Administradores {get;set;}
    //public DbSet<Ciclo> Ciclos{get;set;}
    public DbSet<Estudiante> Estudiantes{get; set;}
    public DbSet<Formador> Formadores {get;set;}
    public DbSet<Grupo> Grupos {get;set;}
    public DbSet<GrupoEstudiante> GrupoEstudiantes{get;set;}
    public DbSet<Horario> Horarios {get;set;}
    public DbSet<Departamento> Departamentos {get; set;}
    public DbSet<Municipio> Municipios {get;set;}
    public DbSet<Nota> Notas {get; set;}
    public DbSet <Tutor> Tutores {get; set;}
  protected override void OnConfiguring (DbContextOptionsBuilder optionBuilder)
  {
      if(!optionBuilder.IsConfigured)
      {
          optionBuilder
          .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog =AcmeNotas.db");

      }

  }
 } 
}