//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScholarshipHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class University
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public University()
        {
            this.UniversityOffers = new HashSet<UniversityOffer>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        [DisplayName("Username")]
        public string username { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        public string Contact { get; set; }
        public string AddressLine { get; set; }
        [DisplayName("Country")]
        public string Contry { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Motto { get; set; }
        public string Mission { get; set; }
        public string Vision { get; set; }
        [DisplayName("Description")]
        public string descripton { get; set; }
        [DisplayName("Approval Document")]
        public string ApprovalPath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UniversityOffer> UniversityOffers { get; set; }
    }
}
