namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.четыреКругаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.четыреКругаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.восемьКруговToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rdfToolStripMenuItem,
            this.кругToolStripMenuItem,
            this.четыреКругаToolStripMenuItem,
            this.четыреКругаToolStripMenuItem1,
            this.восемьКруговToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rdfToolStripMenuItem
            // 
            this.rdfToolStripMenuItem.Name = "rdfToolStripMenuItem";
            this.rdfToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rdfToolStripMenuItem.Text = "Квадрат";
            this.rdfToolStripMenuItem.Click += new System.EventHandler(this.rdfToolStripMenuItem_Click);
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // четыреКругаToolStripMenuItem
            // 
            this.четыреКругаToolStripMenuItem.Name = "четыреКругаToolStripMenuItem";
            this.четыреКругаToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.четыреКругаToolStripMenuItem.Text = "Много кругов";
            this.четыреКругаToolStripMenuItem.Click += new System.EventHandler(this.четыреКругаToolStripMenuItem_Click);
            // 
            // четыреКругаToolStripMenuItem1
            // 
            this.четыреКругаToolStripMenuItem1.Name = "четыреКругаToolStripMenuItem1";
            this.четыреКругаToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.четыреКругаToolStripMenuItem1.Text = "Четыре круга";
            this.четыреКругаToolStripMenuItem1.Click += new System.EventHandler(this.четыреКругаToolStripMenuItem1_Click);
            // 
            // восемьКруговToolStripMenuItem
            // 
            this.восемьКруговToolStripMenuItem.Name = "восемьКруговToolStripMenuItem";
            this.восемьКруговToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.восемьКруговToolStripMenuItem.Text = "Восемь кругов";
            this.восемьКруговToolStripMenuItem.Click += new System.EventHandler(this.восемьКруговToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem четыреКругаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem четыреКругаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem восемьКруговToolStripMenuItem;
    }
}

