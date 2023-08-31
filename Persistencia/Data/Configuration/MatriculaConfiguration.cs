using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.ToTable("matricula");

        builder.Property(m => m.IdMat)
        .IsRequired()
        .HasColumnType("int");

        builder.HasOne(m => m.Persona)
        .WithMany(m => m.Matriculas)
        .HasForeignKey(m => m.IdPersonaFk);

        builder.HasOne(m => m.Salon)
        .WithMany(m => m.Matriculas)
        .HasForeignKey(m => m.IdSalonFk);
    }
}
