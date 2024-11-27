using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsWebsite.Repository;
namespace NewsWebsite.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        static TinTucDBEntities db = new TinTucDBEntities();
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TAIKHOAN user)
        {
            TAIKHOAN tk = db.TAIKHOAN.FirstOrDefault(x => x.USERNAME == user.USERNAME);
            if (tk == null) {                 
                ViewBag.error = "Tài khoản không tồn tại";
                return View();
            }
            else
            {
                if(tk.PASSWORD==user.PASSWORD)
                {
                    Session["TaiKhoan"] = tk;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.error = "Mật khẩu không đúng";
                    return View();
                }
            }
        }
        public ActionResult DangKy()
        {
            ViewBag.GIOITINH = new SelectList(new List<SelectListItem>
            {
                new SelectListItem{Selected = true, Text = "Nam", Value = "Nam"},
                new SelectListItem{Selected = false, Text = "Nữ", Value = "Nữ"}
            }, "Value","Text",1);
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(TAIKHOAN user)
        {
            if (ModelState.IsValid)
            {
                TAIKHOAN tk = db.TAIKHOAN.FirstOrDefault(x => x.USERNAME == user.USERNAME);
                if (tk == null)
                {
                    db.TAIKHOAN.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("DangNhap");
                }
                else
                {
                    ViewBag.error = "Tài khoản đã tồn tại";
                    return View();
                }
            }
            return View();
        }
        public ActionResult DangXuat()
        {
           Session["TaiKhoan"] = null;
           return RedirectToAction("Index", "Home");
        }
    }
}