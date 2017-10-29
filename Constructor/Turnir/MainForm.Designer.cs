namespace turnir
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лампочкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резисторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конденсаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.угловойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.источникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиКлітинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авториToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевіркаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.перевіркаToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(447, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.сохранитьToolStripMenuItem.Text = "Зберегти";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.загрузитьToolStripMenuItem.Text = "Завантажити";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.undoToolStripMenuItem.Text = "Назад";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.redoToolStripMenuItem.Text = "Вперед";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click_1);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.выйтиToolStripMenuItem.Text = "Вийти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лампочкаToolStripMenuItem,
            this.резисторToolStripMenuItem,
            this.конденсаторToolStripMenuItem,
            this.проводаToolStripMenuItem,
            this.источникToolStripMenuItem,
            this.очиститиКлітинуToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.инструментыToolStripMenuItem.Text = "Інструменти";
            // 
            // лампочкаToolStripMenuItem
            // 
            this.лампочкаToolStripMenuItem.Name = "лампочкаToolStripMenuItem";
            this.лампочкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.лампочкаToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.лампочкаToolStripMenuItem.Text = "Лампочка";
            this.лампочкаToolStripMenuItem.Click += new System.EventHandler(this.лампочкаToolStripMenuItem_Click);
            // 
            // резисторToolStripMenuItem
            // 
            this.резисторToolStripMenuItem.Name = "резисторToolStripMenuItem";
            this.резисторToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.резисторToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.резисторToolStripMenuItem.Text = "Резистор";
            this.резисторToolStripMenuItem.Click += new System.EventHandler(this.резисторToolStripMenuItem_Click);
            // 
            // конденсаторToolStripMenuItem
            // 
            this.конденсаторToolStripMenuItem.Name = "конденсаторToolStripMenuItem";
            this.конденсаторToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.конденсаторToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.конденсаторToolStripMenuItem.Text = "Конденсатор";
            this.конденсаторToolStripMenuItem.Click += new System.EventHandler(this.конденсаторToolStripMenuItem_Click);
            // 
            // проводаToolStripMenuItem
            // 
            this.проводаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.горизонтальныйToolStripMenuItem,
            this.вертикальныйToolStripMenuItem,
            this.угловойToolStripMenuItem});
            this.проводаToolStripMenuItem.Name = "проводаToolStripMenuItem";
            this.проводаToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.проводаToolStripMenuItem.Text = "Дріт";
            // 
            // горизонтальныйToolStripMenuItem
            // 
            this.горизонтальныйToolStripMenuItem.Name = "горизонтальныйToolStripMenuItem";
            this.горизонтальныйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.горизонтальныйToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.горизонтальныйToolStripMenuItem.Text = "Горизонтальний";
            this.горизонтальныйToolStripMenuItem.Click += new System.EventHandler(this.горизонтальныйToolStripMenuItem_Click);
            // 
            // вертикальныйToolStripMenuItem
            // 
            this.вертикальныйToolStripMenuItem.Name = "вертикальныйToolStripMenuItem";
            this.вертикальныйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.вертикальныйToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.вертикальныйToolStripMenuItem.Text = "Вертикальний";
            this.вертикальныйToolStripMenuItem.Click += new System.EventHandler(this.вертикальныйToolStripMenuItem_Click);
            // 
            // угловойToolStripMenuItem
            // 
            this.угловойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.угловойToolStripMenuItem.Name = "угловойToolStripMenuItem";
            this.угловойToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.угловойToolStripMenuItem.Text = "Кутовий";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // источникToolStripMenuItem
            // 
            this.источникToolStripMenuItem.Name = "источникToolStripMenuItem";
            this.источникToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.источникToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.источникToolStripMenuItem.Text = "Джерело";
            this.источникToolStripMenuItem.Click += new System.EventHandler(this.источникToolStripMenuItem_Click);
            // 
            // очиститиКлітинуToolStripMenuItem
            // 
            this.очиститиКлітинуToolStripMenuItem.Name = "очиститиКлітинуToolStripMenuItem";
            this.очиститиКлітинуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D0)));
            this.очиститиКлітинуToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.очиститиКлітинуToolStripMenuItem.Text = "Очистити клітину";
            this.очиститиКлітинуToolStripMenuItem.Click += new System.EventHandler(this.очиститиКлітинуToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авториToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.правкаToolStripMenuItem.Text = "Довідка";
            this.правкаToolStripMenuItem.Click += new System.EventHandler(this.правкаToolStripMenuItem_Click);
            // 
            // авториToolStripMenuItem
            // 
            this.авториToolStripMenuItem.Name = "авториToolStripMenuItem";
            this.авториToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.авториToolStripMenuItem.Text = "Автори";
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формулиToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // формулиToolStripMenuItem
            // 
            this.формулиToolStripMenuItem.Name = "формулиToolStripMenuItem";
            this.формулиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.формулиToolStripMenuItem.Text = "Формули";
            this.формулиToolStripMenuItem.Click += new System.EventHandler(this.формулиToolStripMenuItem_Click);
            // 
            // перевіркаToolStripMenuItem
            // 
            this.перевіркаToolStripMenuItem.Name = "перевіркаToolStripMenuItem";
            this.перевіркаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.перевіркаToolStripMenuItem.Text = "Перевірка";
            this.перевіркаToolStripMenuItem.Click += new System.EventHandler(this.перевіркаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 624);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Visual Constructor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лампочкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резисторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конденсаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem источникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem угловойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem очиститиКлітинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авториToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевіркаToolStripMenuItem;
    }
}