using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository.Config
{
    internal class CfgCars : IEntityTypeConfiguration<Cars>
    {
        public void Configure(EntityTypeBuilder<Cars> b)
        {
            b.ToTable("Carro");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired()
                .ValueGeneratedOnAdd();
            b.Property(x => x.Marca)
                .HasColumnName("Marca")
                .IsRequired()
                .HasMaxLength(30);
            b.Property(x => x.Modelo)
                .HasColumnName("Modelo")
                .HasMaxLength(30)
                .IsRequired();
            b.Property(x => x.Placa)
                .HasColumnName("Placa")
                .IsRequired()
                .HasMaxLength(8);

                
        }
    }
}
