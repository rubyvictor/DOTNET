//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueTransactionExample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producer()
        {
            this.Movies = new HashSet<Movy>();
        }
    
        public string ProducerID { get; set; }
        public string ProducerName { get; set; }
        public string CountryCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movy> Movies { get; set; }
        public virtual ProducerWebSite ProducerWebSite { get; set; }
    }
}
