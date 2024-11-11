using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }    
        public DateTime? SoldDate { get; set; }  
        public decimal? TotalMoney {  get; set; }
        public string? Status {  get; set; }

        //ThIẾT LẬP 1-n VS USER
        public User? User { get; set; }

        //khóa ngoại
        public Guid? UserId { get; set; }
        
        public IList<HDCT> HDCTs { get; set; }  



        
    }
}
