﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            this.BAIVIET = new HashSet<BAIVIET>();
            this.BINHCHON = new HashSet<BINHCHON>();
            this.BINHLUAN = new HashSet<BINHLUAN>();
            this.DANHGIA = new HashSet<DANHGIA>();
        }
    
        public int ID_TAIKHOAN { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập"),StringLength(10,ErrorMessage ="Tên ngắn quá bạn eii")]
        public string USERNAME { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu"),DataType(DataType.Password),StringLength(10,ErrorMessage ="Mật khẩu ngắn quá bạn eii")]
        public string PASSWORD { get; set; }
        public string DIACHI { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string DIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYDANGKY { get; set; }
        public string VAITRO { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string GIOITINH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAIVIET> BAIVIET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHCHON> BINHCHON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIA> DANHGIA { get; set; }
    }
}
