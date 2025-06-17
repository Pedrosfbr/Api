using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    internal class CfgProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> b)
        {
            b.ToTable("Produtos");
            b.HasKey(x => x.Id);
            b.Property(X => X.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .IsRequired();
            b.Property(X => X.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
            b.Property(x => x.Preco)
                .HasColumnName("Preço")
                .IsRequired();

        }
    }
}
