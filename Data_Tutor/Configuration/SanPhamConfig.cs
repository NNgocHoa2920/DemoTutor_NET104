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
    internal class SanPhamConfig : IEntityTypeConfiguration<SanPham>

    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
           builder.HasKey(x => x.Id); //thiết lập khóa  chínmh
        }
    }
}
