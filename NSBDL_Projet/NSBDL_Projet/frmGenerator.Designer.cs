namespace NSBDL_Projet
{
    partial class frmGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lbxEleves = new System.Windows.Forms.ListBox();
            this.lblAddStudentFirstname = new System.Windows.Forms.Label();
            this.lblAddStudentName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tbxAddStudentFirstname = new System.Windows.Forms.TextBox();
            this.tbxAddStudentName = new System.Windows.Forms.TextBox();
            this.oFDStudents = new System.Windows.Forms.OpenFileDialog();
            this.btnGenererFichier = new System.Windows.Forms.Button();
            this.gbxModel = new System.Windows.Forms.GroupBox();
            this.btnChargerModel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.gbxModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxClassName
            // 
            this.tbxClassName.Location = new System.Drawing.Point(115, 15);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(137, 20);
            this.tbxClassName.TabIndex = 0;
            this.tbxClassName.TextChanged += new System.EventHandler(this.tbxClassName_TextChanged);
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
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnOpenFile);
            this.groupBox3.Controls.Add(this.lbxEleves);
            this.groupBox3.Controls.Add(this.lblAddStudentFirstname);
            this.groupBox3.Controls.Add(this.lblAddStudentName);
            this.groupBox3.Controls.Add(this.btnAddStudent);
            this.groupBox3.Controls.Add(this.tbxAddStudentFirstname);
            this.groupBox3.Controls.Add(this.tbxAddStudentName);
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 321);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter un élève";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(9, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(231, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(131, 71);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(114, 23);
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
            this.lbxEleves.Size = new System.Drawing.Size(236, 173);
            this.lbxEleves.TabIndex = 6;
            this.lbxEleves.SelectedIndexChanged += new System.EventHandler(this.lbxEleves_SelectedIndexChanged);
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
            this.tbxAddStudentFirstname.Size = new System.Drawing.Size(178, 20);
            this.tbxAddStudentFirstname.TabIndex = 1;
            this.tbxAddStudentFirstname.TextChanged += new System.EventHandler(this.tbxAddStudentFirstname_TextChanged);
            this.tbxAddStudentFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddStudentFirstname_KeyPress);
            // 
            // tbxAddStudentName
            // 
            this.tbxAddStudentName.Location = new System.Drawing.Point(67, 19);
            this.tbxAddStudentName.Name = "tbxAddStudentName";
            this.tbxAddStudentName.Size = new System.Drawing.Size(178, 20);
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
            this.btnGenererFichier.Enabled = false;
            this.btnGenererFichier.Location = new System.Drawing.Point(15, 429);
            this.btnGenererFichier.Name = "btnGenererFichier";
            this.btnGenererFichier.Size = new System.Drawing.Size(248, 48);
            this.btnGenererFichier.TabIndex = 0;
            this.btnGenererFichier.Text = "Générer le fichier";
            this.btnGenererFichier.UseVisualStyleBackColor = true;
            this.btnGenererFichier.Click += new System.EventHandler(this.btnGenererFichier_Click);
            // 
            // gbxModel
            // 
            this.gbxModel.Controls.Add(this.btnChargerModel);
            this.gbxModel.Location = new System.Drawing.Point(12, 370);
            this.gbxModel.Name = "gbxModel";
            this.gbxModel.Size = new System.Drawing.Size(251, 53);
            this.gbxModel.TabIndex = 7;
            this.gbxModel.TabStop = false;
            this.gbxModel.Text = "Modèle";
            // 
            // btnChargerModel
            // 
            this.btnChargerModel.Location = new System.Drawing.Point(6, 20);
            this.btnChargerModel.Name = "btnChargerModel";
            this.btnChargerModel.Size = new System.Drawing.Size(239, 23);
            this.btnChargerModel.TabIndex = 0;
            this.btnChargerModel.Text = "Charger model";
            this.btnChargerModel.UseVisualStyleBackColor = true;
            this.btnChargerModel.Click += new System.EventHandler(this.btnChargerModel_Click);
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(278, 528);
            this.Controls.Add(this.gbxModel);
            this.Controls.Add(this.btnGenererFichier);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGenerator";
            this.Text = "Générateur de feuille excel";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxModel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxClassName;
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
        private System.Windows.Forms.GroupBox gbxModel;
        private System.Windows.Forms.Button btnChargerModel;
        private System.Windows.Forms.Button btnDelete;
    }
}

