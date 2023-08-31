using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("ciudad");

        builder.Property(c => c.IdCiudad)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(c => c.NombreCiudad)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Personas)
        .IsRequired();

        builder.HasOne(p => p.Departamento)
        .WithMany(p => p.Ciudades)
        .HasForeignKey(p => p.IdDepFk);
    }
}