using ICI.ProvaCandidato.Negocio.Models.Noticias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Mapping.Noticia
{
    public class NoticiaTagMapping : IEntityTypeConfiguration<NoticiaTag>
    {
        public void Configure(EntityTypeBuilder<NoticiaTag> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.NoticiaId)
                .HasColumnType("int");
            
            builder.Property(c => c.TagId)
                .HasColumnType("int");

            builder.ToTable("NoticiaTag");
        }
    }
}
