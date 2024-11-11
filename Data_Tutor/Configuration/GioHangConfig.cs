using Data_Tutor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Configuration
{
    internal class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);

            //thiết lập  1-1 vs user
            builder.HasOne(x=>x.User)
                .WithOne(x=>x.GioHang)
                .HasForeignKey<GioHang>(x=>x.UserId);   

        }
    }
}
