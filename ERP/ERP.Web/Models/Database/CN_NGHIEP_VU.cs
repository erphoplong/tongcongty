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
    
    public partial class CN_NGHIEP_VU
    {
        public CN_NGHIEP_VU()
        {
            this.CN_CHI_TIET_NGHIEP_VU = new HashSet<CN_CHI_TIET_NGHIEP_VU>();
        }
    
        public string ID { get; set; }
        public string TEN_NGHIEP_VU { get; set; }
        public string TRUC_THUOC { get; set; }
    
        public virtual ICollection<CN_CHI_TIET_NGHIEP_VU> CN_CHI_TIET_NGHIEP_VU { get; set; }
        public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }
    }
}
