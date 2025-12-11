namespace testtt
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
            lbl_NamaKaryawan = new Label();
            lbl_Departemen = new Label();
            lbl_KaryawanTerpilih = new Label();
            lbl_Jabatan = new Label();
            dgv_karyawan = new DataGridView();
            comboBox1 = new ComboBox();
            comboBoxJabatan = new ComboBox();
            pb_Logo = new PictureBox();
            textBox1 = new TextBox();
            info_dep = new Label();
            btn_Insert = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Load = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_karyawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // lbl_NamaKaryawan
            // 
            lbl_NamaKaryawan.AutoSize = true;
            lbl_NamaKaryawan.Location = new Point(68, 185);
            lbl_NamaKaryawan.Margin = new Padding(5, 0, 5, 0);
            lbl_NamaKaryawan.Name = "lbl_NamaKaryawan";
            lbl_NamaKaryawan.Size = new Size(158, 25);
            lbl_NamaKaryawan.TabIndex = 0;
            lbl_NamaKaryawan.Text = "Nama Karyawan   :";
            // 
            // lbl_Departemen
            // 
            lbl_Departemen.AutoSize = true;
            lbl_Departemen.Location = new Point(68, 258);
            lbl_Departemen.Margin = new Padding(5, 0, 5, 0);
            lbl_Departemen.Name = "lbl_Departemen";
            lbl_Departemen.Size = new Size(153, 25);
            lbl_Departemen.TabIndex = 1;
            lbl_Departemen.Text = "Dep. Karyawan    :";
            // 
            // lbl_KaryawanTerpilih
            // 
            lbl_KaryawanTerpilih.AutoSize = true;
            lbl_KaryawanTerpilih.Location = new Point(1045, 433);
            lbl_KaryawanTerpilih.Margin = new Padding(5, 0, 5, 0);
            lbl_KaryawanTerpilih.Name = "lbl_KaryawanTerpilih";
            lbl_KaryawanTerpilih.Size = new Size(31, 25);
            lbl_KaryawanTerpilih.TabIndex = 2;
            lbl_KaryawanTerpilih.Text = "\" \"";
            // 
            // lbl_Jabatan
            // 
            lbl_Jabatan.AutoSize = true;
            lbl_Jabatan.Location = new Point(68, 331);
            lbl_Jabatan.Margin = new Padding(5, 0, 5, 0);
            lbl_Jabatan.Name = "lbl_Jabatan";
            lbl_Jabatan.Size = new Size(161, 25);
            lbl_Jabatan.TabIndex = 2;
            lbl_Jabatan.Text = "Jabatan Karyawan :";
            // 
            // dgv_karyawan
            // 
            dgv_karyawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_karyawan.Location = new Point(73, 490);
            dgv_karyawan.Margin = new Padding(5, 6, 5, 6);
            dgv_karyawan.Name = "dgv_karyawan";
            dgv_karyawan.RowHeadersWidth = 62;
            dgv_karyawan.Size = new Size(1152, 288);
            dgv_karyawan.TabIndex = 3;
            dgv_karyawan.CellContentClick += dgv_karyawan_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 255);
            comboBox1.Margin = new Padding(5, 6, 5, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(391, 33);
            comboBox1.TabIndex = 4;
            // 
            // comboBoxJabatan
            // 
            comboBoxJabatan.Location = new Point(267, 323);
            comboBoxJabatan.Margin = new Padding(5, 6, 5, 6);
            comboBoxJabatan.Name = "comboBoxJabatan";
            comboBoxJabatan.Size = new Size(391, 33);
            comboBoxJabatan.TabIndex = 14;
            // 
            // pb_Logo
            // 
            pb_Logo.BackColor = Color.Azure;
            pb_Logo.Location = new Point(32, 23);
            pb_Logo.Margin = new Padding(5, 6, 5, 6);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(167, 113);
            pb_Logo.TabIndex = 5;
            pb_Logo.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 185);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // info_dep
            // 
            info_dep.AutoSize = true;
            info_dep.Location = new Point(933, 133);
            info_dep.Margin = new Padding(5, 0, 5, 0);
            info_dep.Name = "info_dep";
            info_dep.Size = new Size(140, 150);
            info_dep.TabIndex = 7;
            info_dep.Text = "ID Departemen\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Finance\r\n";
            // 
            // btn_Insert
            // 
            btn_Insert.BackColor = Color.FromArgb(192, 255, 192);
            btn_Insert.Location = new Point(73, 384);
            btn_Insert.Margin = new Padding(5, 6, 5, 6);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(193, 94);
            btn_Insert.TabIndex = 8;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = false;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.PowderBlue;
            btn_Edit.Location = new Point(326, 384);
            btn_Edit.Margin = new Padding(5, 6, 5, 6);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(182, 94);
            btn_Edit.TabIndex = 9;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_Delete.Location = new Point(579, 384);
            btn_Delete.Margin = new Padding(5, 6, 5, 6);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(197, 94);
            btn_Delete.TabIndex = 10;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.LightSkyBlue;
            btn_Load.Location = new Point(1035, 808);
            btn_Load.Margin = new Padding(5, 6, 5, 6);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(190, 52);
            btn_Load.TabIndex = 11;
            btn_Load.Text = "Load Data";
            btn_Load.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(825, 433);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 12;
            label1.Text = "ID Karyawan yang dipilih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 60);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 34);
            label2.TabIndex = 13;
            label2.Text = "LogoKu!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1333, 904);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Load);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Insert);
            Controls.Add(info_dep);
            Controls.Add(textBox1);
            Controls.Add(pb_Logo);
            Controls.Add(comboBoxJabatan);
            Controls.Add(comboBox1);
            Controls.Add(dgv_karyawan);
            Controls.Add(lbl_KaryawanTerpilih);
            Controls.Add(lbl_Jabatan);
            Controls.Add(lbl_Departemen);
            Controls.Add(lbl_NamaKaryawan);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_karyawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NamaKaryawan;
        private System.Windows.Forms.Label lbl_Departemen;
        private System.Windows.Forms.Label lbl_Jabatan;
        private System.Windows.Forms.Label lbl_KaryawanTerpilih;
        private System.Windows.Forms.DataGridView dgv_karyawan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxJabatan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label info_dep;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label label2;
    }
}

