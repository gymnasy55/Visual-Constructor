namespace turnir
{
    partial class MainMenu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFormula = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(434, 162);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Конструктор";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFormula
            // 
            this.btnFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFormula.Location = new System.Drawing.Point(13, 180);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(433, 161);
            this.btnFormula.TabIndex = 1;
            this.btnFormula.Text = "Формули";
            this.btnFormula.UseVisualStyleBackColor = true;
            this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
            // 
            // btnWork
            // 
            this.btnWork.Enabled = false;
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWork.Location = new System.Drawing.Point(13, 347);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(433, 161);
            this.btnWork.TabIndex = 2;
            this.btnWork.Text = "Лабораторні роботи";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 524);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnFormula);
            this.Controls.Add(this.btnStart);
            this.Name = "MainMenu";
            this.Text = "Visual Constructor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFormula;
        private System.Windows.Forms.Button btnWork;
    }
}

