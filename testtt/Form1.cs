using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace testtt
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=elisabeth17;Database=testtt";
        private string sql = "";
        private NpgsqlCommand cmd;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        // Polymorphism: overload method untuk koneksi
        private void EstablishConn(string connstring)
        {
            try
            {
                this.connString = connstring;
                conn = new NpgsqlConnection(connString);
                conn.Open();
                MessageBox.Show("Connection to PostgreSQL is successful!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to PostgreSQL! Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstablishConn()
        {
            MessageBox.Show("Connection to PostgreSQL is success", "Initializing Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EstablishConn();
            EstablishConn(connString);
            LoadDepartemen();
            LoadJabatan();
            LoadData();
        }

        // Load Departemen ke ComboBox
        private void LoadDepartemen()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = "SELECT id_dep, nama_dep FROM departemen";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        comboBox1.DisplayMember = "nama_dep";
                        comboBox1.ValueMember = "id_dep";
                        comboBox1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Jabatan ke ComboBox
        private void LoadJabatan()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = "SELECT id_jabatan, nama_jabatan FROM jabatan";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        comboBoxJabatan.DisplayMember = "nama_jabatan";
                        comboBoxJabatan.ValueMember = "id_jabatan";
                        comboBoxJabatan.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load data karyawan ke DataGridView
        private void LoadData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = "SELECT * FROM kr_select()";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_karyawan.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // INSERT karyawan
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || comboBox1.SelectedValue == null || comboBoxJabatan.SelectedValue == null)
            {
                MessageBox.Show("Isi semua field sebelum insert!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = "SELECT kr_insert(@nama, @id_dep, @id_jabatan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                        cmd.Parameters.AddWithValue("@id_dep", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@id_jabatan", comboBoxJabatan.SelectedValue);

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            textBox1.Clear();
                            comboBox1.SelectedIndex = -1;
                            comboBoxJabatan.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EDIT karyawan
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lbl_KaryawanTerpilih.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text) || comboBox1.SelectedValue == null || comboBoxJabatan.SelectedValue == null)
            {
                MessageBox.Show("Isi semua field sebelum update!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = "SELECT kr_update(@id_karyawan, @nama, @id_dep, @id_jabatan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_karyawan", lbl_KaryawanTerpilih.Text);
                        cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                        cmd.Parameters.AddWithValue("@id_dep", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@id_jabatan", comboBoxJabatan.SelectedValue); 
      

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data berhasil diubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE karyawan
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lbl_KaryawanTerpilih.Text == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        sql = "SELECT kr_delete(@id_karyawan)";
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_karyawan", lbl_KaryawanTerpilih.Text);

                            if ((int)cmd.ExecuteScalar() == 1)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                                lbl_KaryawanTerpilih.Text = "";
                                textBox1.Clear();
                                comboBox1.SelectedIndex = -1;
                                comboBoxJabatan.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("Data gagal dihapus!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Untuk ComboBox Departemen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bisa diisi logic ketika Departemen diganti
            // Jika belum ada logic, biarkan kosong agar tidak error
        }

        // Untuk TextBox Nama Karyawan
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Bisa diisi logic ketika teks berubah
            // Jika belum ada logic, biarkan kosong agar tidak error
        }


        // Ketika klik DataGridView, isi TextBox dan ComboBox
        private void dgv_karyawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_karyawan.Rows[e.RowIndex];
                lbl_KaryawanTerpilih.Text = row.Cells["_id_karyawan"].Value.ToString();
                textBox1.Text = row.Cells["_nama"].Value.ToString();
                comboBox1.SelectedValue = row.Cells["_id_dep"].Value;
                comboBoxJabatan.SelectedValue = row.Cells["_id_jabatan"].Value;
            }
        }
    }
}
