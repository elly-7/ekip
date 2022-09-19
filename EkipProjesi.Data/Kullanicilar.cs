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
    
    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            this.KullaniciBirimBilgileri = new HashSet<KullaniciBirimBilgileri>();
            this.KullaniciErisimBilgileri = new HashSet<KullaniciErisimBilgileri>();
            this.HastaNotlari = new HashSet<HastaNotlari>();
            this.KullaniciGorevTakip = new HashSet<KullaniciGorevTakip>();
        }
    
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Nullable<int> PersonelId { get; set; }
        public string TC { get; set; }
        public Nullable<bool> KullaniciDurumu { get; set; }
        public Nullable<bool> SifreKontrol { get; set; }
        public byte[] FotoByte { get; set; }
        public string FotoContentType { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<int> KanGrubu { get; set; }
        public string MedeniDurum { get; set; }
        public string Telefon { get; set; }
        public string AdSoyad { get; set; }
        public string Meslek { get; set; }
        public Nullable<System.DateTime> IseBaslamaTarihi { get; set; }
        public int KurumID { get; set; }
        public Nullable<int> KaydedenKullaniciID { get; set; }
        public string KurumTelefonu { get; set; }
        public string KurumEposta { get; set; }
        public int HizmetMerkeziID { get; set; }
        public string ExcelID { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciBirimBilgileri> KullaniciBirimBilgileri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciErisimBilgileri> KullaniciErisimBilgileri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaNotlari> HastaNotlari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciGorevTakip> KullaniciGorevTakip { get; set; }
        public virtual Kurumlar Kurumlar { get; set; }
        public virtual KurumHizmetMerkezleri KurumHizmetMerkezleri { get; set; }
    }
}
