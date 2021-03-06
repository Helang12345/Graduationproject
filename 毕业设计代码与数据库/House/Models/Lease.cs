//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lease
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lease()
        {
            this.Facilities = new HashSet<Facilities>();
            this.LCollection = new HashSet<LCollection>();
            this.LImg = new HashSet<LImg>();
        }
    
        public int LeaseID { get; set; }
        public string LeaseAddress { get; set; }
        public string LeaseVillage { get; set; }
        public Nullable<int> LeaseFloor { get; set; }
        public Nullable<decimal> LeaseArea { get; set; }
        public string LeaseMaintain { get; set; }
        public string LeaseHStructure { get; set; }
        public Nullable<decimal> LeasePrice { get; set; }
        public Nullable<int> LeaseLease { get; set; }
        public Nullable<int> LeaseCheckin { get; set; }
        public Nullable<int> LeaseParkinglot { get; set; }
        public Nullable<int> LeaseOrientation { get; set; }
        public Nullable<int> LeaseElevator { get; set; }
        public Nullable<int> LeaseWaterint { get; set; }
        public Nullable<int> LeaseElectric { get; set; }
        public Nullable<int> LeaseGas { get; set; }
        public Nullable<int> LeaseHeating { get; set; }
        public Nullable<int> LeaseLeaseTerm { get; set; }
        public Nullable<int> LeaseTime { get; set; }
        public Nullable<int> TransactionStatus { get; set; }
        public Nullable<System.DateTime> NewTime { get; set; }
        public string Phone { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SalesmanID { get; set; }
        public Nullable<int> UState { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facilities> Facilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LCollection> LCollection { get; set; }
        public virtual Salesman Salesman { get; set; }
        public virtual Userd Userd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LImg> LImg { get; set; }
    }
}
