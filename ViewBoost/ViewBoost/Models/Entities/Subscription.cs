//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViewBoost.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscription
    {
        public System.Guid id { get; set; }
        public System.Guid donatorId { get; set; }
        public System.Guid receiverId { get; set; }
        public System.Guid type { get; set; }
    
        public virtual Type Type1 { get; set; }
    }
}
