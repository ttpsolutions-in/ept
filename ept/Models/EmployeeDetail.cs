//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ept.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeDetail()
        {
            this.EmployeeAccounts = new HashSet<EmployeeAccount>();
        }
    
        public short EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public Nullable<byte> DesignationId { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> Salary { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<byte> EmploymentTypeId { get; set; }
        public Nullable<byte> EmpRoleId { get; set; }
        public Nullable<byte> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeAccount> EmployeeAccounts { get; set; }
        public virtual EmployeeDesignation EmployeeDesignation { get; set; }
        public virtual EmployeeRole EmployeeRole { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }
    }
}
