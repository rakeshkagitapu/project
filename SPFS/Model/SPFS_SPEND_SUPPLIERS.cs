//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPFS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPFS_SPEND_SUPPLIERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPFS_SPEND_SUPPLIERS()
        {
            this.SPFS_LINK_ERP = new HashSet<SPFS_LINK_ERP>();
        }
    
        public int Spend_supplier_ID { get; set; }
        public int SiteID { get; set; }
        public Nullable<int> Gdis_org_Parent_ID { get; set; }
        public int CID { get; set; }
        public string Entity_Type { get; set; }
        public decimal Total_Spend { get; set; }
        public int Reject_incident_count { get; set; }
        public int Reject_parts_count { get; set; }
        public System.DateTime Created_date { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Modified_by { get; set; }
    
        public virtual SPFS_SITES SPFS_SITES { get; set; }
        public virtual SPFS_SUPPLIERS SPFS_SUPPLIERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPFS_LINK_ERP> SPFS_LINK_ERP { get; set; }
    }
}
