using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICI.ProvaCandidato.Negocio.Models.Noticias.Tags;

namespace ICI.ProvaCandidato.Dados.Mapping.Noticia
{
    public class TagMapping : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(100)");

            builder.ToTable("Tag");
        }
    }
}
