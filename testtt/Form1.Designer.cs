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
            this.lbl_NamaKaryawan = new System.Windows.Forms.Label();
            this.lbl_Departemen = new System.Windows.Forms.Label();
            this.lbl_KaryawanTerpilih = new System.Windows.Forms.Label();
            this.dgv_karyawan = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.info_dep = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NamaKaryawan
            // 
            this.lbl_NamaKaryawan.AutoSize = true;
            this.lbl_NamaKaryawan.Location = new System.Drawing.Point(41, 96);
            this.lbl_NamaKaryawan.Name = "lbl_NamaKaryawan";
            this.lbl_NamaKaryawan.Size = new System.Drawing.Size(97, 13);
            this.lbl_NamaKaryawan.TabIndex = 0;
            this.lbl_NamaKaryawan.Text = "Nama Karyawan   :";
            // 
            // lbl_Departemen
            // 
            this.lbl_Departemen.AutoSize = true;
            this.lbl_Departemen.Location = new System.Drawing.Point(41, 134);
            this.lbl_Departemen.Name = "lbl_Departemen";
            this.lbl_Departemen.Size = new System.Drawing.Size(95, 13);
            this.lbl_Departemen.TabIndex = 1;
            this.lbl_Departemen.Text = "Dep. Karyawan    :";
            // 
            // lbl_KaryawanTerpilih
            // 
            this.lbl_KaryawanTerpilih.AutoSize = true;
            this.lbl_KaryawanTerpilih.Location = new System.Drawing.Point(627, 225);
            this.lbl_KaryawanTerpilih.Name = "lbl_KaryawanTerpilih";
            this.lbl_KaryawanTerpilih.Size = new System.Drawing.Size(20, 13);
            this.lbl_KaryawanTerpilih.TabIndex = 2;
            this.lbl_KaryawanTerpilih.Text = "\" \"";
            // 
            // dgv_karyawan
            // 
            this.dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_karyawan.Location = new System.Drawing.Point(44, 255);
            this.dgv_karyawan.Name = "dgv_karyawan";
            this.dgv_karyawan.Size = new System.Drawing.Size(691, 150);
            this.dgv_karyawan.TabIndex = 3;
            this.dgv_karyawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_karyawan_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Azure;
            this.pb_Logo.Location = new System.Drawing.Point(19, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(100, 59);
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // info_dep
            // 
            this.info_dep.AutoSize = true;
            this.info_dep.Location = new System.Drawing.Point(560, 69);
            this.info_dep.Name = "info_dep";
            this.info_dep.Size = new System.Drawing.Size(87, 78);
            this.info_dep.TabIndex = 7;
            this.info_dep.Text = "ID Departemen\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Fi" +
    "nance\r\n";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Insert.Location = new System.Drawing.Point(44, 170);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(116, 49);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Edit.Location = new System.Drawing.Point(199, 170);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(109, 49);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Delete.Location = new System.Drawing.Point(344, 170);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(118, 49);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Load.Location = new System.Drawing.Point(621, 420);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(114, 27);
            this.btn_Load.TabIndex = 11;
            this.btn_Load.Text = "Load Data";
            this.btn_Load.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Karyawan yang dipilih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "LogoKu!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.info_dep);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv_karyawan);
            this.Controls.Add(this.lbl_KaryawanTerpilih);
            this.Controls.Add(this.lbl_Departemen);
            this.Controls.Add(this.lbl_NamaKaryawan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NamaKaryawan;
        private System.Windows.Forms.Label lbl_Departemen;
        private System.Windows.Forms.Label lbl_KaryawanTerpilih;
        private System.Windows.Forms.DataGridView dgv_karyawan;
        private System.Windows.Forms.ComboBox comboBox1;
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

