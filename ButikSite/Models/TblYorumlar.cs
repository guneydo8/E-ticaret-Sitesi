//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ButikSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblYorumlar
    {
        public int Id { get; set; }
        public Nullable<int> Ürün { get; set; }
        public Nullable<int> Müşteri { get; set; }
        public string Konu { get; set; }
        public string Yorum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual TblMüşteriler TblMüşteriler { get; set; }
        public virtual TblÜrünler TblÜrünler { get; set; }
    }
}
