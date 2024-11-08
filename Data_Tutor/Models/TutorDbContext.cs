
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
    //class này là class đại diện cho csdl ở trong visual
    //vậy nên  khi các bạn muốn sử dụng đến csdl thì phải gọi nó mà dùng
    public class TutorDbContext : DbContext
    {
        //khi để chuỗi kết nối ở class dbcontext thì bắt buộc phải tạo contructor k có tham số

        //nếu để chuỗi kết nối ở appseting thì có thể tạo hoặc k, vẫn k bị ảnh hưởng
        //tạo contructor
        //ctor+ tab
        public TutorDbContext()
        {
            
        }
        //ctrl + . => generate contructor ...(option)
        public TutorDbContext(DbContextOptions options) : base(options)
        {
        }

        // taoj các dbset
        //db set đại diện cho 1 thực thể  = đại diện cho 1 bảng ở trong csdl
        //khi crud thì gọi đến dbset CHỨ K PHẢI CLASS
        ///CÓ BAO NHIÊU CLASS THÌ CÓ BẤY NHIÊU DBSET <summary>
        /// CÓ BAO NHIÊU CLASS THÌ CÓ BẤY NHIÊU DBSET
        /// //VÍ DỤ : _db.SanPhams,adđ.....
        /// </summary>
        public DbSet<User> Users    { get; set; }
        public DbSet<GioHang> GioHangs    { get; set; }
        public DbSet<SanPham> SanPhams    { get; set; }
        public DbSet<HoaDon> HoaDons    { get; set; }
        public DbSet<HDCT> HDCTs    { get; set; }
        public DbSet<GHCT> GHCTs    { get; set; }


        //gắn chuỗi kết nối
        //ctr + . => generate overide => tích OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NGUYEN_NGOC_HOA\\HOANN; Database=Tutor_So1;Trusted_Connection= True;" +
                                "TrustServerCertificate=True");
        }

       


    }
}
