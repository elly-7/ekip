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
    
    public partial class HastaYakinBilgileri
    {
        public int ID { get; set; }
        public int HastaID { get; set; }
        public string YakinAdi { get; set; }
        public string YakinSoyadi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string YakinlikDerecesi { get; set; }
    
        public virtual Hastalar Hastalar { get; set; }
    }
}
