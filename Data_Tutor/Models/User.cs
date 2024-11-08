using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
   public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        
        [StringLength(450, MinimumLength =5, ErrorMessage ="Độ dài phải từ 5-450 kí tự")]
        public string Name { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }

        //thể hiện mqh 1--1 vs giỏ hàng
        public GioHang? GioHang { get; set; }  // tự động tạo ra 1 thuộc tính khóa ngoại
        //? thể hiện có hoặc k cũng được

        //thiết lập mqh 1-n vs bảng hd
        public IList<HoaDon> HoaDons { get; set; }
    }
}
