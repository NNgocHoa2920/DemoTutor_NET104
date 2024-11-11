using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
    public class GioHang
    {
        public Guid Id { get; set; }
        public string?   UserName { get; set; }

        //cấu hình 1-1 vs bảng usser

        public User? User { get; set; }

        public Guid? UserId { get; set; }  // khóa ngoại kn

        //thiết lập mqh 1-n vs ghct

        public ICollection<GHCT> GHCTs { get; set; }    

    }
}
