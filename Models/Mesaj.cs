//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _SiparisTakipSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesaj
    {
        public int MesajId { get; set; }
        public Nullable<int> MagazaId { get; set; }
        public Nullable<int> UreticiId { get; set; }
        public string Mesaj1 { get; set; }
    
        public virtual Magaza Magaza { get; set; }
        public virtual Uretici Uretici { get; set; }
    }
}
