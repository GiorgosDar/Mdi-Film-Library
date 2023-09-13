namespace TelikhAskhsh
{
    partial class categories
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
            dataGridViewCat = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            btnaddcat = new Button();
            btndltcat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCat).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCat
            // 
            dataGridViewCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCat.Location = new Point(12, 222);
            dataGridViewCat.Name = "dataGridViewCat";
            dataGridViewCat.RowTemplate.Height = 25;
            dataGridViewCat.Size = new Size(240, 150);
            dataGridViewCat.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 113);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Νεα κατηγορια";
            // 
            // btnaddcat
            // 
            btnaddcat.Location = new Point(45, 172);
            btnaddcat.Name = "btnaddcat";
            btnaddcat.Size = new Size(138, 23);
            btnaddcat.TabIndex = 3;
            btnaddcat.Text = "Προσθηκη κατηγοριας";
            btnaddcat.UseVisualStyleBackColor = true;
            btnaddcat.Click += btnaddcat_Click;
            // 
            // btndltcat
            // 
            btndltcat.Location = new Point(45, 378);
            btndltcat.Name = "btndltcat";
            btndltcat.Size = new Size(158, 23);
            btndltcat.TabIndex = 4;
            btndltcat.Text = "Διαγραφη κατηγοριας";
            btndltcat.UseVisualStyleBackColor = true;
            btndltcat.Click += btndltcat_Click;
            // 
            // categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndltcat);
            Controls.Add(btnaddcat);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewCat);
            Name = "categories";
            Text = "categories";
            WindowState = FormWindowState.Maximized;
            Load += categories_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCat;
        private TextBox textBox1;
        private Label label1;
        private Button btnaddcat;
        private Button btndltcat;
    }
}