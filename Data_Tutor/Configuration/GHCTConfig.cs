
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
    internal class GHCTConfig : IEntityTypeConfiguration<GHCT>
    {
        public void Configure(EntityTypeBuilder<GHCT> builder)
        {
            builder.HasKey(x => x.Id);

            //thiết lập 1-n vs giohang
            builder.HasOne<GioHang>(x => x.GioHang)
                .WithMany(x => x.GHCTs)
                .HasForeignKey(x => x.GioHangId);

            //thiết lập 1-n vs sanPham
            builder.HasOne<SanPham>(x => x.SanPham)
                .WithMany(x => x.GHCTs)
                .HasForeignKey(x => x.SanPhamId);


        }
    }
}
