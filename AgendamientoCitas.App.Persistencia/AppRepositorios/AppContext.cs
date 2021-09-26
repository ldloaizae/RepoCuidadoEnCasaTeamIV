using Microsoft.EntityFrameworkCore;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Cita> Citas {get;set;}
       public DbSet<Doctor> Doctores {get;set;}
       public DbSet<Encuesta> Encuestas {get;set;}
       public DbSet<Paciente> Pacientes {get;set;}
       public DbSet<Persona> Personas {get;set;}
       public DbSet<PrestadorDeServicio> PrestadoresDeServicios {get;set;}
       public DbSet<Sede> Sedes {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AgendamientoCitasData");

            }
        }
    }
}