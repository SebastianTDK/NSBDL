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

        /// <summary>
        ///     Écrit ne nom des élève dans le fichier en paramètre (en écrasant le précédant)
        /// </summary>
        /// <param name="url">url du fichier à écrir</param>
        /// <param name="students">tableau du nom des élèves</param>
        private void WriteFileClasse(string url, string[] students)
        {
            StreamWriter sw = new StreamWriter(url, true);
            foreach (string s in students)
            {
                sw.WriteLine(s);
            }
            sw.Close();
        }

        /// <summary>
        ///     Lit le fichier passé en url et retourne le nom des élèves sous forme de tableau.
        /// </summary>
        /// <param name="url">url vers le fichier</param>
        /// <returns>tableau de students</returns>
        private List<string> ReadFileClasse(string url)
        {
            // variables
            List<string> students = new List<string>();
            string line = "";
            char[] ex = {'*', '/', '?', '\\', '[', ']'};

            if (File.Exists(url))
            {
                //On prend les données du fichier texte de la classe et on les mets dans une liste.
                StreamReader sr = new StreamReader(url, Encoding.UTF8);
                // Tant que l'on n'est pas à la fin du fichier
                while (sr.Peek() >= 0)
                {
                    // lit la ligne
                    line = sr.ReadLine();
                    // test si les entrée sont valide
                    if (line.IndexOfAny(ex) == -1)
                    {
                        if (!students.Contains(line))
                        {
                            students.Add(line.Trim());
                        }
                    }
                }
                sr.Close();
            }

            return students;
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            char[] ex = { '*', '/', '?', '\\', '[', ']' };

            //On mets le nom et le prénom du nouvel élève dans une variable.
            string student = (tbxAddStudentName.Text + " " + tbxAddStudentFirstname.Text).Trim();

            //On crée l'emplacement du fichier avec le nom de la classe.
            string ClassFile = (ClassName + ".txt");

            // Charger les élève depuis le fichier
            Students = ReadFileClasse(ClassFile);

            foreach (string s in Students)
            {
                lbxEleves.Items.Add(s);
            }


            // Si l'élève n'existe pas déja
            if ((!Students.Contains(student)) && (student.IndexOfAny(ex) == -1))
            {
                // Ajoute l'élève dans liste
                lbxEleves.Items.Add(student);
                Students.Add(student);

                // Écrit le fichier classe
                PlaceHeader(ClassFile);
                WriteFileClasse(ClassFile, Students.ToArray());
            }
            else
            {
                MessageBox.Show("L'élève éxiste déjà.");
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
                string fileName = oFDStudents.FileName;

                if (res == DialogResult.OK)
                {
                    if (CheckHeader(fileName))
                    {            
                        FileToList(fileName,false);
                        tbxClassName.Text = Path.GetFileNameWithoutExtension(fileName);
                    }
                    else
                    {
                        MessageBox.Show("Le fichier est corrompu!", "Erreur");
                    }
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
            frmSelectWorksheet sw = new frmSelectWorksheet();

            if ( sw.ShowDialog() == DialogResult.OK )
            {
                wsModel = sw.WorksheetModel;
                btnGenererFichier.Enabled = true;
            }
        }

        private void btnGenererFichier_Click(object sender, EventArgs e)
        {
            Students = new List<string>();
            foreach (string v in lbxEleves.Items)
            {
                Students.Add(v);
            }


            var wb = gestionExcel.copyWorksheet(Students.ToArray(), wsModel);

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult fbdr = fbd.ShowDialog();

            string m = "";

            if (fbdr == DialogResult.OK)
            {
                try
                {
                    wb.SaveAs(fbd.SelectedPath + "\\" + tbxClassName.Text + ".xlsx");
                    m = "Génération Terminée";
                }
                catch (Exception ex)
                {
                    m = "Erreur : " + ex.ToString();
                }
                finally
                {
                    MessageBox.Show(m, "Message");
                }
            }
        }



        private void tbxClassName_TextChanged(object sender, EventArgs e)
        {
            ClassName = tbxClassName.Text;
            if (ClassName.Length > 0)
                btnAddStudent.Enabled = true;
            else
                btnAddStudent.Enabled = false;
        }

        private void PlaceHeader(string path)
        {
            StreamWriter writer = new StreamWriter(File.Open(path,FileMode.Create));

            writer.WriteLine("-Classroom_Generator_X-");
            writer.Close();
        }

        private bool CheckHeader(string path)
        {
            StreamReader reader = new StreamReader(File.OpenRead(path));
            string line = reader.ReadLine();

            reader.Close();

            if (line == "-Classroom_Generator_X-")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void FileToList(string path, bool append)
        {
            if (!append)
            {
                Students = null;
                Students = new List<string>();
            }
            StreamReader reader = new StreamReader(File.OpenRead(path));

            string line = reader.ReadLine();//header

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                Students.Add(line);
            }

            reader.Close();

            lbxEleves.DataSource = Students;
        }
    }
}
