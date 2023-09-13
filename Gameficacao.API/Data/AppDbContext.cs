using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gameficacao.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Gameficacao.API.Data
{
    public class AppDbContext:DbContext
    {
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<Especialidade> Especialidades { get; set; }
    public DbSet<Recepcionista> Recepcionistas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=tds.db;Cache=Shared");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Medico>().Ignore(m => m.HorariosDisponiveis);
    //comentado

}}}









