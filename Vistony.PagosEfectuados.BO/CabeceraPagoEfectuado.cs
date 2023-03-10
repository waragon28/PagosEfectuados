using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistony.PagosEfectuados.BO
{
    public class CabeceraPagoEfectuado
    {
        //[JsonProperty("odata.metadata")]
       // public string odatametadata { get; set; }
        public int DocNum { get; set; }
        public string DocType { get; set; }
        public string HandWritten { get; set; }
        public string Printed { get; set; }
        public string DocDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Address { get; set; }
        public object CashAccount { get; set; }
        public string DocCurrency { get; set; }
        public int CashSum { get; set; }
        public object CheckAccount { get; set; }
        public string TransferAccount { get; set; }
        public string TransferSum { get; set; }
        public string TransferDate { get; set; }
        public string TransferReference { get; set; }
        public string LocalCurrency { get; set; }
        public int DocRate { get; set; }
        public string Reference1 { get; set; }
        public object Reference2 { get; set; }
        public object CounterReference { get; set; }
        public object Remarks { get; set; }
        public string JournalRemarks { get; set; }
        public string SplitTransaction { get; set; }
        public int ContactPersonCode { get; set; }
        public string ApplyVAT { get; set; }
        public string TaxDate { get; set; }
        public int Series { get; set; }
        public object BankCode { get; set; }
        public object BankAccount { get; set; }
        public int DiscountPercent { get; set; }
        public object ProjectCode { get; set; }
        public string CurrencyIsLocal { get; set; }
        public int DeductionPercent { get; set; }
        public int DeductionSum { get; set; }
        public int CashSumFC { get; set; }
        public int CashSumSys { get; set; }
        public object BoeAccount { get; set; }
        public int BillOfExchangeAmount { get; set; }
        public object BillofExchangeStatus { get; set; }
        public int BillOfExchangeAmountFC { get; set; }
        public int BillOfExchangeAmountSC { get; set; }
        public object BillOfExchangeAgent { get; set; }
        public object WTCode { get; set; }
        public int WTAmount { get; set; }
        public int WTAmountFC { get; set; }
        public int WTAmountSC { get; set; }
        public object WTAccount { get; set; }
        public int WTTaxableAmount { get; set; }
        public string Proforma { get; set; }
        public object PayToBankCode { get; set; }
        public object PayToBankBranch { get; set; }
        public object PayToBankAccountNo { get; set; }
        public string PayToCode { get; set; }
        public object PayToBankCountry { get; set; }
        public string IsPayToBank { get; set; }
        public string PaymentPriority { get; set; }
        public object TaxGroup { get; set; }
        public int BankChargeAmount { get; set; }
        public int BankChargeAmountInFC { get; set; }
        public int BankChargeAmountInSC { get; set; }
        public int UnderOverpaymentdifference { get; set; }
        public int UnderOverpaymentdiffSC { get; set; }
        public int WtBaseSum { get; set; }
        public int WtBaseSumFC { get; set; }
        public int WtBaseSumSC { get; set; }
        public string VatDate { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentType { get; set; }
        public int TransferRealAmount { get; set; }
        public string DocObjectCode { get; set; }
        public string DocTypte { get; set; }
        public string DueDate { get; set; }
        public object LocationCode { get; set; }
        public string Cancelled { get; set; }
        public string ControlAccount { get; set; }
        public int UnderOverpaymentdiffFC { get; set; }
        public string AuthorizationStatus { get; set; }
        public object BPLID { get; set; }
        public object BPLName { get; set; }
        public object VATRegNum { get; set; }
        public object BlanketAgreement { get; set; }
        public string PaymentByWTCertif { get; set; }
        public object Cig { get; set; }
        public object Cup { get; set; }
        public object AttachmentEntry { get; set; }
        public object SignatureInputMessage { get; set; }
        public object SignatureDigest { get; set; }
        public object CertificationNumber { get; set; }
        public object PrivateKeyVersion { get; set; }
        public object U_SYP_MPPG { get; set; }
        public string U_SYP_TPOOPER { get; set; }
        public string U_SYP_TPOOPERI { get; set; }
        public object U_SYP_PTSC { get; set; }
        public object U_SYP_PTCC { get; set; }
        public object U_SYP_FECHARET { get; set; }
        public object U_SYP_NUMORD { get; set; }
        public object U_SYP_CCOMP { get; set; }
        public object U_SYP_DETLOTE { get; set; }
        public string U_SYP_MPAGO { get; set; }
        public object U_SYP_METODP { get; set; }
        public object U_SYP_FLUJO { get; set; }
        public object U_SYP_ARCHIVO { get; set; }
        public object U_SYP_REF2 { get; set; }
        public object U_SYP_NUMER { get; set; }
        public string U_SYP_CCERSTATUS { get; set; }
        public object U_SYP_SERCCER { get; set; }
        public object U_SYP_SERER { get; set; }
        public string U_SYP_ESTCRET { get; set; }
        public object U_SYP_RETJRNL { get; set; }
        public object U_SYP_SERCP { get; set; }
        public object U_SYP_COD0325 { get; set; }
        public object U_SYP_COD0318 { get; set; }
        public string U_SYP_LTCANLET { get; set; }
        public object U_SYP_LTNroOper { get; set; }
        public string U_PZCreated { get; set; }
        public object U_PZSourceType { get; set; }
        public object U_PZSourceID { get; set; }
        public object U_PZidUsuario { get; set; }
        public object U_PZFolio { get; set; }
        public object U_PZExParameter { get; set; }
        public object U_PZExID { get; set; }
        public object U_PZExID2 { get; set; }
        public object U_SYP_FEHASH { get; set; }
        public object U_SYP_FERESP { get; set; }
        public string U_SYP_FEEST { get; set; }
        public object U_SYP_FEESUNAT { get; set; }
        public object U_SYP_FECDR { get; set; }
        public object U_SYP_FEXML { get; set; }
        public string U_SYP_FEMRV { get; set; }
        public object U_SYP_EXTERNO { get; set; }
        public object U_VIS_SlpCode { get; set; }
        public int U_SYP_FEMEX { get; set; }
        public object U_LB_NROTRANSITF { get; set; }
        public string U_LB_REGISTRARITF { get; set; }
        public object U_LB_CONTROLADD { get; set; }
        public object U_PaymentCode { get; set; }
        public List<object> PaymentChecks { get; set; }
        public List<PaymentInvoice> PaymentInvoices { get; set; }
        public List<object> PaymentCreditCards { get; set; }
        public List<object> PaymentAccounts { get; set; }
        public List<object> PaymentDocumentReferencesCollection { get; set; }
        //public BillOfExchange BillOfExchange { get; set; }
        public List<object> WithholdingTaxCertificatesCollection { get; set; }
        public List<object> ElectronicProtocols { get; set; }
        public List<CashFlowAssignment> CashFlowAssignments { get; set; }
        public List<object> Payments_ApprovalRequests { get; set; }
        public List<object> WithholdingTaxDataWTXCollection { get; set; }

    }
}
