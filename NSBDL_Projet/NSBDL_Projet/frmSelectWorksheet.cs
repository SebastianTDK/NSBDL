using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = ClosedXML.Excel;

namespace NSBDL_Projet
{
    public partial class frmSelectWorksheet : Form
    {
        //*********************************************************************
        //  PROPRIETEES                                                       *
        //*********************************************************************

        private Excel.IXLWorksheet _worksheetModel;

        public Excel.IXLWorksheet WorksheetModel
        {
            get { return _worksheetModel; }
        }

        //*********************************************************************
        //  VARIABLES GLOBALS                                                 *
        //*********************************************************************

        List<Excel.IXLWorksheet> listWorksheet = new List<Excel.IXLWorksheet>();

        //*********************************************************************

        public frmSelectWorksheet()
        {
            InitializeComponent();
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
                var workbook = new Excel.XLWorkbook(ofd.FileName);

                // Charger combobox avec les feuille du fichier
                foreach(Excel.IXLWorksheet value in workbook.Worksheets)
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
            foreach (Excel.IXLWorksheet value in listWorksheet)
            {
                if (value.Name == cmbWorksheet.Text)
                {
                    _worksheetModel = value;
                    break;
                }
            }
        }
    }
}

