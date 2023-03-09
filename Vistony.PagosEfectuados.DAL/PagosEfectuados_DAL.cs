using Forxap.Framework.Extensions;
using Newtonsoft.Json;
using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.PagosEfectuados.BO;

namespace Vistony.PagosEfectuados.DAL
{
   public class PagosEfectuados_DAL
    {
        public CabeceraPagoEfectuado CabeceraPagosEfectuados(SAPbouiCOM.Matrix Matrix, string DocType, string DocDate, string CardCode, string CardName,
                                                             string  Address, string DocCurrency,int CashSum, string TransferSum,string TransferDate,
                                                             string TransferReference,int DocRate,string Reference1,int ContactPersonCode,string TaxDate,
                                                             string PayToCode,string DueDate,string ControlAccount,string TransferAccount)
        {
            CabeceraPagoEfectuado DocumentCabeceraPagoEfectuado = new CabeceraPagoEfectuado();
            DateTime hoy = DateTime.Now;

            DocumentCabeceraPagoEfectuado.DocType = DocType;
            DocumentCabeceraPagoEfectuado.HandWritten = "tNO";
            DocumentCabeceraPagoEfectuado.TransferAccount = TransferAccount;
            DocumentCabeceraPagoEfectuado.Printed = "tNO";
            DocumentCabeceraPagoEfectuado.DocDate = DocDate;
            DocumentCabeceraPagoEfectuado.CardCode = CardCode;
            DocumentCabeceraPagoEfectuado.CardName = CardName;
            DocumentCabeceraPagoEfectuado.Address = Address;
            DocumentCabeceraPagoEfectuado.CashAccount = null;
            DocumentCabeceraPagoEfectuado.DocCurrency = DocCurrency;
            DocumentCabeceraPagoEfectuado.CashSum = CashSum;
            DocumentCabeceraPagoEfectuado.CheckAccount = null;
            DocumentCabeceraPagoEfectuado.TransferSum = TransferSum;
            DocumentCabeceraPagoEfectuado.TransferDate = TransferDate;
            DocumentCabeceraPagoEfectuado.TransferReference = TransferReference;
            DocumentCabeceraPagoEfectuado.LocalCurrency = "tNO";
            DocumentCabeceraPagoEfectuado.DocRate = DocRate;
            DocumentCabeceraPagoEfectuado.Reference1 = Reference1;
            DocumentCabeceraPagoEfectuado.Reference2 = null;
            DocumentCabeceraPagoEfectuado.CounterReference = null;
            DocumentCabeceraPagoEfectuado.Remarks = null;
            DocumentCabeceraPagoEfectuado.JournalRemarks = "Pagos efectudados - "+CardCode;
            DocumentCabeceraPagoEfectuado.SplitTransaction = "tNO";
            DocumentCabeceraPagoEfectuado.ContactPersonCode = ContactPersonCode;
            DocumentCabeceraPagoEfectuado.ApplyVAT = "tNO";
            DocumentCabeceraPagoEfectuado.TaxDate = TaxDate;
            DocumentCabeceraPagoEfectuado.Series = 1220;
            DocumentCabeceraPagoEfectuado.BankAccount = null;
            DocumentCabeceraPagoEfectuado.DiscountPercent = 0;
            DocumentCabeceraPagoEfectuado.ProjectCode = null;
            DocumentCabeceraPagoEfectuado.CurrencyIsLocal = "tNO";
            DocumentCabeceraPagoEfectuado.DeductionPercent = 0;
            DocumentCabeceraPagoEfectuado.DeductionSum= 0;
            DocumentCabeceraPagoEfectuado.CashSumFC= 0;
            DocumentCabeceraPagoEfectuado.CashSumSys = 0;
            DocumentCabeceraPagoEfectuado.BoeAccount= null;
            DocumentCabeceraPagoEfectuado.BillOfExchangeAmount = 0;
            DocumentCabeceraPagoEfectuado.BillofExchangeStatus = null;
            DocumentCabeceraPagoEfectuado.BillOfExchangeAmountFC = 0;
            DocumentCabeceraPagoEfectuado.BillOfExchangeAmountSC = 0;
            DocumentCabeceraPagoEfectuado.BillOfExchangeAgent = null;
            DocumentCabeceraPagoEfectuado.WTCode = null;
            DocumentCabeceraPagoEfectuado.WTAmount = 0;
            DocumentCabeceraPagoEfectuado.WTAmountFC = 0;
            DocumentCabeceraPagoEfectuado.WTAmountSC = 0;
            DocumentCabeceraPagoEfectuado.WTAccount = null;
            DocumentCabeceraPagoEfectuado.WTTaxableAmount = 0;
            DocumentCabeceraPagoEfectuado.Proforma = "tNO";
            DocumentCabeceraPagoEfectuado.PayToBankCode = null;
            DocumentCabeceraPagoEfectuado.PayToBankBranch = null;
            DocumentCabeceraPagoEfectuado.PayToBankAccountNo = null;
            DocumentCabeceraPagoEfectuado.PayToCode = PayToCode;
            DocumentCabeceraPagoEfectuado.PayToBankCountry = null;
            DocumentCabeceraPagoEfectuado.IsPayToBank = "tNO";
            DocumentCabeceraPagoEfectuado.PaymentPriority = "bopp_Priority_6";
            DocumentCabeceraPagoEfectuado.TaxGroup =null;
            DocumentCabeceraPagoEfectuado.BankChargeAmount = 0;
            DocumentCabeceraPagoEfectuado.BankChargeAmountInFC = 0;
            DocumentCabeceraPagoEfectuado.BankChargeAmountInSC = 0;
            DocumentCabeceraPagoEfectuado.UnderOverpaymentdifference = 0;
            DocumentCabeceraPagoEfectuado.UnderOverpaymentdiffSC =0;
            DocumentCabeceraPagoEfectuado.WtBaseSum = 0;
            DocumentCabeceraPagoEfectuado.WtBaseSumFC = 0;
            DocumentCabeceraPagoEfectuado.VatDate = hoy.ToString("yyyyMMdd");
            DocumentCabeceraPagoEfectuado.TransactionCode = "";
            DocumentCabeceraPagoEfectuado.PaymentType = "bopt_None";
            DocumentCabeceraPagoEfectuado.TransferRealAmount = 0;
            DocumentCabeceraPagoEfectuado.DocObjectCode = "bopot_OutgoingPayments";
            DocumentCabeceraPagoEfectuado.DocType = "rCustomer";
            DocumentCabeceraPagoEfectuado.DueDate = DueDate;
            DocumentCabeceraPagoEfectuado.LocationCode = null;
            DocumentCabeceraPagoEfectuado.Cancelled = "tNO";
            DocumentCabeceraPagoEfectuado.ControlAccount = ControlAccount;
            DocumentCabeceraPagoEfectuado.UnderOverpaymentdiffFC = 0;
            DocumentCabeceraPagoEfectuado.AuthorizationStatus = "pasWithout";
            DocumentCabeceraPagoEfectuado.BPLID = null;
            DocumentCabeceraPagoEfectuado.BPLName = null;
            DocumentCabeceraPagoEfectuado.VATRegNum = null;
            DocumentCabeceraPagoEfectuado.BlanketAgreement= null;
            DocumentCabeceraPagoEfectuado.PaymentByWTCertif= "tNO";
            DocumentCabeceraPagoEfectuado.Cig = null;
            DocumentCabeceraPagoEfectuado.Cup = null;
            DocumentCabeceraPagoEfectuado.AttachmentEntry = null;
            DocumentCabeceraPagoEfectuado.SignatureInputMessage= null;
            DocumentCabeceraPagoEfectuado.SignatureDigest= null;
            DocumentCabeceraPagoEfectuado.CertificationNumber = null;
            DocumentCabeceraPagoEfectuado.PrivateKeyVersion = null;
            DocumentCabeceraPagoEfectuado.PaymentInvoices = DetallepagoRecibido(Matrix);
            DocumentCabeceraPagoEfectuado.U_PZCreated="N";
            return DocumentCabeceraPagoEfectuado;
        }

        public List<PaymentInvoice> DetallepagoRecibido(Matrix Matrix)
        {
            List<PaymentInvoice> pagoRecibidoDocumentDetalls = new List<PaymentInvoice>();
        
            for (int oRows = 0; oRows < Matrix.RowCount; oRows++)
            {
                PaymentInvoice DocumentoPaymentInvoice =new  PaymentInvoice();
                DocumentoPaymentInvoice.LineNum =oRows;//Convert.ToInt32(Grid0.DataTable.GetString("LineNum", oRows).ToString());oMatrix.GetValueFromEditText("Col_1", row)
                DocumentoPaymentInvoice.DocEntry = Matrix.GetValueFromEditText("Col_0", oRows+1).ToString();
                DocumentoPaymentInvoice.SumApplied=Matrix.GetValueFromEditText("Col_6", oRows+1).ToString();
                DocumentoPaymentInvoice.AppliedFC= 0;
                DocumentoPaymentInvoice.AppliedSys=Matrix.GetValueFromEditText("Col_6", oRows+1).ToString();
                DocumentoPaymentInvoice.DocRate = 0;
                DocumentoPaymentInvoice.DocLine = 0;
                DocumentoPaymentInvoice.InvoiceType = "it_JournalEntry";
                DocumentoPaymentInvoice.DiscountPercent =0;
                DocumentoPaymentInvoice.PaidSum =0;
                DocumentoPaymentInvoice.InstallmentId= 1;

                pagoRecibidoDocumentDetalls.Add(DocumentoPaymentInvoice);
            }
            return pagoRecibidoDocumentDetalls;
        }

        public void EnvioJSON(SAPbouiCOM.Matrix Matrix, string DocType, string DocDate, string CardCode, string CardName,
                                                             string Address, string DocCurrency, int CashSum, string TransferSum, string TransferDate,
                                                             string TransferReference, int DocRate, string Reference1, int ContactPersonCode, string TaxDate,
                                                             string PayToCode, string DueDate, string ControlAccount, string TransferAccount)
        {
            CabeceraPagoEfectuado ObtenerCabecera = CabeceraPagosEfectuados(Matrix, DocType, DocDate, CardCode, CardName,Address, DocCurrency, CashSum, TransferSum, TransferDate,
                                                              TransferReference, DocRate, Reference1, ContactPersonCode, TaxDate,PayToCode, DueDate, ControlAccount, TransferAccount);

            string JsonObtenerCabezera = JsonConvert.SerializeObject(ObtenerCabecera);
        }
    }
}
