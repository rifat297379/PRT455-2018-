//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inv
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceiptDet
    {
        public int ReceiptDetId { get; set; }
        public Nullable<int> ReceiptId { get; set; }
        public Nullable<int> SrNo { get; set; }
        public Nullable<int> BillId { get; set; }
        public string BillNo { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<decimal> BillAmt { get; set; }
        public Nullable<decimal> RecvAmt { get; set; }
        public Nullable<decimal> DiscAmt { get; set; }
    }
}
