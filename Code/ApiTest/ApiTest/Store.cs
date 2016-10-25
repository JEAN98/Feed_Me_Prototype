//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            this.Coupons = new HashSet<Coupon>();
            this.FeedBacks = new HashSet<FeedBack>();
        }
    
        public int StoreId { get; set; }
        public string UrlName { get; set; }
        public string CodName { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<double> Percentage { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PeriodId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coupon> Coupons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual PeriodType PeriodType { get; set; }
        public virtual User User { get; set; }
    }
}