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
    
    public partial class DM_HANG_TON_KHO
    {
        public string MA_HANG_HT { get; set; }
        public string MA_KHO { get; set; }
        public int SL_TON { get; set; }
    
        public virtual DM_KHO DM_KHO { get; set; }
        public virtual DM_HANG_HOA DM_HANG_HOA { get; set; }
    }
}