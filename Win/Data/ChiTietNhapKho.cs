//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Win.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ChiTietNhapKho
    {
        public int MaChiTietNhapKho { get; set; }
        public Nullable<int> MaNhapKho { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual NhapKho NhapKho { get; set; }
        public virtual SanPham SanPham { get; set; }

        [NotMapped]
        public string TenSanPham { get; set; }
        [NotMapped]
        public decimal? ThanhTien { get; set; }
    }
}
