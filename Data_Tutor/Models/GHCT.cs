﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
    public class GHCT
    {
        [Key]
        public Guid Id { get; set; }    
        public int? SanPhamId { get; set; }  // khóa ngoại
        public Guid? GioHangId { get; set; } //khóa ngoại

        //khởi tajao đối tượng sp và gh để thể hiện bảng 1
        public GioHang? GioHang { get; set; }   
        public  SanPham? SanPham { get; set; }
             

        public int? SoLuong {  get; set; }

    }
}
