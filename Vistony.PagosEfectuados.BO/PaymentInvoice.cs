using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistony.PagosEfectuados.BO
{
    public class PaymentInvoice
    {
        public int LineNum { get; set; }
        public string DocEntry { get; set; }
        public string SumApplied { get; set; }
        public int AppliedFC { get; set; }
        public string AppliedSys { get; set; }
        public int DocRate { get; set; }
        public int DocLine { get; set; }
        public string InvoiceType { get; set; }
        public int DiscountPercent { get; set; }
        public int PaidSum { get; set; }
        public int InstallmentId { get; set; }
        public int WitholdingTaxApplied { get; set; }
        public int WitholdingTaxAppliedFC { get; set; }
        public int WitholdingTaxAppliedSC { get; set; }
        public string LinkDate { get; set; }
        public string DistributionRule { get; set; }
        public string DistributionRule2 { get; set; }
        public string DistributionRule3 { get; set; }
        public string DistributionRule4 { get; set; }
        public string DistributionRule5 { get; set; }
        public int TotalDiscount { get; set; }
        public int TotalDiscountFC { get; set; }
        public int TotalDiscountSC { get; set; }
        public string U_SYP_SERRET { get; set; }
        public int U_SYP_RET { get; set; }
        public int U_SYP_TRE { get; set; }
        public string U_SYP_NUMCP { get; set; }
        public string U_SYP_NUMCRET { get; set; }
        public string U_SYP_FECHARET { get; set; }
    }
}
