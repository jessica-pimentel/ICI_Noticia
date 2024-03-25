using ICI.ProvaCandidato.Negocio.Models.Noticias;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Mapping.Noticia
{
    public class NoticiaMapping : IEntityTypeConfiguration<Noticiia>
    {
        public void Configure(EntityTypeBuilder<Noticiia> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Titulo)
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Texto)
                .HasColumnType("text");

            builder.Property(c => c.Tag)
                .HasColumnType("text");

            builder.ToTable("Noticia");
        }
    }
}
