//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnChuyenNganh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietSanPham = new HashSet<ChiTietSanPham>();
            this.PhanHoi = new HashSet<PhanHoi>();
        }
    
        public int SanPhamID { get; set; }
        [Index("IX_TenSanPham", IsUnique = true)]
        public string TenSanPham { get; set; }
        [Index("IX_MoTa", IsUnique = true)]
        public string MoTa { get; set; }
        public Nullable<int> SoLuongDaBan { get; set; }
        public Nullable<int> SoSaoTB { get; set; }
        public Nullable<int> DanhMucID { get; set; }
        public Nullable<bool> KichHoat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPham { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanHoi> PhanHoi { get; set; }
    }
}
