using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace turnir
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadForm form = new LoadForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm f1 = new TestForm();
            f1.ShowDialog();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            Work WorkForm = new Work();
            WorkForm.Show();
        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Formules.docx");
        }
    }
}
