namespace AP_06
{
    partial class Menu
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
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeNorméeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.décisionDuneÉtapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.décisionDuneÉtapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicamentsFamilleToolStripMenuItem,
            this.etapeNorméeToolStripMenuItem,
            this.workflowToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // médicamentsFamilleToolStripMenuItem
            // 
            this.médicamentsFamilleToolStripMenuItem.Name = "médicamentsFamilleToolStripMenuItem";
            this.médicamentsFamilleToolStripMenuItem.Size = new System.Drawing.Size(291, 28);
            this.médicamentsFamilleToolStripMenuItem.Text = "Médicaments / Famille";
            this.médicamentsFamilleToolStripMenuItem.Click += new System.EventHandler(this.médicamentsFamilleToolStripMenuItem_Click);
            // 
            // etapeNorméeToolStripMenuItem
            // 
            this.etapeNorméeToolStripMenuItem.Name = "etapeNorméeToolStripMenuItem";
            this.etapeNorméeToolStripMenuItem.Size = new System.Drawing.Size(291, 28);
            this.etapeNorméeToolStripMenuItem.Text = "Etape Normée";
            this.etapeNorméeToolStripMenuItem.Click += new System.EventHandler(this.etapeNorméeToolStripMenuItem_Click);
            // 
            // décisionDuneÉtapeToolStripMenuItem
            // 
            this.décisionDuneÉtapeToolStripMenuItem.Name = "décisionDuneÉtapeToolStripMenuItem";
            this.décisionDuneÉtapeToolStripMenuItem.Size = new System.Drawing.Size(206, 27);
            this.décisionDuneÉtapeToolStripMenuItem.Text = "Décision d\'une étape";
            this.décisionDuneÉtapeToolStripMenuItem.Click += new System.EventHandler(this.décisionDuneÉtapeToolStripMenuItem_Click);
            // 
            // workflowToolStripMenuItem
            // 
            this.workflowToolStripMenuItem.Name = "workflowToolStripMenuItem";
            this.workflowToolStripMenuItem.Size = new System.Drawing.Size(291, 28);
            this.workflowToolStripMenuItem.Text = "Workflow";
            this.workflowToolStripMenuItem.Click += new System.EventHandler(this.workflowToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem décisionDuneÉtapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etapeNorméeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workflowToolStripMenuItem;
    }
}