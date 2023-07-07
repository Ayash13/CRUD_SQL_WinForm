using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=KTP;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
            string query = "INSERT INTO Penduduk values(@idPen, @Nama_Lengkap, @Tempat_Lahir, @Tanggal_Lahir, @Jenis_Kelamin, @Alamat, @No_Telp)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPen", txbx_idPenduduk.Text);
                    cmd.Parameters.AddWithValue("@Nama_Lengkap", txbx_nama.Text);
                    cmd.Parameters.AddWithValue("@Tempat_Lahir", txbx_tempatLahir.Text);
                    cmd.Parameters.AddWithValue("@Tanggal_Lahir", DateTime.Parse(txbx_tglLahir.Text));
                    cmd.Parameters.AddWithValue("@Jenis_Kelamin", txbx_sex.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txbx_alamat.Text);
                    cmd.Parameters.AddWithValue("@No_Telp", txbx_nomorTelp.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully added.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }


        private void txbx_nim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=KTP;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
            string query = "UPDATE Penduduk SET Nama_Lengkap = @Nama_Lengkap, Tempat_Lahir = @Tempat_Lahir, Tanggal_Lahir = @Tanggal_Lahir, " +
                           "Jenis_Kelamin = @Jenis_Kelamin, Alamat = @Alamat, No_Telp = @No_Telp WHERE ID_Penduduk = @idPen";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nama_Lengkap", txbx_nama.Text);
                    cmd.Parameters.AddWithValue("@Tempat_Lahir", txbx_tempatLahir.Text);
                    cmd.Parameters.AddWithValue("@Tanggal_Lahir", DateTime.Parse(txbx_tglLahir.Text));
                    cmd.Parameters.AddWithValue("@Jenis_Kelamin", txbx_sex.Text);
                    cmd.Parameters.AddWithValue("@Alamat", txbx_alamat.Text);
                    cmd.Parameters.AddWithValue("@No_Telp", txbx_nomorTelp.Text);
                    cmd.Parameters.AddWithValue("@idPen", txbx_idPenduduk.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully updated.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=KTP;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
            string query = "DELETE FROM Penduduk WHERE ID_Penduduk = @idPen";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPen", txbx_search.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kTPDataSet.Penduduk' table. You can move, or remove it, as needed.
            this.pendudukTableAdapter.Fill(this.kTPDataSet.Penduduk);

        }

        private void read_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=KTP;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
            string query = "SELECT * FROM Penduduk";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=KTP;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
            string query = "SELECT * FROM Penduduk WHERE ID_Penduduk = @idPen";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPen", txbx_search.Text);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

    }
}
