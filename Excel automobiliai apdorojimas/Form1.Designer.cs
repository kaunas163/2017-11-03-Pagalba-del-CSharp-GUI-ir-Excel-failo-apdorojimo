namespace Excel_automobiliai_apdorojimas
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuskaitytiFailąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atliktiSkaičiavimusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išeitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuskaitytiFailąToolStripMenuItem,
            this.atliktiSkaičiavimusToolStripMenuItem,
            this.išeitiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuskaitytiFailąToolStripMenuItem
            // 
            this.nuskaitytiFailąToolStripMenuItem.Name = "nuskaitytiFailąToolStripMenuItem";
            this.nuskaitytiFailąToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.nuskaitytiFailąToolStripMenuItem.Text = "Nuskaityti failą";
            this.nuskaitytiFailąToolStripMenuItem.Click += new System.EventHandler(this.nuskaitytiFailąToolStripMenuItem_Click);
            // 
            // atliktiSkaičiavimusToolStripMenuItem
            // 
            this.atliktiSkaičiavimusToolStripMenuItem.Name = "atliktiSkaičiavimusToolStripMenuItem";
            this.atliktiSkaičiavimusToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.atliktiSkaičiavimusToolStripMenuItem.Text = "Atlikti skaičiavimus";
            this.atliktiSkaičiavimusToolStripMenuItem.Click += new System.EventHandler(this.atliktiSkaičiavimusToolStripMenuItem_Click);
            // 
            // išeitiToolStripMenuItem
            // 
            this.išeitiToolStripMenuItem.Name = "išeitiToolStripMenuItem";
            this.išeitiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.išeitiToolStripMenuItem.Text = "Išeiti";
            this.išeitiToolStripMenuItem.Click += new System.EventHandler(this.išeitiToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 430);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Automobilių duomenys";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuskaitytiFailąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atliktiSkaičiavimusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išeitiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

