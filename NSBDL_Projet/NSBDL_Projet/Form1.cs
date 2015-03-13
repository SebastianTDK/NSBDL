using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBDL_Projet
{
    public partial class Form1 : Form
    {
        string ClassName { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClassName_Click(object sender, EventArgs e)
        {
            ClassName = tbxClassName.Text;
        }
    }
}
