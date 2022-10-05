using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Business.Models;

namespace Revisao.Data.mappings
{
   
        public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
        {
            public void Configure(EntityTypeBuilder<Categoria> builder)
            {
                builder.HasKey(p => p.Id);

                builder.Property(p => p.Descricao)
                    .IsRequired()
                    .HasColumnType("varchar(200)");


                // 1 : N => Fornecedor : Produtos
                builder.HasMany(f => f.Produtos)
                    .WithOne(p => p.Categoria)
                    .HasForeignKey(p => p.CategoriaId);

                builder.ToTable("Categoria");
            }
        }
}
