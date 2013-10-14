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
    
    public partial class Slab
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int SoldToId { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string Remarks { get; set; }
        public int WorkItemId { get; set; }
        public int ParentId { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual WorkItem WorkItem { get; set; }
    }
}
