﻿using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.EntityConfiguration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(f => f.FirstName)
                 .HasMaxLength(50)
                 .IsUnicode()
                 .IsRequired();

            builder.Property(l => l.LastName)
                 .HasMaxLength(50)
                 .IsUnicode()
                 .IsRequired();

            builder.Property(e => e.Email)
                 .HasMaxLength(80)
                 .IsRequired();

            builder.Property(e => e.Password)
                 .HasMaxLength(25)
                 .IsRequired();
        }
    }
}
