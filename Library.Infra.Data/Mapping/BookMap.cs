using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infra.Data.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Description)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Author)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Author")
                .HasColumnType("varchar(100)");
        }
    }
}
