using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Study_2024_11.Shared.Entities;

namespace Shared.Database.MainDatabase.Configuration
{
    public class MessageCreatingConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("m_main_messages");

            builder.HasKey(o => o.UniqId);

            builder.Property(x => x.Body)
                .HasColumnName("message_body")
                .HasMaxLength(64);

            builder
                .HasOne(x => x.Producer)
                .WithMany(x => x.Message)
                .HasForeignKey(x => x.AuthorId);
                
        }
    }
}
