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
    
    public partial class AcilServisVakaBilgileri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AcilServisVakaBilgileri()
        {
            this.AcilServisVakaTanilari = new HashSet<AcilServisVakaTanilari>();
        }
    
        public int ID { get; set; }
        public int KurumKodu { get; set; }
        public string HastaTCKimlikNo { get; set; }
        public string HastaEkipNo { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public Nullable<System.DateTime> BasvuruTarihi { get; set; }
        public string HekimAdi { get; set; }
        public Nullable<System.DateTime> TaburculukTarihi { get; set; }
        public string GerceklestirilenIslemler { get; set; }
        public string TaburculukNotlari { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AcilServisVakaTanilari> AcilServisVakaTanilari { get; set; }
    }
}
