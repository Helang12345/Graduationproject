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
    
    public partial class Selling
    {
        public int SellingID { get; set; }
        public string SellingTraffic { get; set; }
        public string SellingInfrastructure { get; set; }
        public string SellingTaxation { get; set; }
        public string SellingIntroduce { get; set; }
        public string SellingVillage { get; set; }
        public Nullable<int> SellID { get; set; }
    
        public virtual Sell Sell { get; set; }
    }
}
