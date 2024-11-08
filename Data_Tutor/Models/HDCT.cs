
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
   
    public class HDCT
    {
        public Guid iD {  get; set; }
        [ForeignKey("SanPham")]
        public Guid SanPhamId { get; set; }  // đóng vai trò là khóa ngoại// 1 cùng kiểu dữ liệu vs khóa chính của bảng 1/ 
        public Guid HoaDonId { get; set; }
        public decimal TotalMoney {  get; set; }
        public SanPham? SanPham { get; set; }
        public HoaDon? HoaDon { get; set; }
    
    }
}
