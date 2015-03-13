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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbxAddStudentName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.tbxAddStudentFirstname = new System.Windows.Forms.TextBox();
            this.lblTitleAddStudent = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblAddStudentName = new System.Windows.Forms.Label();
            this.lblAddStudentFirstname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(345, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 257);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sebastian";
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
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(176, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 252);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiago";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(509, 275);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 251);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dylan";
            // 
            // tbxAddStudentName
            // lblClassName
            // 
            this.tbxAddStudentName.Location = new System.Drawing.Point(67, 56);
            this.tbxAddStudentName.Name = "tbxAddStudentName";
            this.tbxAddStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStudentName.TabIndex = 0;
            // 
            // tbxAddStudentFirstname
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(7, 35);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(97, 13);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Nom de la classe  :";
            // 
            this.tbxAddStudentFirstname.Location = new System.Drawing.Point(67, 116);
            this.tbxAddStudentFirstname.Name = "tbxAddStudentFirstname";
            this.tbxAddStudentFirstname.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStudentFirstname.TabIndex = 1;
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
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(67, 174);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Ajouter";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // lblAddStudentName
            // 
            this.lblAddStudentName.AutoSize = true;
            this.lblAddStudentName.Location = new System.Drawing.Point(6, 59);
            this.lblAddStudentName.Name = "lblAddStudentName";
            this.lblAddStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblAddStudentName.TabIndex = 4;
            this.lblAddStudentName.Text = "Nom :";
            // 
            // lblAddStudentFirstname
            // 
            this.lblAddStudentFirstname.AutoSize = true;
            this.lblAddStudentFirstname.Location = new System.Drawing.Point(6, 119);
            this.lblAddStudentFirstname.Name = "lblAddStudentFirstname";
            this.lblAddStudentFirstname.Size = new System.Drawing.Size(49, 13);
            this.lblAddStudentFirstname.TabIndex = 5;
            this.lblAddStudentFirstname.Text = "Prenom :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 538);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbxAddStudentFirstname;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbxAddStudentName;
        private System.Windows.Forms.Label lblAddStudentFirstname;
        private System.Windows.Forms.Label lblAddStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblTitleAddStudent;
    }
}

