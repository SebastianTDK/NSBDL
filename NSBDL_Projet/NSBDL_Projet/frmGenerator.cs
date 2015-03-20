using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Excel = ClosedXML.Excel;
using ClosedXML.Excel;

namespace NSBDL_Projet
{
    public partial class frmGenerator : Form
    {
        XLWorkbook XWB { get; set; } //Classeur XLSX
        string ClassName { get; set; } //Le nom de la classe, qui est en fait le nom du classeur XLSX
        List<string> Students { get; set; } //Les élèves, qui seront en fait les noms feuilles du classeur
    
        clsGestionExcel gestionExcel;

        Excel.IXLWorksheet wsModel;

        public frmGenerator()
        {
            InitializeComponent();
            gestionExcel = new clsGestionExcel();
        }
     
        /// <summary>
        /// Ajout de page sur un classeur
        /// </summary>
        /// <param name="bookPath">Le chemin du classeur</param>
        /// <param name="sheetName">Le nom de la feuille</param>
        private void AddSheet(string bookPath, string sheetName)
        {
            try
            {
                XWB = new XLWorkbook();
                XWB.Worksheets.Add(sheetName);
                XWB.SaveAs("MultipleSheets.xlsx");
            }
            catch (Exception ex)
            {
                //TODO manage exception
            }
            finally
            {
            
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

                lbxEleves.DataSource = CurrentClassStudentList;

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

        private void btnGenererFichier2_Click(object sender, EventArgs e)
        {
            var workbook = new Excel.XLWorkbook();
            workbook.Worksheets.Add("test");

            //Lien de l'endroit o`zu vousn voulez enregistrer
            workbook.SaveAs(ClassName);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //open File dialog
            //--------------------------------------------------------
            oFDStudents.InitialDirectory = Environment.CurrentDirectory;  //set the intial dir of the dialog
            oFDStudents.Filter = "Fichiers texte (*.txt) |*.txt| Fichier CSV (*.csv)|*.csv";
            oFDStudents.FilterIndex = 0;
            try
            {
                DialogResult res = oFDStudents.ShowDialog();
                FileReader fr = new FileReader();
                if (res == DialogResult.OK)
                {
                    //Treatment to do with the file
                    fr.CSVtoList(oFDStudents.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        /// <summary>
        ///     Chargement du fichier model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargerModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Fichier Excel (*.xlsx)|*.xlsx| Tous les fichiers (*.*)|*.*";
            ofd.FilterIndex = 0;

            DialogResult ofdr = ofd.ShowDialog();

            if (ofdr == DialogResult.OK)
            {
                wsModel = gestionExcel.getWorksheetModel(ofd.FileName);
                btnGenererFichier.Enabled = true;
            }
        }

        private void btnGenererFichier_Click(object sender, EventArgs e)
        {
            Students = new List<string>();
            foreach(string v in lbxEleves.Items)
            {
                Students.Add(v);
            }


            var wb = gestionExcel.copyWorksheet(Students.ToArray(), wsModel);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.Filter = "Fichier Excel (*.xlsx)|*.xlsx| Tous les fichiers (*.*)|*.*";

            DialogResult ofdr = sfd.ShowDialog();

            if (ofdr == DialogResult.OK)
            {
                wb.SaveAs(sfd.FileName);
            }

            
        }

        

        private void tbxClassName_TextChanged(object sender, EventArgs e)
        {
            ClassName = tbxClassName.Text;
        }      
    }
}
