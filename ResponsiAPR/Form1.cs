using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace ResponsiAPR
{
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;" +
            "Password=admin123;Database=responsiDinda";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow row;

        public DataGridViewRow Row { get => row; set => row = value; }

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                sql = "select * from karyawan," +
                    " departemen WHERE karyawan.id_dep = departemen.id_dep;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvKaryawan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void InsertData()
        {
            string nama = tbNama.Text;
            int id_dep = 0;

            // Menentukan id_dep berdasarkan departemen yang dipilih
            if (rbHR.Checked)
            {
                id_dep = 1;
            }
            else if (rbENG.Checked)
            {
                id_dep = 2;
            }
            else if (rbDEV.Checked)
            {
                id_dep = 3;
            }
            else if (rbPM.Checked)
            {
                id_dep = 4;
            }
            else if (rbFIN.Checked)
            {
                id_dep = 5;
            }

            // Jika tidak ada departemen yang dipilih
            if (id_dep == 0)
            {
                MessageBox.Show("Pilih departemen");
                return;
            }

            // Pengecekan apakah id_dep ada di tabel departemen
            bool isDeptExists = false;
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT COUNT(*) FROM departemen WHERE id_dep = @id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_dep", id_dep);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Departemen dengan ID tersebut tidak ditemukan. " +
                        "Silakan tambahkan departemen terlebih dahulu.");
                    return;
                }
                else
                {
                    isDeptExists = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            finally
            {
                conn.Close();
            }

            
            if (isDeptExists)
            {
                try
                {
                    conn = new NpgsqlConnection(connString);
                    conn.Open();
                    sql = "SELECT * FROM add_karyawan(@in_id_karyawan, @in_nama, @in_id_dep)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@in_id_karyawan", nama + id_dep.ToString());
                    cmd.Parameters.AddWithValue("@in_nama", nama);
                    cmd.Parameters.AddWithValue("@in_id_dep", id_dep);

                    
                    int statusCode = (int)cmd.ExecuteScalar();
                    if (statusCode == 201)
                    {
                        MessageBox.Show("[201] Created");
                        LoadData(); 
                        return;
                    }
                    if (statusCode == 409)
                    {
                        throw new Exception("[409] User already exists");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        private void EditData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk diedit", "Info", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nama = tbNama.Text;
            int id_dep = 0;

           
            if (rbHR.Checked)
            {
                id_dep = 1;
            }
            else if (rbENG.Checked)
            {
                id_dep = 2;
            }
            else if (rbDEV.Checked)
            {
                id_dep = 3;
            }
            else if (rbPM.Checked)
            {
                id_dep = 4;
            }
            else if (rbFIN.Checked)
            {
                id_dep = 5;
            }

            if (id_dep == 0)
            {
                MessageBox.Show("Pilih departemen untuk karyawan", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id_karyawan = Row.Cells["id_karyawan"].Value.ToString(); 

            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();

                // Query SQL untuk mengupdate data karyawan
                sql = "UPDATE karyawan SET nama = @in_nama, id_dep = @in_id_dep " +
                    "WHERE id_karyawan = @in_id_karyawan";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_id_dep", id_dep);
                cmd.Parameters.AddWithValue("@in_id_karyawan", id_karyawan);

                int affectedRows = cmd.ExecuteNonQuery();  

                if (affectedRows > 0)
                {
                    MessageBox.Show("[200] Edit Success", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("[404] Karyawan tidak ditemukan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void DeleteData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk dihapus", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string id_karyawan = Row.Cells["id_karyawan"].Value.ToString();
            MessageBox.Show("ID Karyawan yang dipilih: " + id_karyawan);

            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin " +
                "menghapus karyawan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return; // Batalkan jika tidak jadi menghapus
            }

            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();

                sql = "DELETE FROM karyawan WHERE id_karyawan = @in_id_karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", id_karyawan);
                MessageBox.Show("Query SQL yang dijalankan: " + cmd.CommandText);
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("[204] Hapus berhasil", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Reload data setelah berhasil dihapus
                }
                else
                {
                    MessageBox.Show("[404] Karyawan tidak ditemukan", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) //Departemen
        {

        }

        private void lblNamaKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void rbPM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Row = dgvKaryawan.Rows[e.RowIndex];
                LbSelected.Text = Row.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = Row.Cells["nama"].Value.ToString();
                int id_dep = (int)Row.Cells["id_dep"].Value;

                if (id_dep == 1) rbHR.Checked = true;
                else if (id_dep == 2) rbENG.Checked = true;
                else if (id_dep == 3) rbDEV.Checked = true;
                else if (id_dep == 4) rbPM.Checked = true;
                else if (id_dep == 5) rbFIN.Checked = true;
                else
                {
                    throw new Exception("An error occured");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}
