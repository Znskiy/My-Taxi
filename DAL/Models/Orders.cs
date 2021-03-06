//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Create { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> FinishTime { get; set; }
        public int UserId { get; set; }
        public Nullable<int> CarId { get; set; }
        public string Description { get; set; }
        public Nullable<int> Price { get; set; }
        public bool Cancel { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }
        public Nullable<bool> Finish { get; set; }
        public Nullable<bool> PayCash { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Users Users { get; set; }
    }
}
