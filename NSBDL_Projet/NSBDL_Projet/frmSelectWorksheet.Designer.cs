namespace NSBDL_Projet
{
    partial class frmSelectWorksheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxExcelPath = new System.Windows.Forms.TextBox();
            this.lblModelPath = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblSelectWorksheet = new System.Windows.Forms.Label();
            this.cmbWorksheet = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxExcelPath
            // 
            this.tbxExcelPath.BackColor = System.Drawing.Color.White;
            this.tbxExcelPath.Location = new System.Drawing.Point(12, 36);
            this.tbxExcelPath.Name = "tbxExcelPath";
            this.tbxExcelPath.ReadOnly = true;
            this.tbxExcelPath.Size = new System.Drawing.Size(298, 20);
            this.tbxExcelPath.TabIndex = 0;
            this.tbxExcelPath.TabStop = false;
            // 
            // lblModelPath
            // 
            this.lblModelPath.AutoSize = true;
            this.lblModelPath.Location = new System.Drawing.Point(13, 13);
            this.lblModelPath.Name = "lblModelPath";
            this.lblModelPath.Size = new System.Drawing.Size(94, 13);
            this.lblModelPath.TabIndex = 1;
            this.lblModelPath.Text = "Excel model path :";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(316, 34);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(77, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblSelectWorksheet
            // 
            this.lblSelectWorksheet.AutoSize = true;
            this.lblSelectWorksheet.Location = new System.Drawing.Point(13, 71);
            this.lblSelectWorksheet.Name = "lblSelectWorksheet";
            this.lblSelectWorksheet.Size = new System.Drawing.Size(126, 13);
            this.lblSelectWorksheet.TabIndex = 3;
            this.lblSelectWorksheet.Text = "Select model worksheet :";
            // 
            // cmbWorksheet
            // 
            this.cmbWorksheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorksheet.Enabled = false;
            this.cmbWorksheet.FormattingEnabled = true;
            this.cmbWorksheet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbWorksheet.Location = new System.Drawing.Point(12, 96);
            this.cmbWorksheet.Name = "cmbWorksheet";
            this.cmbWorksheet.Size = new System.Drawing.Size(195, 21);
            this.cmbWorksheet.TabIndex = 4;
            this.cmbWorksheet.SelectedIndexChanged += new System.EventHandler(this.cmbWorksheet_SelectedIndexChanged);
            // 
            // btnImport
            // 
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(213, 94);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(180, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import worksheet";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmSelectWorksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 127);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cmbWorksheet);
            this.Controls.Add(this.lblSelectWorksheet);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblModelPath);
            this.Controls.Add(this.tbxExcelPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelectWorksheet";
            this.Text = "Select model worksheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxExcelPath;
        private System.Windows.Forms.Label lblModelPath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblSelectWorksheet;
        private System.Windows.Forms.ComboBox cmbWorksheet;
        private System.Windows.Forms.Button btnImport;
    }
}