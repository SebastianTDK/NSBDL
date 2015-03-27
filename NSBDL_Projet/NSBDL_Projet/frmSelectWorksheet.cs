using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace NSBDL_Projet
{
    public partial class frmSelectWorksheet : Form
    {
        //*********************************************************************
        //  PROPRIETEES                                                       *
        //*********************************************************************

        private string _worksheetModel;
        private Excel.Workbook _workbookModel;

        public Excel.Workbook WorkbookModel
        {
            get { return _workbookModel; }
        }

        public string WorksheetModel
        {
            get { return _worksheetModel; }
        }

        //*********************************************************************
        //  VARIABLES GLOBALS                                                 *
        //*********************************************************************

        List<Excel.Worksheet> listWorksheet = new List<Excel.Worksheet>();
        Excel.Application application;

        //*********************************************************************

        public frmSelectWorksheet(Excel.Application ExAp)
        {
            InitializeComponent();
            application = ExAp;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            ofd.FilterIndex = 0;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbxExcelPath.Text = ofd.FileName;
                // Récupérer le classeur
                _workbookModel = application.Workbooks.Open(tbxExcelPath.Text);
                // Charger combobox avec les feuille du fichier
                foreach(Excel.Worksheet value in application.Worksheets)
                {
                    listWorksheet.Add(value);
                    cmbWorksheet.Items.Add(value.Name);
                }

                cmbWorksheet.Enabled = true;
            }
        }

        private void cmbWorksheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWorksheet.Text != "")
            {
                btnImport.Enabled = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (Excel.Worksheet value in listWorksheet)
            {
                if (value.Name == cmbWorksheet.Text)
                {
                    _worksheetModel = value.Name;
                    break;
                }
            }
        }
    }
}

