using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testtt
{
    public partial class Form1 : Form //Ini Inheritance
    {
        private NpgsqlConnection conn;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=230405;Database=JunproBarbara";
        private string sql = "";
        private NpgsqlCommand cmd;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void EstablishConn(string connstring) //Polymorphism
        {
            try
            {
                this.connString = connstring;
                conn = new NpgsqlConnection(connString);

                // Test connection
                conn.Open();
                MessageBox.Show("Connection to PostgreSQL is successful!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to PostgreSQL! Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstablishConn() //Polymorphism
        {
            MessageBox.Show("Connection to PostgreSQL is success", "Initializing Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EstablishConn();
            EstablishConn(connString);
            LoadDepartemen();
            LoadData();
        }

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


        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT kr_insert(@nama, @id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                cmd.Parameters.AddWithValue("@id_dep", comboBox1.SelectedValue.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lbl_KaryawanTerpilih.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT kr_update(@id_karyawan, @nama, @id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_karyawan", lbl_KaryawanTerpilih.Text);
                cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                cmd.Parameters.AddWithValue("@id_dep", comboBox1.SelectedValue.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvg_karyawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbl_KaryawanTerpilih.Text = dgv_karyawan.Rows[e.RowIndex].Cells["_id_karyawan"].Value.ToString();
                textBox1.Text = dgv_karyawan.Rows[e.RowIndex].Cells["_nama"].Value.ToString();
                comboBox1.SelectedValue = dgv_karyawan.Rows[e.RowIndex].Cells["_id_dep"].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

                            var result = (int)cmd.ExecuteScalar();
                            if (result == 1)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadData();
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

        private void dgv_karyawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
