namespace NSBDL_Projet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.btnClassName = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lbxEleves = new System.Windows.Forms.ListBox();
            this.lblAddStudentFirstname = new System.Windows.Forms.Label();
            this.lblAddStudentName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tbxAddStudentFirstname = new System.Windows.Forms.TextBox();
            this.tbxAddStudentName = new System.Windows.Forms.TextBox();
            this.oFDStudents = new System.Windows.Forms.OpenFileDialog();
            this.btnGenererFichier = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxClassName
            // 
            this.tbxClassName.Location = new System.Drawing.Point(115, 15);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(137, 20);
            this.tbxClassName.TabIndex = 0;
            // 
            // btnClassName
            // 
            this.btnClassName.Location = new System.Drawing.Point(258, 12);
            this.btnClassName.Name = "btnClassName";
            this.btnClassName.Size = new System.Drawing.Size(51, 25);
            this.btnClassName.TabIndex = 1;
            this.btnClassName.Text = "OK";
            this.btnClassName.UseVisualStyleBackColor = true;
            this.btnClassName.Click += new System.EventHandler(this.btnClassName_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(12, 18);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(97, 13);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Nom de la classe  :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpenFile);
            this.groupBox3.Controls.Add(this.lbxEleves);
            this.groupBox3.Controls.Add(this.lblAddStudentFirstname);
            this.groupBox3.Controls.Add(this.lblAddStudentName);
            this.groupBox3.Controls.Add(this.btnAddStudent);
            this.groupBox3.Controls.Add(this.tbxAddStudentFirstname);
            this.groupBox3.Controls.Add(this.tbxAddStudentName);
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 285);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter un élève";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(131, 71);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(109, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Charger élèves";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbxEleves
            // 
            this.lbxEleves.FormattingEnabled = true;
            this.lbxEleves.Location = new System.Drawing.Point(9, 101);
            this.lbxEleves.Name = "lbxEleves";
            this.lbxEleves.Size = new System.Drawing.Size(231, 173);
            this.lbxEleves.TabIndex = 6;
            // 
            // lblAddStudentFirstname
            // 
            this.lblAddStudentFirstname.AutoSize = true;
            this.lblAddStudentFirstname.Location = new System.Drawing.Point(6, 48);
            this.lblAddStudentFirstname.Name = "lblAddStudentFirstname";
            this.lblAddStudentFirstname.Size = new System.Drawing.Size(49, 13);
            this.lblAddStudentFirstname.TabIndex = 5;
            this.lblAddStudentFirstname.Text = "Prenom :";
            // 
            // lblAddStudentName
            // 
            this.lblAddStudentName.AutoSize = true;
            this.lblAddStudentName.Location = new System.Drawing.Point(6, 22);
            this.lblAddStudentName.Name = "lblAddStudentName";
            this.lblAddStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblAddStudentName.TabIndex = 4;
            this.lblAddStudentName.Text = "Nom :";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Enabled = false;
            this.btnAddStudent.Location = new System.Drawing.Point(9, 71);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(116, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Ajouter";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tbxAddStudentFirstname
            // 
            this.tbxAddStudentFirstname.Location = new System.Drawing.Point(67, 45);
            this.tbxAddStudentFirstname.Name = "tbxAddStudentFirstname";
            this.tbxAddStudentFirstname.Size = new System.Drawing.Size(173, 20);
            this.tbxAddStudentFirstname.TabIndex = 1;
            this.tbxAddStudentFirstname.TextChanged += new System.EventHandler(this.tbxAddStudentFirstname_TextChanged);
            this.tbxAddStudentFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddStudentFirstname_KeyPress);
            // 
            // tbxAddStudentName
            // 
            this.tbxAddStudentName.Location = new System.Drawing.Point(67, 19);
            this.tbxAddStudentName.Name = "tbxAddStudentName";
            this.tbxAddStudentName.Size = new System.Drawing.Size(173, 20);
            this.tbxAddStudentName.TabIndex = 0;
            this.tbxAddStudentName.TextChanged += new System.EventHandler(this.tbxAddStudentName_TextChanged);
            this.tbxAddStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddStudentName_KeyPress);
            // 
            // oFDStudents
            // 
            this.oFDStudents.FileName = "openFileDialog1";
            // 
            // btnGenererFichier
            // 
            this.btnGenererFichier.Location = new System.Drawing.Point(12, 334);
            this.btnGenererFichier.Name = "btnGenererFichier";
            this.btnGenererFichier.Size = new System.Drawing.Size(251, 48);
            this.btnGenererFichier.TabIndex = 0;
            this.btnGenererFichier.Text = "Générer le fichier";
            this.btnGenererFichier.UseVisualStyleBackColor = true;
            this.btnGenererFichier.Click += new System.EventHandler(this.btnGenererFichier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 538);
            this.Controls.Add(this.btnGenererFichier);
            this.Controls.Add(this.btnClassName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxClassName;
        private System.Windows.Forms.Button btnClassName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxAddStudentFirstname;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog oFDStudents;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbxAddStudentName;
        private System.Windows.Forms.Label lblAddStudentFirstname;
        private System.Windows.Forms.Label lblAddStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnGenererFichier;
        private System.Windows.Forms.ListBox lbxEleves;
    }
}

