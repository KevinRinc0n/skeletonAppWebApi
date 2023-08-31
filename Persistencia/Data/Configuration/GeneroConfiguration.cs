using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("genero");

        builder.Property(g => g.IdGenero)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(g => g.NombreGenero)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(g => g.Personas)
        .IsRequired();
    }
}
