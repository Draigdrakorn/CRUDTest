//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCSTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class QualificationList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QualificationList()
        {
            this.EMP_QUALIFICATION = new HashSet<EMP_QUALIFICATION>();
        }
    
        public int Q_Id { get; set; }
        public string Q_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMP_QUALIFICATION> EMP_QUALIFICATION { get; set; }
    }
}
