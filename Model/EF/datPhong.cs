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
    
    public partial class datPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public datPhong()
        {
            this.hoaDons = new HashSet<hoaDon>();
        }
    
        public int maDatPhong { get; set; }
        public Nullable<int> maKhachHang { get; set; }
        public Nullable<int> maPhong { get; set; }
        public Nullable<System.DateTime> ngayBatDau { get; set; }
        public Nullable<System.DateTime> ngayKetThuc { get; set; }
        public Nullable<decimal> gia { get; set; }
        public string mieuTaDatPhong { get; set; }
    
        public virtual danhSachPhong danhSachPhong { get; set; }
        public virtual khachHang khachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoaDon> hoaDons { get; set; }
    }
}