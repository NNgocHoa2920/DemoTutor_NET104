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
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           //THIẾT LẬP CONNFFIG CHHO CÁC CLKASS
           //THIẾT LẬP KKHOAS CHÍNH
           builder.HasKey(x=>x.Id);

            //config cho thuộc tínhh
            //password = matkhau  
            ///đổi tên ppass thành matkhau,, bắt buộc phải nhập, và có kiểu dữ liệu là nvarchar
            builder.Property(x => x.Password).IsRequired()
                .HasColumnName("MatKhau")
                .HasColumnType("nvarchar(50)");

            //name : bắt buộc nhập, và có kiểu dữ liệu là nvarchar(256)

            builder.Property(x => x.Name).IsRequired()
                .IsUnicode(true)
                .IsFixedLength(true)
                .HasMaxLength(256);

            //Cách cấu hình mqh 1-1 vs giỏ hàng

            //HasOne  : chỉ ra mqh 1
            //withOne:  chỉ ra bảng 1
            builder.HasOne(x => x.GioHang)
                .WithOne(x => x.User)
                .HasForeignKey<GioHang>(x => x.UserId);

            //cấu hình mqh 1-n vs hóa đơn
            //with manyt: chỉ ra bảng nhiều

            //lưu ý: nếu muốn cấu hhifnh ở 1-n thhif sẽ cấu hình ở bảng nhiều
            
           


                
               

        }
    }
}
