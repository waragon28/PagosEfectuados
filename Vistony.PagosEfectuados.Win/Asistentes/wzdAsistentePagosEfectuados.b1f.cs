using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using SAPbouiCOM;
using Forxap.Framework.Extensions;
using Forxap.Framework.UI;
using Vistony.PagosEfectuados.BLL;
using SAPbobsCOM;
using Vistony.Distribucion.Win;

namespace Vistony.PagosEfectuados.Win.Asistentes
{
    [FormAttribute("AsitPagosEfect", "Asistentes/wzdAsistentePagosEfectuados.b1f")]
    class wzdAsistentePagosEfectuados : UserFormBase
    {
        PagosEfectuados_BLL PagosEfectuados_BLL = new PagosEfectuados_BLL();

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private Matrix Matrix0;
        private Button Button0;
        private SAPbouiCOM.EditText EditText4;
        private Button Button1;
        private StaticText StaticText4;
        private EditText EditText5;
        public SAPbouiCOM.Matrix oMatrix;
        SAPbouiCOM.Form oForm;
        private StaticText StaticText5;
        private EditText EditText6;
        private EditText EditText7;
        public wzdAsistentePagosEfectuados()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.EditText3.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.EditText3_ChooseFromListAfter);
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_7").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_11").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_8").Specific));
            this.Button0.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button0_ClickAfter);
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_10").Specific));
            this.Button1.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button1_ClickAfter);
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_12").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_13").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_14").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_15").Specific));
            this.EditText6.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.EditText6_ChooseFromListAfter);
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_16").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_17").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_18").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }


        private void OnCustomInitialize()
        {
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
            oForm.ScreenCenter();
            oMatrix = oForm.GetMatrix("Item_11");
            oMatrix.AutoResizeColumns();
           // oMatrix.ReadOnly(true);

            ChooseFromList_Filtro_2(oForm, "CFL_0","CardType", "C", "validFor", "Y");
        }

        private void EditText3_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {

            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {
                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText3.Value = chooseFromListEvent.SelectedObjects.GetValue("CardCode", 0).ToString();
                        EditText4.Value = chooseFromListEvent.SelectedObjects.GetValue("CardName", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public void ChooseFromList_Filtro_2(SAPbouiCOM.Form oForm, string CFL_, string Campo1, string condicion1, string Campo2, string condicion2)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.ChooseFromList cfl = oForm.ChooseFromLists.Item(CFL_);
            SAPbouiCOM.Conditions cons = cfl.GetConditions();
            SAPbouiCOM.Condition con;

            con = cons.Add();
            con.Alias = Campo1;
            con.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
            con.CondVal = condicion1;
            con.Relationship = BoConditionRelationship.cr_AND;
            con = cons.Add();
            con.Alias = Campo2;

            con.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
            con.CondVal = condicion2;

            cfl.SetConditions(cons);
        }


        private void Button0_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            try
            {
                addItem(EditText3.Value);
                Sb1Messages.ShowSuccess("Busqueda Finalizada");
            }
            catch (Exception e)
            {
                Sb1Messages.ShowError("Error");
            }

        }

        private StaticText StaticText3;

        private void addItem(string CardCode)
        {
            try
            {
                /*EJECUTAR EL PROCEDIMIENTO ALMACENADO*/
                SAPbouiCOM.DataTable exp;
                exp = oForm.DataSources.DataTables.Item("DT_PagEf");
                string Query = string.Format("CALL SP_ADD_PAG_EFEC_GET_PAG_EFECT('{0}')", CardCode);
                exp.ExecuteQuery(Query);
                /*FIN DE EJECUCION DE PROCEDIMIENTO ALMACENADO*/


                
                SAPbouiCOM.DataTable udt = oForm.GetDataTable("DT_1");
                oMatrix = oForm.GetMatrix("Item_11");
                SAPbouiCOM.Columns oColumns;
                oColumns = oMatrix.Columns;
                SAPbouiCOM.Column oColumn;
                var colItems = udt.Columns;
                if (udt.Columns.Count == 0)
                {

                    colItems.Add("N Documento", BoFieldsType.ft_AlphaNumeric);
                    colItems.Add("plazo", BoFieldsType.ft_AlphaNumeric);
                    colItems.Add("Fecha", BoFieldsType.ft_AlphaNumeric);
                    colItems.Add("Dias de atraso", BoFieldsType.ft_AlphaNumeric);
                    colItems.Add("Total", BoFieldsType.ft_AlphaNumeric);
                    colItems.Add("Saldo", BoFieldsType.ft_AlphaNumeric);
                    colItems.Add("Monto", BoFieldsType.ft_Price);
                }
                int a = udt.Rows.Count;
                if (oMatrix.RowCount > 0)
                    a = udt.Rows.Count;
                for (int oRow = 0; oRow < exp.Rows.Count; oRow++)
                {
                    udt.Rows.Add();
                    udt.SetValue("N Documento", oRow, exp.GetString("N Documento", oRow));
                    udt.SetValue("plazo", oRow, exp.GetString("plazo", oRow));
                    udt.SetValue("Fecha", oRow, exp.GetString("Fecha", oRow));
                    udt.SetValue("Dias de atraso", oRow, exp.GetString("Dias de atraso", oRow));
                    udt.SetValue("Total", oRow, exp.GetString("Total", oRow));
                    udt.SetValue("Saldo", oRow, exp.GetString("Saldo", oRow));
                    udt.SetValue("Monto", oRow,0);
                }

                oMatrix.Columns.Item("Col_0").DataBind.Bind("DT_1", "N Documento");
                oMatrix.Columns.Item("Col_1").DataBind.Bind("DT_1", "plazo");
                oMatrix.Columns.Item("Col_2").DataBind.Bind("DT_1", "Fecha");
                oMatrix.Columns.Item("Col_3").DataBind.Bind("DT_1", "Dias de atraso");
                oMatrix.Columns.Item("Col_4").DataBind.Bind("DT_1", "Total");
                oMatrix.Columns.Item("Col_5").DataBind.Bind("DT_1", "Saldo");
                oMatrix.Columns.Item("Col_6").DataBind.Bind("DT_1", "Monto");

                oColumn = oColumns.Item("Col_0");
                oMatrix.LoadFromDataSource();
                oMatrix.AutoResizeColumns();



            }
            catch (Exception)
            {

                throw;
            }
        }


        private void Button1_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {

            string DocType = "rCustomer";
            string DocDate = EditText0.Value;
            string CardCode = EditText3.Value;
            string CardName =EditText4.Value;

            GetDatosChofer(CardCode);

            string Address = DireccionEmpleado;
            string DocCurrency = "S/";
            int CashSum = 0;
            string TransferSum = Convert.ToString(Matrix0.GetValueFromEditText("Col_6", 1));
            string TransferDate = "";
            string TransferReference = EditText8.Value;
            int DocRate = 0;
            string Reference1 = Convert.ToString(Matrix0.GetValueFromEditText("Col_6", 1));
            int ContactPersonCode = 0;
            string TaxDate = EditText2.Value;
            string PayToCode = "01";
            string DueDate = EditText1.Value;
            string ControlAccount = "";
            string TransferAccount = EditText6.Value;
            PagosEfectuados_BLL.EnvioJSON(Matrix0, DocType, DocDate, CardCode, CardName,Address, DocCurrency, CashSum, TransferSum, TransferDate,
                                                                    TransferReference, DocRate, Reference1, ContactPersonCode, TaxDate,
                                                                    PayToCode,  DueDate, ControlAccount, TransferAccount);


        }
        SAPbobsCOM.Recordset recordSet = null;
        string DireccionEmpleado = "";
        public void GetDatosChofer(string cardCode )
        {
            recordSet = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            if (recordSet == null)
                throw new NullReferenceException("No se pudo obtener el objeto Recordset");
            try
            {

                string strSQL = string.Format("SELECT T1.\"Street\"||'-'||UPPER(T1.\"Block\") ||'-'||UPPER(T1.\"City\") ||'-'||UPPER(T1.\"County\") as \"Direccion\" "+
                    " FROM OCRD T0 INNER JOIN CRD1 T1 ON T0.\"CardCode\" = T1.\"CardCode\" "+
                    " where T1.\"AdresType\" = 'B' and T0.\"CardCode\" = '{0}' ", cardCode);
                recordSet.DoQuery(strSQL);
                DireccionEmpleado = recordSet.Fields.Item("Direccion").Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (recordSet != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(recordSet);
                    recordSet = null;
                    GC.Collect();
                }
            }

        }

        private StaticText StaticText6;
        private EditText EditText8;

        private void EditText6_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {

            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {
                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText6.Value = chooseFromListEvent.SelectedObjects.GetValue("AcctCode", 0).ToString();
                        EditText7.Value = chooseFromListEvent.SelectedObjects.GetValue("AcctName", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
