using Data_Tutor.IRepository;
using Data_Tutor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tutor.Repository
{
    public class AllRepository<H> : IAllRepository<H> where H : class
    {
        //gọi class đại diện cho csdl
        private readonly TutorDbContext _db;
        DbSet<H> _dbSet;   // crud trên dbset vì nó đại diện cho bảng
                              // cần db set nào thì gán = dbset đó

        //add DI
        public AllRepository(TutorDbContext db, DbSet<H> dbset)
        {
            _db = db; ;
            _dbSet = dbset;
        }

        public bool CreateObj(H obj)
        {
            try
            {
                _dbSet.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public bool DeleteObj(dynamic id)
        {
            try
            {
                //tìm đối  tượng cần xóa
                var deleteObj = getByid(id);
                _dbSet.Remove(deleteObj);
                _db.SaveChanges();
                return true;
                

            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<H> GetAll()
        {
            //vì dbset đã đc tiêm vào repository nên mình k cần lấy db.tenbang nữa mà mình lấy thhawfng
            return _dbSet.ToList();
                
        }

        public H getByid(dynamic id) // tìm kiếm theo id
        {
            return _dbSet.Find(id);
        }

        public bool UpdateObj(H obj)
        {
            try
            {
                _dbSet.Update(obj);
                _db.SaveChanges();
                return true;

            }
            catch (Exception) { return false; }

        }
    }
}
