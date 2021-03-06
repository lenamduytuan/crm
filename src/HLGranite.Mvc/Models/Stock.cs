//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HLGranite.Mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public Stock()
        {
            this.Active = true;
            this.Nisans = new HashSet<Nisan>();
            this.Slabs = new HashSet<Slab>();
            this.Tombs = new HashSet<Tomb>();
        }
    
        public int Id { get; set; }
        public short StockTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Remarks { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<Nisan> Nisans { get; set; }
        public virtual ICollection<Slab> Slabs { get; set; }
        public virtual StockType StockType { get; set; }
        public virtual ICollection<Tomb> Tombs { get; set; }
    }
}
