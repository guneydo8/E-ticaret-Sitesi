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
    
    public partial class TblÜrünler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblÜrünler()
        {
            this.TblSatışlar = new HashSet<TblSatışlar>();
            this.TblYorumlar = new HashSet<TblYorumlar>();
            this.TblFavoriler = new HashSet<TblFavoriler>();
            this.TblSepetim = new HashSet<TblSepetim>();
        }
    
        public int Id { get; set; }
        public string ÜrünAd { get; set; }
        public Nullable<int> Kategori { get; set; }
        public Nullable<int> Marka { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<decimal> AlışFiyat { get; set; }
        public Nullable<decimal> SatışFiyat { get; set; }
        public string ÜrünBilgi { get; set; }
        public string ÜrünGörsel { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string Cinsiyet { get; set; }
    
        public virtual TblKategoriler TblKategoriler { get; set; }
        public virtual TblMarkalar TblMarkalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSatışlar> TblSatışlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblYorumlar> TblYorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFavoriler> TblFavoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSepetim> TblSepetim { get; set; }
    }
}
