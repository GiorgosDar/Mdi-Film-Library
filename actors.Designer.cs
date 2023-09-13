namespace TelikhAskhsh
{
    partial class actors
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
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridViewAct = new DataGridView();
            btnaddact = new Button();
            btndltact = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Νεοι ηθοποιοι";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridViewAct
            // 
            dataGridViewAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAct.Location = new Point(55, 167);
            dataGridViewAct.Name = "dataGridViewAct";
            dataGridViewAct.RowTemplate.Height = 25;
            dataGridViewAct.Size = new Size(240, 150);
            dataGridViewAct.TabIndex = 2;
            // 
            // btnaddact
            // 
            btnaddact.Location = new Point(55, 94);
            btnaddact.Name = "btnaddact";
            btnaddact.Size = new Size(154, 23);
            btnaddact.TabIndex = 3;
            btnaddact.Text = "Προσθηκη ηθοποιου";
            btnaddact.UseVisualStyleBackColor = true;
            btnaddact.Click += btnaddact_Click;
            // 
            // btndltact
            // 
            btndltact.Location = new Point(55, 338);
            btndltact.Name = "btndltact";
            btndltact.Size = new Size(198, 23);
            btndltact.TabIndex = 4;
            btndltact.Text = "Διαγραφη ηθοποιου";
            btndltact.UseVisualStyleBackColor = true;
            btndltact.Click += btndltact_Click;
            // 
            // actors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndltact);
            Controls.Add(btnaddact);
            Controls.Add(dataGridViewAct);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "actors";
            Text = "actors";
            WindowState = FormWindowState.Maximized;
            Load += actors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridViewAct;
        private Button btnaddact;
        private Button btndltact;
    }
}