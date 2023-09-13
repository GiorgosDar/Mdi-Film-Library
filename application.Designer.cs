namespace TelikhAskhsh
{
    partial class application
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
            dataGridViewApp = new DataGridView();
            btnaddapp = new Button();
            btndltapp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridViewApp
            // 
            dataGridViewApp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApp.Location = new Point(58, 164);
            dataGridViewApp.Name = "dataGridViewApp";
            dataGridViewApp.RowTemplate.Height = 25;
            dataGridViewApp.Size = new Size(240, 150);
            dataGridViewApp.TabIndex = 2;
            // 
            // btnaddapp
            // 
            btnaddapp.Location = new Point(58, 115);
            btnaddapp.Name = "btnaddapp";
            btnaddapp.Size = new Size(137, 23);
            btnaddapp.TabIndex = 3;
            btnaddapp.Text = "Προσθηκη εφαρμογης";
            btnaddapp.UseVisualStyleBackColor = true;
            btnaddapp.Click += btnaddapp_Click;
            // 
            // btndltapp
            // 
            btndltapp.Location = new Point(58, 320);
            btndltapp.Name = "btndltapp";
            btndltapp.Size = new Size(153, 23);
            btndltapp.TabIndex = 4;
            btndltapp.Text = "Διαγραφη εφαρμογης";
            btndltapp.UseVisualStyleBackColor = true;
            btndltapp.Click += btndltapp_Click;
            // 
            // application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndltapp);
            Controls.Add(btnaddapp);
            Controls.Add(dataGridViewApp);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "application";
            Text = "application";
            WindowState = FormWindowState.Maximized;
            Load += application_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridViewApp;
        private Button btnaddapp;
        private Button btndltapp;
    }
}