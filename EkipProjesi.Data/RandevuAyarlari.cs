//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkipProjesi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RandevuAyarlari
    {
        public int ID { get; set; }
        public int KurumID { get; set; }
        public int PoliklinikTuruID { get; set; }
        public int Gun { get; set; }
        public System.TimeSpan BaslangicSaati { get; set; }
        public System.TimeSpan BitisSaati { get; set; }
        public int SlotSayisi { get; set; }
        public System.DateTime LogTarihi { get; set; }
        public Nullable<System.DateTime> GuncellemeTarihi { get; set; }
        public bool Durum { get; set; }
        public Nullable<System.DateTime> PasifBaslangicTarihi { get; set; }
        public Nullable<System.DateTime> PasifBitisTarihi { get; set; }
        public Nullable<int> KaydedenKullaniciID { get; set; }
    
        public virtual Kurumlar Kurumlar { get; set; }
        public virtual KurumPoliklinikTurleri KurumPoliklinikTurleri { get; set; }
    }
}
