//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_ROLE
    {
        public TBL_ROLE()
        {
            this.TBL_ADMIN = new HashSet<TBL_ADMIN>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
    
        public virtual ICollection<TBL_ADMIN> TBL_ADMIN { get; set; }
    }
}
