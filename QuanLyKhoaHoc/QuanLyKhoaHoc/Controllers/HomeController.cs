using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyKhoaHoc.Models;

namespace QuanLyKhoaHoc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        DataClasses1DataContext db = new DataClasses1DataContext();
        public ActionResult Index()
        {
            List<MonHoc> lst = db.MonHocs.ToList();
            return View(lst);
        }

        public ActionResult DanhMucKhoaHoc()
        {
            List<KhoaHoc> lst = db.KhoaHocs.ToList();
            return PartialView(lst);
        }

        
        public ActionResult HienThiMonHocTheoKhoaHoc(int id)
        {
            List<MonHoc> lst = db.MonHocs.ToList();
            List<MonHoc> lst2 = lst.Where(t => t.KhoaHocID == id).ToList();
            return View("Index", lst2);
            //List<MonHoc> lst = db.MonHocs.Where(s => s.ID == id).ToList();
            //return View("Index", lst);
        }

    

        


    }
}
