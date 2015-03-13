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
        object M = System.Reflection.Missing.Value;
        string FileName = "C:\\Users\\NETUSCHILD_INFO\\Desktop\\test.xlsx";

        

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
            //Si on a mis un nom de classe
            if (ClassName != null)
            {
                //Cette liste va contenir les élèves de la classe choisie
                List<string> CurrentClassStudentList = new List<string>();

                //On mets le nom et le prénom du nouvel élève dans une variable.
                string Name = tbxAddStudentName.Text;
                string Firstname = tbxAddStudentFirstname.Text;

                //On crée l'emplacement du fichier avec le nom de la classe.
                string ClassFile = (ClassName + ".txt");
                if (File.Exists(ClassFile))
                {
                    //On prend les données du fichier texte de la classe et on les mets dans une liste.
                    StreamReader myStreamReader = new StreamReader(ClassFile, Encoding.UTF8);
                    string line = myStreamReader.ReadLine();
                    while (line != null)
                    {
                        CurrentClassStudentList.Add(line);
                        line = myStreamReader.ReadLine();
                    }
                    myStreamReader.Close();
                }

                //On ajoute à la liste le nouvel élève
                CurrentClassStudentList.Add((Name + ";" + Firstname));

                //On écrit dans le fichier
                StreamWriter monStreamWriter = new StreamWriter(ClassFile);
                foreach (string s in CurrentClassStudentList)
                {
                    monStreamWriter.WriteLine(s);
                }
                monStreamWriter.Close();
                MessageBox.Show("L'élève " + Firstname + " " + Name + " à été enregistré.");
            }
            else
            {
                //
                MessageBox.Show("Veuillez entrer un nom de classe d'abord!");
            }
        }

        private void btnGenererFichier_Click(object sender, EventArgs e)
        {
            var workbook = new Excel.XLWorkbook();
            workbook.Worksheets.Add("test");

            //Lien de l'endroit o`zu vousn voulez enregistrer
            workbook.SaveAs(ClassName);
        }
    }
}
