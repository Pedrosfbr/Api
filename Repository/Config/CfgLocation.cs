using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    internal class CfgLocation : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> bu)
        {
            bu.ToTable("Location");
            bu.HasKey(x => x.Id);
            bu.Property(x => x.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .IsRequired();
            bu.Property(x => x.Continente)
                .HasColumnName("Continente")
                .IsRequired();
            bu.Property(x => x.Pais)
                .HasColumnName("País")
                .IsRequired();
            bu.Property(x => x.Estado)
                .HasColumnName("Estado")
                .IsRequired();
            bu.Property(x => x.Cidade)
                .HasColumnName("Cidade");
        
        }
    }
}
