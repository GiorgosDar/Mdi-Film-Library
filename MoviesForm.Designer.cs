namespace TelikhAskhsh
{
    partial class MoviesForm
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtimage = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            checkBox1 = new CheckBox();
            textImdb = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtmovie = new TextBox();
            label1 = new Label();
            btnAddMovies = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 212);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtimage);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textImdb);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtmovie);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 187);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Προσθηκη ταινιας";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(495, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(110, 23);
            comboBox2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(509, 27);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 14;
            label7.Text = "Διαθεσιμο σε";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 109);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 13;
            label6.Text = "Κατηγορια";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(253, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 63);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "image";
            // 
            // txtimage
            // 
            txtimage.Location = new Point(253, 81);
            txtimage.Name = "txtimage";
            txtimage.Size = new Size(100, 23);
            txtimage.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(229, 33);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(206, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 15);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Ποτε το ειδα";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Το εχω δει";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textImdb
            // 
            textImdb.Location = new Point(6, 125);
            textImdb.Name = "textImdb";
            textImdb.Size = new Size(100, 23);
            textImdb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 107);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "iMDB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "Ημερομηνια κυκλοφοριας";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtmovie
            // 
            txtmovie.Location = new Point(6, 37);
            txtmovie.Name = "txtmovie";
            txtmovie.Size = new Size(100, 23);
            txtmovie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Τιτλος";
            // 
            // btnAddMovies
            // 
            btnAddMovies.Location = new Point(661, 73);
            btnAddMovies.Name = "btnAddMovies";
            btnAddMovies.Size = new Size(127, 23);
            btnAddMovies.TabIndex = 2;
            btnAddMovies.Text = "Προσθηκη ταινιας";
            btnAddMovies.UseVisualStyleBackColor = true;
            btnAddMovies.Click += btnAddMovies_Click;
            // 
            // MoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnAddMovies);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MoviesForm";
            Text = "MoviesForm";
            WindowState = FormWindowState.Maximized;
            Load += MoviesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtmovie;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtimage;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox textImdb;
        private Label label4;
        private ComboBox comboBox2;
        private Label label7;
        private Label label6;
        private Button btnAddMovies;
    }
}