//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class khachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khachHang()
        {
            this.datPhongs = new HashSet<datPhong>();
        }
    
        public int maKhachHang { get; set; }
        public string tenKhachHang { get; set; }
        public string tenDangNhap { get; set; }
        public string matKhau { get; set; }
        public Nullable<int> maSoThe { get; set; }
        public string diaChi { get; set; }
        public string mieuTaKhachHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<datPhong> datPhongs { get; set; }
        public virtual theKhachHang theKhachHang { get; set; }
    }
}
