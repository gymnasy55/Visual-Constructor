using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace turnir
{
    public partial class MainForm : Form
    {
        Graphics gr;
        Pen p;
        int x, y, col, row, col1, row1, Yc, Xc;
        string str = "";
        Pen b = Pens.LightSlateGray;
        int[,] saveCure = new int[20, 20];
        Pen a = new Pen(Color.FromArgb(0, 0, 0), 2);
        int[] saveRedo = new int[4];
        int[] saveUndo = new int[4];

        public MainForm()
        {
            InitializeComponent();
            gr = Graphics.FromHwnd(this.Handle);
            x = 2;
            y = 27;
        }
        private void резисторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "resistor";
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.Location.X;
            int Y = e.Location.Y;
            row1 = Convert.ToInt32(Math.Truncate(((Y - 27) / 80.0) + 1));
            col1 = Convert.ToInt32(Math.Truncate(((X - 2) / 80.0) + 1));
            if (col1 > DataCol.Value || row1 > DataRow.Value)
            {
                MessageBox.Show("Вы натиснули  зовні поля", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Xc = 80 * (col1 - 1) + 40 + 2;
                DataCol.Value1 = Xc;
                Yc = 80 * (row1 - 1) + 40 + 27;
                DataRow.Value1 = Yc;

                /*null=0 
                 corner1=1
                 corner2=2
                 corner3=3
                 corner4=4
                 resistor=5
                 light=6
                 capacitor=7
                 battery=8
                 horizontal=9
                 vertical=10*/
                
                saveUndo[0] = col1;
                saveUndo[1] = row1;
                saveUndo[2] = saveCure[col1 - 1, row1 - 1];
                undoToolStripMenuItem.Enabled = true;
                redoToolStripMenuItem.Enabled = false;

                if (str == "resistor")
                {
                    ResistorPaint(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 5;
                    str = "";
                }
                else if (str == "light")
                {
                    LightPaint(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 6;
                    str = "";
                }
                else if (str == "capacitor")
                {
                    CapacitorPaint(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 7;
                    str = "";
                }
                else if (str == "battery")
                {
                    BatteryPaint(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 8;
                    str = "";
                }
                else if (str == "Horizontal")
                {
                    HorizontalPaint(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 9;
                }
                else if (str == "Vertical")
                {
                    VerticalPaint(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 10;
                }
                else if (str == "1")
                {
                    Paint1(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 1;
                }
                else if (str == "2")
                {
                    Paint2(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 2;
                }
                else if (str == "3")
                {
                    Paint3(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 3;
                }
                else if (str == "4")
                {
                    Paint4(Xc, Yc);
                    saveCure[col1 - 1, row1 - 1] = 4;
                }
                else if (str == "delete")
                {
                    if (saveCure[col1-1,row1-1]==8) { источникToolStripMenuItem.Enabled = true; }
                    DeleteCell(Xc, Yc, col1 - 1, row1 - 1, saveCure);
                    
                }
                else if (str == "")
                {
                    MessageBox.Show("Выберите елемент", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                saveUndo[3] = saveCure[col1 - 1, row1 - 1];
            }
        }



        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void лампочкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "light";
        }



        private void конденсаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "capacitor";
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            x = 2;
            y = 27;
            for (int i = 0; i < DataRow.Value; i++)
            {
                for (int j = 0; j < DataCol.Value; j++)
                {
                    gr.FillRectangle(Brushes.White, x, y, 80, 80);
                    gr.DrawRectangle(b, x, y, 80, 80);
                    x += 80;
                }
                x = 2;
                y += 80;
            }
        }

        private void источникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "battery";
            источникToolStripMenuItem.Enabled = false;
        }

        private void горизонтальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "Horizontal";
        }

        private void ResistorPaint(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(a, xc - 30, yc - 10, 60, 20);
            gr.DrawLine(a, xc - 40, yc, xc - 30, yc);
            gr.DrawLine(a, xc + 40, yc, xc + 30, yc);
        }

        private void LightPaint(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);

            gr.DrawEllipse(a, xc - 30, yc - 30, 60, 60);
            gr.DrawLine(a, xc, yc, xc + 21, yc - 21);
            gr.DrawLine(a, xc, yc, xc + 21, yc + 21);
            gr.DrawLine(a, xc, yc, xc - 21, yc - 21);
            gr.DrawLine(a, xc, yc, xc - 21, yc + 21);
            gr.DrawLine(a, xc - 40, yc, xc - 30, yc);
            gr.DrawLine(a, xc + 40, yc, xc + 30, yc);
        }

        private void вертикальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "Vertical";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            str = "1";
        }

        private void HorizontalPaint(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc - 40, yc, xc + 40, yc);
        }

        private void Paint1(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc - 40, yc, xc, yc);
            gr.DrawLine(a, xc, yc + 40, xc, yc);
        }

        private void Paint2(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc, yc - 40, xc, yc);
            gr.DrawLine(a, xc - 40, yc, xc, yc);
        }

        private void Paint3(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc + 40, yc, xc, yc);
            gr.DrawLine(a, xc, yc, xc, yc - 40);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            str = "2";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            str = "3";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            str = "4";
        }

        private void очиститиКлітинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "delete";
        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void формулиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Formules.docx");
        }

        private void LoadForm(int xc,int yc, int[,] q)
        {
            for (int i = 0; i < DataRow.Value; i++)
            {
                for (int j = 0; j < DataCol.Value; j++)
                {
                    switch (q[i,j])
                    {
                        case 0:
                            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
                            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
                            break;
                        case 1:
                            Paint1(xc, yc);
                            break;
                        case 2:
                            Paint2(xc, yc);
                            break;
                        case 3:
                            Paint3(xc, yc);
                            break;
                        case 4:
                            Paint4(xc, yc);
                            break;
                        case 5:
                            ResistorPaint(xc, yc);
                            break;
                        case 6:
                            LightPaint(xc, yc);
                            break;
                        case 7:
                            CapacitorPaint(xc, yc);
                            break;
                        case 8:
                            BatteryPaint(xc, yc);
                            break;
                        case 9:
                            HorizontalPaint(xc, yc);
                            break;
                        case 10:
                            VerticalPaint(xc, yc);
                            break;
                    }
                }
            }
        }
        private void DeleteCell(int xc, int yc, int col1, int row1, int[,] saveCure)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);

            saveUndo[0] = col1;
            saveUndo[1] = row1;
            saveUndo[2] = saveCure[col1, row1];
            saveUndo[3] = 0;

            saveCure[col1, row1] = 0;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm form = new OpenForm();
            form.ShowDialog();
            string name = DataName.Value1 + ".txt";
            using (StreamReader r = new StreamReader(name))
            {
                string[] RowCol;
                RowCol = r.ReadLine().Split(' ');
                string[] s1;
                int[,] a = new int[Convert.ToInt32(RowCol[0]), Convert.ToInt32(RowCol[1])];
                for(int i = 0; i < Convert.ToInt32(RowCol[0]); i++)
                {
                    Yc= 80 * (i) + 40 + 27;
                    s1 = r.ReadLine().Split(' ');
                    for (int j = 0; j < Convert.ToInt32(RowCol[1]); j++)
                    {
                        a[i, j] = Convert.ToInt32(s1[j]);
                        Switchfunc(80 * (j) + 40 + 2, Yc, a[i, j]);
                        saveCure[j,i] = a[i, j];
                        if (a[i, j] == 8) { источникToolStripMenuItem.Enabled = false; }
                    }
                }
                DataRow.Value = Convert.ToInt32(RowCol[0]);
                DataCol.Value = Convert.ToInt32(RowCol[1]);
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm form = new SaveForm();
            form.ShowDialog();
            string name = DataName.Value + ".txt";
            using (StreamWriter w = new StreamWriter(name))
            {
                w.Write(DataRow.Value.ToString() + " " + DataCol.Value.ToString());
                w.WriteLine();
                for (int i = 1; i < DataRow.Value + 1; i++)
                {
                    for(int j = 0; j < DataCol.Value; j++)
                    {
                        w.Write(saveCure[j, i - 1].ToString() + " ");
                    }
                    w.WriteLine();
                }
            }
        }

        private void перевіркаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* int q=0;
            for (int i= 0;i<DataCol.Value;i++)
            {
                for(int j=0; j<DataRow.Value;j++)
                {
                    switch (saveCure[i,j])
                    {
                        case 0:
                            
                            break;
                        case 1:
                            if (i != 0)
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 6 || saveCure[i - 1, j] == 7 || saveCure[i - 1, j] == 8 || saveCure[i - 1, j] == 9) && (saveCure[i, j + 1] == 2 || saveCure[i, j + 1] == 3 || saveCure[i, j + 1] == 10))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 2:
                            if ((i != 0)&&(j!=0))
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 6 || saveCure[i - 1, j] == 7 || saveCure[i - 1, j] == 8 || saveCure[i - 1, j] == 9) && (saveCure[i, j - 1] == 1 || saveCure[i, j - 1] == 4 || saveCure[i, j - 1] == 10))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 3:
                            if (j != 0)
                            {
                                if ((saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 6 || saveCure[i + 1, j] == 7 || saveCure[i + 1, j] == 8 || saveCure[i + 1, j] == 9) && (saveCure[i, j + 1] == 2 || saveCure[i, j + 1] == 3 || saveCure[i, j + 1] == 10))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 4:
                            if ((saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 6 || saveCure[i + 1, j] == 7 || saveCure[i + 1, j] == 8 || saveCure[i + 1, j] == 9) && (saveCure[i, j + 1] == 2 || saveCure[i, j + 1] == 3 || saveCure[i, j + 1] == 10))
                            {

                            }
                            else
                            {
                                q = 1;
                            }
                            break;
                        case 5:
                            if (i != 0)
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 6 || saveCure[i - 1, j] == 7 || saveCure[i - 1, j] == 8 || saveCure[i - 1, j] == 9) && (saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 6 || saveCure[i + 1, j] == 7 || saveCure[i + 1, j] == 8 || saveCure[i + 1, j] == 9))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 6:
                            if (i != 0)
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 5 || saveCure[i - 1, j] == 7 || saveCure[i - 1, j] == 8 || saveCure[i - 1, j] == 9) && (saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 5 || saveCure[i + 1, j] == 7 || saveCure[i + 1, j] == 8 || saveCure[i + 1, j] == 9))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 7:
                            if (i != 0)
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 6 || saveCure[i - 1, j] == 5 || saveCure[i - 1, j] == 8 || saveCure[i - 1, j] == 9) && (saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 6 || saveCure[i + 1, j] == 5 || saveCure[i + 1, j] == 8 || saveCure[i + 1, j] == 9))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 8:
                            if (i != 0)
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 6 || saveCure[i - 1, j] == 7 || saveCure[i - 1, j] == 5 || saveCure[i - 1, j] == 9) && (saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 6 || saveCure[i + 1, j] == 7 || saveCure[i + 1, j] == 5 || saveCure[i + 1, j] == 9))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 9:
                            if (i != 0)
                            {
                                if ((saveCure[i - 1, j] == 4 || saveCure[i - 1, j] == 3 || saveCure[i - 1, j] == 6 || saveCure[i - 1, j] == 7 || saveCure[i - 1, j] == 8 || saveCure[i - 1, j] == 5) && (saveCure[i + 1, j] == 1 || saveCure[i + 1, j] == 2 || saveCure[i + 1, j] == 6 || saveCure[i + 1, j] == 7 || saveCure[i + 1, j] == 8 || saveCure[i + 1, j] == 5))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                        case 10:
                            if (i != 0)
                            {
                                if((saveCure[i, j + 1] == 2 || saveCure[i, j + 1] == 3 || saveCure[i, j + 1] == 10)&& (saveCure[i, j - 1] == 4 || saveCure[i, j - 1] == 1))
                                {

                                }
                                else
                                {
                                    q = 1;
                                }
                            }
                            break;
                    }
                }
            }
            if (q == 1)
            {
                MessageBox.Show("Схема не замкнута", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Схема замкнута", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } */
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveRedo[0] = col1;
            saveRedo[1] = row1;
            saveRedo[3] = saveUndo[2];
            if (saveCure[col1 - 1, row1 - 1] == 8) { источникToolStripMenuItem.Enabled = true; }
            Switchfunc(80 * (col1 - 1) + 40 + 2, 80 * (row1 - 1) + 40 + 27, saveRedo[2]);
            saveCure[col1 - 1, row1 - 1] = saveRedo[2];
            if (saveCure[col1 - 1, row1 - 1] == 8) { источникToolStripMenuItem.Enabled = false; }
            redoToolStripMenuItem.Enabled = false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveRedo[0] = col1;
            saveRedo[1] = row1;
            saveRedo[3] = saveUndo[2];
            undoToolStripMenuItem.Enabled = false; 
            saveRedo[2] = saveUndo[3];
            if (saveCure[col1 - 1, row1 - 1] == 8) { источникToolStripMenuItem.Enabled = true; }
            Switchfunc(80 * (col1 - 1) + 40 + 2, 80 * (row1 - 1) + 40 + 27, saveUndo[2]);
            saveCure[col1 - 1, row1 - 1] = saveUndo[2];
            if (saveCure[col1 - 1, row1 - 1] == 8) { источникToolStripMenuItem.Enabled = false; }
            redoToolStripMenuItem.Enabled = true;
        }

        private void Paint4(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc, yc + 40, xc, yc);
            gr.DrawLine(a, xc, yc, xc + 40, yc);
        }

        private void VerticalPaint(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc, yc - 40, xc, yc + 40);
        }

        private void CapacitorPaint(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc - 5, yc - 20, xc - 5, yc + 20);
            gr.DrawLine(a, xc + 5, yc - 20, xc + 5, yc + 20);
            gr.DrawLine(a, xc - 40, yc, xc - 5, yc);
            gr.DrawLine(a, xc + 40, yc, xc + 5, yc);
        }

        private void BatteryPaint(int xc, int yc)
        {
            gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
            gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
            gr.DrawLine(a, xc - 5, yc - 20, xc - 5, yc + 20);
            gr.DrawLine(a, xc + 5, yc - 10, xc + 5, yc + 10);
            gr.DrawLine(a, xc - 40, yc, xc - 5, yc);
            gr.DrawLine(a, xc + 40, yc, xc + 5, yc);
        }

        private void Switchfunc(int xc,int yc, int q)
        {
            switch (q)
            {
                case 0:
                    gr.FillRectangle(Brushes.White, xc - 40, yc - 40, 80, 80);
                    gr.DrawRectangle(b, xc - 40, yc - 40, 80, 80);
                    break;
                case 1:
                    Paint1(xc, yc);
                    break;
                case 2:
                    Paint2(xc, yc);
                    break;
                case 3:
                    Paint3(xc, yc);
                    break;
                case 4:
                    Paint4(xc, yc);
                    break;
                case 5:
                    ResistorPaint(xc, yc);
                    break;
                case 6:
                    LightPaint(xc, yc);
                    break;
                case 7:
                    CapacitorPaint(xc, yc);
                    break;
                case 8:
                    BatteryPaint(xc, yc);
                    break;
                case 9:
                    HorizontalPaint(xc, yc);
                    break;
                case 10:
                    VerticalPaint(xc, yc);
                    break;
            }
        }
    }
}   