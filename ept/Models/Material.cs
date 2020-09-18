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
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.MaterialInventories = new HashSet<MaterialInventory>();
            this.Sales = new HashSet<Sale>();
        }
    
        public int MaterialId { get; set; }
        public string Descriptioin { get; set; }
        public Nullable<int> NoOfPiecePerUnit { get; set; }
        public Nullable<decimal> RetailRate { get; set; }
        public Nullable<decimal> WholeSaleRate { get; set; }
        public string CostingPrice { get; set; }
        public Nullable<decimal> QuantityInHand { get; set; }
        public Nullable<decimal> ReorderLevel { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string Product { get; set; }
        public string Model { get; set; }
        public string Size1 { get; set; }
        public string Size2 { get; set; }
        public Nullable<decimal> StdPkg { get; set; }
        public Nullable<decimal> BoxQty { get; set; }
        public Nullable<short> ItemCategoryId { get; set; }
        public string DisplayName { get; set; }
        public Nullable<byte> Active { get; set; }
    
        public virtual ItemCategory ItemCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialInventory> MaterialInventories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
