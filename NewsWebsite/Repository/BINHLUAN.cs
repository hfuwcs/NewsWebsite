//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsWebsite.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class BINHLUAN
    {
        public int ID_BINHLUAN { get; set; }
        public Nullable<int> ID_BAIVIET { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAYBINHLUAN { get; set; }
    
        public virtual BAIVIET BAIVIET { get; set; }
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
