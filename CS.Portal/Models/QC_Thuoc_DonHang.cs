//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class QC_Thuoc_DonHang
    {
        public int id { get; set; }
        public Nullable<int> idthuoc { get; set; }
        public Nullable<int> iddonhang { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<decimal> giatien { get; set; }
        public Nullable<decimal> thanhtien { get; set; }
    
        public virtual QC_Thuoc QC_Thuoc { get; set; }
        public virtual QC_DonHang QC_DonHang { get; set; }
    }
}