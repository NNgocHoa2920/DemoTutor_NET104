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
    internal class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
           //khóa chính
           builder.HasKey(x => x.Id);

            //thiết lập 1-n vs hóa đơn
            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.HoaDons)

                .HasForeignKey(x => x.UserId);

        }
    }
}
