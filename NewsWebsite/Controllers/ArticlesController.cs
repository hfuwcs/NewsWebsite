using NewsWebsite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsWebsite.Models;
namespace NewsWebsite.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        static TinTucDBEntities db = new TinTucDBEntities();
        public ActionResult ShowArticles()
        {
            IList<BAIVIET> articles =  db.BAIVIET.Where(a=>a.TRANGTHAI == "Đã duyệt").ToList();
            IList<ArticlesViewModel> articlesView = new List<ArticlesViewModel>();
            foreach (var item in articles)
            {
                articlesView.Add(new ArticlesViewModel()
                {
                    ID_BAIVIET = item.ID_BAIVIET,
                    TIEUDE = item.TIEUDE,
                    NOIDUNG = item.NOIDUNG,
                    TenTheLoai = db.THELOAI.Where(a => a.ID_THELOAI == item.ID_THELOAI).FirstOrDefault().TENTHELOAI,
                    NGAYDANG = item.NGAYDANG,
                    TenTacGia = db.TAIKHOAN.Where(a => a.ID_TAIKHOAN == item.TACGIA_ID).FirstOrDefault().HOTEN
                });
            }

            return View(articlesView);
        }
        public ActionResult ShowArticleDetail(int ID_BAIVIET)
        {
            BAIVIET bAIVIET = db.BAIVIET.Where(a => a.ID_BAIVIET == ID_BAIVIET).FirstOrDefault();
            ArticlesViewModel articlesView = new ArticlesViewModel()
            {
                ID_BAIVIET = bAIVIET.ID_BAIVIET,
                TIEUDE = bAIVIET.TIEUDE,
                NOIDUNG = bAIVIET.NOIDUNG,
                TenTheLoai = db.THELOAI.Where(a => a.ID_THELOAI == bAIVIET.ID_THELOAI).FirstOrDefault().TENTHELOAI,
                NGAYDANG = bAIVIET.NGAYDANG,
                TenTacGia = db.TAIKHOAN.Where(a => a.ID_TAIKHOAN == bAIVIET.TACGIA_ID).FirstOrDefault().HOTEN
            };
            return View(articlesView);
        }
    }
}