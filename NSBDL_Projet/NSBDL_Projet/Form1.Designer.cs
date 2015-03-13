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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenererFichier = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.oFDStudents = new System.Windows.Forms.OpenFileDialog();
            this.lblAddStudentFirstname = new System.Windows.Forms.Label();
            this.lblAddStudentName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblTitleAddStudent = new System.Windows.Forms.Label();
            this.tbxAddStudentFirstname = new System.Windows.Forms.TextBox();
            this.tbxAddStudentName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxClassName
            // 
            this.tbxClassName.Location = new System.Drawing.Point(110, 32);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(137, 20);
            this.tbxClassName.TabIndex = 0;
            // 
            // btnClassName
            // 
            this.btnClassName.Location = new System.Drawing.Point(253, 29);
            this.btnClassName.Name = "btnClassName";
            this.btnClassName.Size = new System.Drawing.Size(51, 25);
            this.btnClassName.TabIndex = 1;
            this.btnClassName.Text = "OK";
            this.btnClassName.UseVisualStyleBackColor = true;
            this.btnClassName.Click += new System.EventHandler(this.btnClassName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.btnClassName);
            this.groupBox1.Controls.Add(this.tbxClassName);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raphael";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(7, 35);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(97, 13);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Nom de la classe  :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenererFichier);
            this.groupBox2.Location = new System.Drawing.Point(345, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 257);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sebastian";
            // 
            // btnGenererFichier
            // 
            this.btnGenererFichier.Location = new System.Drawing.Point(65, 148);
            this.btnGenererFichier.Name = "btnGenererFichier";
            this.btnGenererFichier.Size = new System.Drawing.Size(113, 23);
            this.btnGenererFichier.TabIndex = 0;
            this.btnGenererFichier.Text = "Générer fichier";
            this.btnGenererFichier.UseVisualStyleBackColor = true;
            this.btnGenererFichier.Click += new System.EventHandler(this.btnGenererFichier_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAddStudentFirstname);
            this.groupBox3.Controls.Add(this.lblAddStudentName);
            this.groupBox3.Controls.Add(this.btnAddStudent);
            this.groupBox3.Controls.Add(this.lblTitleAddStudent);
            this.groupBox3.Controls.Add(this.tbxAddStudentFirstname);
            this.groupBox3.Controls.Add(this.tbxAddStudentName);
            this.groupBox3.Location = new System.Drawing.Point(670, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 250);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "François";
            // 
            // lblAddStudentFirstname
            // 
            this.lblAddStudentFirstname.AutoSize = true;
            this.lblAddStudentFirstname.Location = new System.Drawing.Point(6, 119);
            this.groupBox4.Controls.Add(this.btnOpenFile);
            this.groupBox4.Location = new System.Drawing.Point(181, 275);
            this.lblAddStudentFirstname.Name = "lblAddStudentFirstname";
            this.lblAddStudentFirstname.Size = new System.Drawing.Size(49, 13);
            this.groupBox4.Size = new System.Drawing.Size(280, 262);
            this.lblAddStudentFirstname.TabIndex = 5;
            this.lblAddStudentFirstname.Text = "Prenom :";
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(139, 118);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(116, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Choisir un fichier";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblAddStudentName
            // oFDStudents
            // 
            this.oFDStudents.FileName = "openFileDialog1";
            // 
            this.lblAddStudentName.AutoSize = true;
            this.lblAddStudentName.Location = new System.Drawing.Point(6, 59);
            this.lblAddStudentName.Name = "lblAddStudentName";
            this.lblAddStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblAddStudentName.TabIndex = 4;
            this.lblAddStudentName.Text = "Nom :";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Enabled = false;
            this.btnAddStudent.Location = new System.Drawing.Point(67, 174);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Ajouter";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblTitleAddStudent
            // 
            this.lblTitleAddStudent.AutoSize = true;
            this.lblTitleAddStudent.Location = new System.Drawing.Point(6, 16);
            this.lblTitleAddStudent.Name = "lblTitleAddStudent";
            this.lblTitleAddStudent.Size = new System.Drawing.Size(84, 13);
            this.lblTitleAddStudent.TabIndex = 2;
            this.lblTitleAddStudent.Text = "Ajouter un élève";
            // 
            // tbxAddStudentFirstname
            // 
            this.tbxAddStudentFirstname.Location = new System.Drawing.Point(67, 116);
            this.tbxAddStudentFirstname.Name = "tbxAddStudentFirstname";
            this.tbxAddStudentFirstname.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStudentFirstname.TabIndex = 1;
            this.tbxAddStudentFirstname.TextChanged += new System.EventHandler(this.tbxAddStudentFirstname_TextChanged);
            this.tbxAddStudentFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddStudentFirstname_KeyPress);
            // 
            // tbxAddStudentName
            // 
            this.tbxAddStudentName.Location = new System.Drawing.Point(67, 56);
            this.tbxAddStudentName.Name = "tbxAddStudentName";
            this.tbxAddStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStudentName.TabIndex = 0;
            this.tbxAddStudentName.TextChanged += new System.EventHandler(this.tbxAddStudentName_TextChanged);
            this.tbxAddStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddStudentName_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(176, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 252);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiago";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 538);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxClassName;
        private System.Windows.Forms.Button btnClassName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxAddStudentFirstname;
        private System.Windows.Forms.Button btnGenererFichier;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog oFDStudents;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbxAddStudentName;
        private System.Windows.Forms.Label lblAddStudentFirstname;
        private System.Windows.Forms.Label lblAddStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblTitleAddStudent;
    }
}

