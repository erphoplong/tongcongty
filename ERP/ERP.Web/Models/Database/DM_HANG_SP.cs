//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_HANG_SP
    {
        public DM_HANG_SP()
        {
            this.DM_HANG_SP1 = new HashSet<DM_HANG_SP>();
            this.DM_TONKHO_HANG = new HashSet<DM_TONKHO_HANG>();
            this.DM_HANG_HOA = new HashSet<DM_HANG_HOA>();
        }
    
        public string MA_NHOM_HANG { get; set; }
        public string TEN_NHOM_HANG { get; set; }
        public string MA_NHOM_HANG_CHA { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual ICollection<DM_HANG_SP> DM_HANG_SP1 { get; set; }
        public virtual DM_HANG_SP DM_HANG_SP2 { get; set; }
        public virtual ICollection<DM_TONKHO_HANG> DM_TONKHO_HANG { get; set; }
        public virtual ICollection<DM_HANG_HOA> DM_HANG_HOA { get; set; }
    }
}
