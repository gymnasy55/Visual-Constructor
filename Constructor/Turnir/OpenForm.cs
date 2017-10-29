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
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataName.Value1 = textBox1.Text;
            this.Close();
        }
    }
}
