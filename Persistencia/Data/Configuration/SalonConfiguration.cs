using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class SalonConfiguration : IEntityTypeConfiguration<Salon>
{
    public void Configure(EntityTypeBuilder<Salon> builder)
    {
        builder.ToTable("salon");

        builder.Property(s => s.SalonId)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(s => s.NombreSalon)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(s => s.Capacidad)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(s => s.Matriculas)
        .IsRequired();

        builder.Property(s => s.TrainerSalones)
        .IsRequired();
    }
} 
