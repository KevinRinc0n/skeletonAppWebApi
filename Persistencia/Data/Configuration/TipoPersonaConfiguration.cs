using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("tipoPersona");

        builder.HasKey(t => t.IdTipoPersona);
        builder.Property(t => t.IdTipoPersona);

        builder.Property(t => t.Descripcion)
        .IsRequired()
        .HasMaxLength(50);
    }
}
