using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string ImgUrl {  get; set; }


        //thiết lập mqh  1-nn vs ghct
        //IColection, IList, Collection, List: đều thể hiện bảng nhiều
        // GHCTs => navigation
        public ICollection<GHCT> GHCTs { get; set; }
        public ICollection<HDCT> HDCTs { get; set; }
    }
}
