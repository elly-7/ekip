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
    
    public partial class KullaniciBirimBilgileri
    {
        public int ID { get; set; }
        public string Kurum { get; set; }
        public string Bina { get; set; }
        public string Bolge { get; set; }
        public int KullaniciID { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
