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
        //để an toàn thì trừ các khóa chính và 1 số thuộc tính bắt nhập thì cấc bạn cứ để ? để thể hiện 
        /// để thể hhieejn đc phép null hoặc k <summary>
        /// để thể hhieejn đc phép null hoặc k
        /// Ở trong visual nếu khai báo thuộc tính là Id thì nó sẽ ngầm định hiểu rằng đấy l
        /// </summary>
        [Key] 
        public Guid Id { get; set; }
        [Required]
        
        [StringLength(450, MinimumLength =5, ErrorMessage ="Độ dài phải từ 5-450 kí tự")]
        public string Name { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }

        //thể hiện mqh 1--1 vs giỏ hàng
        public GioHang? GioHang { get; set; }  
        //? thể hiện có hoặc k cũng được

        //thiết lập mqh 1-n vs bảng hd
        public IList<HoaDon> HoaDons { get; set; }
    }
}
