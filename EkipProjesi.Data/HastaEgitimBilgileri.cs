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
    
    public partial class HastaEgitimBilgileri
    {
        public int ID { get; set; }
        public int HastaID { get; set; }
        public Nullable<int> OgrenimDurumu { get; set; }
        public Nullable<int> LiseTuru { get; set; }
        public string Ilkokul { get; set; }
        public string Ortaokul { get; set; }
        public string Lise { get; set; }
        public string Universite { get; set; }
        public string Fakulte { get; set; }
        public string Bolum { get; set; }
        public string IsGecmisi { get; set; }
        public string SertifikaVeYeterlilikler { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<int> KaydedenKullaniciID { get; set; }
        public Nullable<int> GuncelleyenKullaniciID { get; set; }
    }
}
