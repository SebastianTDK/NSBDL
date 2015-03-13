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
using System.IO;
using System.Reflection;

namespace NSBDL_Projet
{
    public partial class Form1 : Form
    {
        string ClassName { get; set; }
        Excel.Application ExcelApp { get; set; }
        Excel.Workbook NewWorkbook { get; set; }
        Excel.Worksheet NewWorksheet { get; set; }
        Excel.Range WorkSheetRange { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        //On récupère le nom de classe
        private void btnClassName_Click(object sender, EventArgs e)
        {
            ClassName = tbxClassName.Text;
            AddSheet(@"E:\GIT\NSBDL\NSBDL_Projet\NSBDL_Projet\bin\Debug\test.xlsx", "test_sheet");
        }

        private void AddSheet(string bookPath, string sheetName)
        {
            try
            {
                ExcelApp = new Excel.Application();
                NewWorkbook = (Excel.Workbook)ExcelApp.Workbooks.Open(bookPath);
                NewWorksheet = (Excel.Worksheet)ExcelApp.Worksheets.Add();
                NewWorksheet.Name = sheetName;
                NewWorkbook.SaveAs(bookPath);

            }
            catch (Exception ex)
            {
                //TODO manage exception
            }
            finally
            {
                NewWorkbook.Close();
                ExcelApp.Quit();
            }
        }

        private void tbxAddStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Quand l'on appuie sur une touche, on accepte que les lettres et le backspace.
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != '\u0008'))
                e.Handled = true;
        }

        private void tbxAddStudentFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Quand l'on appuie sur une touche, on accepte que les lettres et le backspace.
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != '\u0008'))
                e.Handled = true;
        }

        private void tbxAddStudentName_TextChanged(object sender, EventArgs e)
        {
            //Si les champs sont vides, on désactive le bouton ajouter. Sinon on l'active.
            if (tbxAddStudentName.Text == "" || tbxAddStudentFirstname.Text == "")
            {
                btnAddStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
            }
        }

        private void tbxAddStudentFirstname_TextChanged(object sender, EventArgs e)
        {
            //Si les champs sont vides, on désactive le bouton ajouter. Sinon on l'active.
            if (tbxAddStudentName.Text == "" || tbxAddStudentFirstname.Text == "")
            {
                btnAddStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnGenererFichier_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();

            excelApp.Visible = true;

        }
    }
}
