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
    
    public partial class PurInvoiceMst
    {
        public int InvId { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceNo { get; set; }
        public string BillNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<int> TotalLevelTaxId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public Nullable<int> CreditDays { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> TotalAmt { get; set; }
        public Nullable<decimal> IGstPer { get; set; }
        public Nullable<decimal> IGstAmt { get; set; }
        public Nullable<decimal> CGstPer { get; set; }
        public Nullable<decimal> CGstAmt { get; set; }
        public Nullable<decimal> SGstPer { get; set; }
        public Nullable<decimal> SGstAmt { get; set; }
        public Nullable<decimal> FreightPer { get; set; }
        public Nullable<decimal> FreightAmt { get; set; }
        public Nullable<decimal> PackingPer { get; set; }
        public Nullable<decimal> PackingAmt { get; set; }
        public Nullable<decimal> DiscountPer { get; set; }
        public Nullable<decimal> DiscountAmt { get; set; }
        public Nullable<decimal> NetAmt { get; set; }
        public string Status { get; set; }
        public string ChallanNo { get; set; }
        public Nullable<System.DateTime> ChallanDate { get; set; }
        public Nullable<int> InvNo { get; set; }
        public string GSTType { get; set; }
        public Nullable<bool> GSTTotalLevel { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string LrNo { get; set; }
        public string VehicleNo { get; set; }
        public string TransporterName { get; set; }
        public Nullable<decimal> Oth1_AddPer { get; set; }
        public Nullable<decimal> Oth1_AddAmt { get; set; }
        public string Oth1_AddTag { get; set; }
        public Nullable<decimal> DueAmt { get; set; }
    }
}
