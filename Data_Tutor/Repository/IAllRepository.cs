using Data_Tutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.IRepository
{
    //cách khai báo 1 interface

    //pvi truy cập + interface + tên
    //truyền đối tượng T
    //T ở đây là 1 class
    internal interface IAllRepository< T> where T : class
    {
        public ICollection<T> GetAll(); // lấy ra tất cả thông tin của class T

        //tìm kiếm theo id
        public T getByid(dynamic id); // dynamic đại diện cho dateType

        //Tạo ms và thêm trong db
        public bool CreateObj(T obj);
        //sửa và lưu lại trong db
        public bool UpdateObj(T obj);
        public  bool DeleteObj(dynamic id);

    }
}
