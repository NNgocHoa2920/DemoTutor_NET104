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
    internal class HDCTConfig : IEntityTypeConfiguration<HDCT>
    {
        public void Configure(EntityTypeBuilder<HDCT> builder)
        {
           builder.HasKey(x=>x.Id);

            //thiết lập 1-n vs sanpham
            builder.HasOne<SanPham>(x => x.SanPham)
                .WithMany(x => x.HDCTs)
                .HasForeignKey(x => x.SanPhamId);


            //thiết lập 1-n vs Hoadon
            builder.HasOne<HoaDon>(x => x.HoaDon)
                .WithMany(x => x.HDCTs)
                .HasForeignKey(x => x.HoaDonId);
        }
    }
}
