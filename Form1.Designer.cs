namespace TelikhAskhsh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ταινίεςToolStripMenuItem = new ToolStripMenuItem();
            κατηγορίεςToolStripMenuItem = new ToolStripMenuItem();
            btnCategory = new ToolStripMenuItem();
            btnActor = new ToolStripMenuItem();
            btnapp = new ToolStripMenuItem();
            εξοδοςToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ταινίεςToolStripMenuItem, κατηγορίεςToolStripMenuItem, εξοδοςToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ταινίεςToolStripMenuItem
            // 
            ταινίεςToolStripMenuItem.Name = "ταινίεςToolStripMenuItem";
            ταινίεςToolStripMenuItem.Size = new Size(55, 20);
            ταινίεςToolStripMenuItem.Text = "Ταινίες";
            ταινίεςToolStripMenuItem.Click += ταινίεςToolStripMenuItem_Click;
            // 
            // κατηγορίεςToolStripMenuItem
            // 
            κατηγορίεςToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnCategory, btnActor, btnapp });
            κατηγορίεςToolStripMenuItem.Name = "κατηγορίεςToolStripMenuItem";
            κατηγορίεςToolStripMenuItem.Size = new Size(71, 20);
            κατηγορίεςToolStripMenuItem.Text = "Ρυθμίσεις";
            // 
            // btnCategory
            // 
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(180, 22);
            btnCategory.Text = "Κατηγοριες";
            btnCategory.Click += btnCategory_Click;
            // 
            // btnActor
            // 
            btnActor.Name = "btnActor";
            btnActor.Size = new Size(180, 22);
            btnActor.Text = "Ηθοποιος";
            btnActor.Click += ηθοποιοςToolStripMenuItem_Click;
            // 
            // btnapp
            // 
            btnapp.Name = "btnapp";
            btnapp.Size = new Size(180, 22);
            btnapp.Text = "Application";
            btnapp.Click += btnapp_Click;
            // 
            // εξοδοςToolStripMenuItem
            // 
            εξοδοςToolStripMenuItem.Name = "εξοδοςToolStripMenuItem";
            εξοδοςToolStripMenuItem.Size = new Size(57, 20);
            εξοδοςToolStripMenuItem.Text = "Εξοδος";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MoviesForm";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ταινίεςToolStripMenuItem;
        private ToolStripMenuItem κατηγορίεςToolStripMenuItem;
        private ToolStripMenuItem εξοδοςToolStripMenuItem;
        private ToolStripMenuItem btnCategory;
        private ToolStripMenuItem btnActor;
        private ToolStripMenuItem btnapp;
    }
}