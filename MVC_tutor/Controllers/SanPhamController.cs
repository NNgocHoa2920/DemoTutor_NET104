using Data_Tutor.Models;
using Data_Tutor.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVC_tutor.Controllers
{
    public class SanPhamController : Controller
    {
        //gọi class đại dieejen csdl
        TutorDbContext _db;
        AllRepository<SanPham> _res;  // vì đã thao tác ở tầng respository
        DbSet<SanPham> _dbSet;
        public SanPhamController(TutorDbContext db, AllRepository<SanPham> res, DbSet<SanPham> dbset)
        {
            _db = db;
            _res = res;
            _dbSet = dbset;
        }

        
        // GET: SanPhamController
        public ActionResult Index()
        {
            var data = _res.GetAll();
            return View(data);
        }

        // GET: SanPhamController/Details/5
        public ActionResult Details(int id)
        {
            var data = _res.getByid(id);
            return View();
        }

        // GET: SanPhamController/Create
        public ActionResult Create()  // dùng để tạo view form crete
        {
            return View();
        }

        // POST: SanPhamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sp, IFormFile imgFile)
            //kết hợp các đường dẫn để lưu ảnh
        {
             string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","img", imgFile.Name);
            //mở stream lên để lưu file
            var stream = new FileStream(path, FileMode.Create);

            //sao chép nd file tải leen vào stream
            imgFile.CopyTo(stream);
            //lưu đương dẫn file vvafo  đối tượng sản phẩm
            sp.ImgUrl = imgFile.FileName;
            _res.CreateObj(sp);
            return RedirectToAction("Index");

        }

        // GET: SanPhamController/Edit/5
        public ActionResult Edit(int id)  // tạo ra form edit có chứa dữ liệu cần edit
        {

            //tìm  kiếm đối tượng cần edit
            var spEdit = _res.getByid(id);

            
            return View(spEdit);
        }

        // POST: SanPhamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int  id, SanPham sp, IFormFile imgFile)
        {
          //lấy đối tượng sanpham hien tai từ csdl
          var Editsp = _res.getByid(id);
            if (Editsp == null) { return NotFound(); }

            if (imgFile != null)
            {
                //định nghĩa đường dẫ để lưu ảnh mới
                string fileName = Path.GetFileName(imgFile.FileName);
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", fileName);
                //kkieerm tra và tao thư mục nếu chưa tồn tại
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                } 

                //lưu hình ảnh mới
                using(var stream = new FileStream(filePath, FileMode.Create))
                {
                    imgFile.CopyTo(stream);
                }
                //cập nhật các thuộc tính còn lạoi
                Editsp.Name = fileName;
  
            }
            //lw đối tượng đã cập nhật
            _res.UpdateObj(Editsp);
            return RedirectToAction("Index");
        }

        // GET: SanPhamController/Delete/5
        public ActionResult Delete(int id)
        {
           _res.DeleteObj(id);
            return RedirectToAction("Index");
        }

        
    }
}
