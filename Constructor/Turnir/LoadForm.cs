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
    public partial class LoadForm : Form
    {
        int col, row;
        public LoadForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (txtCol.Text == "" || txtRow.Text == "")
            {
                MessageBox.Show("Поле не повинно бути порожнім", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                col = Convert.ToInt32(txtCol.Text);
                row = Convert.ToInt32(txtRow.Text);
                if (col <= 0 || row <= 0)
                {
                    MessageBox.Show("Введіть значення більше 0", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (col > 17)
                {
                    MessageBox.Show("Введіть кіл-ть стовпців менше 18", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (row > 8)
                {
                    MessageBox.Show("Введіть кіл-ть рядків менше 9", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainForm form = new MainForm();
                    DataCol.Value = col;
                    DataRow.Value = row;
                    form.Show();
                    this.Close();
                }
            }
        }
    }
}
