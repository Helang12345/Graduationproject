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
    
    public partial class Transactions
    {
        public int TransactionID { get; set; }
        public string TransactionTime { get; set; }
        public string TransactionCommodity { get; set; }
        public string TransactionOldTransaction { get; set; }
        public string TransactionPurpose { get; set; }
        public string TransactionYears { get; set; }
        public string TransactionPropertyright { get; set; }
        public string TransactionMortgage { get; set; }
        public string TransactionPOC { get; set; }
        public Nullable<int> SellID { get; set; }
    
        public virtual Sell Sell { get; set; }
    }
}
