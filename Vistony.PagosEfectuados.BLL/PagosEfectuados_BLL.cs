using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.PagosEfectuados.DAL;

namespace Vistony.PagosEfectuados.BLL
{
    public class PagosEfectuados_BLL
    {
        PagosEfectuados_DAL PagosEfectuados_DAL1 = new PagosEfectuados_DAL();


        public void EnvioJSON(SAPbouiCOM.Matrix Matrix, string DocType, string DocDate, string CardCode, string CardName,
                                                                  string Address, string DocCurrency, int CashSum, string TransferSum, string TransferDate,
                                                                  string TransferReference, int DocRate, string Reference1, int ContactPersonCode, string TaxDate,
                                                                  string PayToCode, string DueDate, string ControlAccount,string TransferAccount)
        {
          PagosEfectuados_DAL1.EnvioJSON(Matrix, DocType, DocDate, CardCode, CardName,Address, DocCurrency, CashSum, TransferSum, TransferDate,
                                          TransferReference, DocRate, Reference1, ContactPersonCode, TaxDate,PayToCode,DueDate,ControlAccount, TransferAccount);
         }

    }
}
