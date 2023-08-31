using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("departamento");

        builder.Property(p => p.IdDep)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.NombreDep)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Ciudades)
        .IsRequired();

        builder.HasOne(p => p.Pais)
        .WithMany(p => p.Departamentos)
        .HasForeignKey(p => p.IdPaisFk); 
    }
}