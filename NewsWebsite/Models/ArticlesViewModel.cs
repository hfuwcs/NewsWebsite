using NewsWebsite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsWebsite.Models
{
    public class ArticlesViewModel
    {
        public int ID_BAIVIET { get; set; }
        public string TIEUDE { get; set; }
        public string NOIDUNG { get; set; }
        public string TenTheLoai { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
        public string TenTacGia { get; set; }
        public double? DiemDanhGia { get; set; }
        public List<BINHLUAN> CacBinhLuan { get; set; }
    }
}