using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaAplicacao.Models;


namespace MinhaAplicacao.Data.Mapeamentos
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.Apresentacao)
                .HasMaxLength(500)
                .IsRequired(false);
            
        }
    }
}
