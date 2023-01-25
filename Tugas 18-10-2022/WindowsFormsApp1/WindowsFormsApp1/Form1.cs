using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace koneksidb
{

    public partial class Form1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form1()
        {
            alamat = "server=localhost; database=db_perpustakaan; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdMahasiswa.Text != "" && TxtNamaMahasiswa.Text != "" && (RBPria.Checked == true || RBWanita.Checked == true))
                {
                    if (RBPria.Checked == true)
                    {
                        query = string.Format("insert into tbl_mahasiswa values ('{0}','{1}','{2}');", TxtIdMahasiswa.Text, TxtNamaMahasiswa.Text, RBPria.Text);
                    }
                    else
                    {
                        query = string.Format("insert into tbl_mahasiswa values ('{0}','{1}','{2}');", TxtIdMahasiswa.Text, TxtNamaMahasiswa.Text, RBWanita.Text);
                    }

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Form1_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdMahasiswa.Text != "")
                {
                    query = string.Format("select * from tbl_mahasiswa where id_mahasiswa = '{0}'", TxtIdMahasiswa.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            TxtNamaMahasiswa.Text = kolom["nama_mahasiswa"].ToString();
                            if (kolom["jenis_kelamin"].ToString() == "Pria")
                            {
                                RBPria.Checked = true;
                            }
                            else
                            {
                                RBWanita.Checked = true;
                            }
                        }
                        TxtIdMahasiswa.Enabled = false;
                        dataGridView1.DataSource = ds.Tables[0];
                        BtnSimpan.Enabled = false;
                        BtnUpdate.Enabled = true;
                        BtnDelete.Enabled = true;
                        BtnCari.Enabled = false;
                        BtnClear.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Form1_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Form1_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtIdMahasiswa_TextChanged(object sender, EventArgs e)
        {
            try
            {

                query = string.Format("select * from tbl_mahasiswa where id_mahasiswa = '{0}'", TxtIdMahasiswa.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();

                foreach (DataRow kolom in ds.Tables[0].Rows)
                {
                    TxtNamaMahasiswa.Text = kolom["nama_mahasiswa"].ToString();
                    if (kolom["jenis_kelamin"].ToString() == "Pria")
                    {
                        RBPria.Checked = true;
                    }
                    else
                    {
                        RBWanita.Checked = true;
                    }

                }
                BtnUpdate.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNamaMahasiswa.Text != "" && (RBPria.Checked == true || RBWanita.Checked == true))
                {
                    if (RBPria.Checked == true)
                    {
                        query = string.Format("update tbl_mahasiswa set nama_mahasiswa = '{0}',jenis_kelamin = '{1}' where id_mahasiswa = '{2}'", TxtNamaMahasiswa.Text, RBPria.Text, TxtIdMahasiswa.Text);
                    }
                    else
                    {
                        query = string.Format("update tbl_mahasiswa set nama_mahasiswa = '{0}',jenis_kelamin = '{1}' where id_mahasiswa = '{2}'", TxtNamaMahasiswa.Text, RBWanita.Text, TxtIdMahasiswa.Text);
                    }

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Suksess ...");
                        Form1_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_mahasiswa");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Mahasiswa";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Jenis Kelamin";
                TxtIdMahasiswa.Clear();
                TxtNamaMahasiswa.Clear();
                RBPria.Checked = false;
                RBWanita.Checked = false;
                TxtIdMahasiswa.Enabled = true;
                TxtIdMahasiswa.Focus();
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
                BtnClear.Enabled = false;
                BtnSimpan.Enabled = true;
                BtnCari.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}