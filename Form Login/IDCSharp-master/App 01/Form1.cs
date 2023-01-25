using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_APP
{
    public partial class Warna : Form
    {
        public Warna()
        {
            InitializeComponent();
            itemList.Items.Add("Pesanan " + " " + " Harga ");
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Item.Items.Add("Makaroni Pedas");
            Item.Items.Add("Es Cincau");
            Item.Items.Add("Mie Goreng");
            Item.Items.Add("Mie Rebus");
            Item.Items.Add("Telur");

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item.Text == "Makaroni Pedas")
            {
                Harga.Text = "2000";
            }
            else if (Item.Text == "Es Cincau")
            {
                Harga.Text = "3000";
            }
            else if (Item.Text == "Mie Goreng")
            {
                Harga.Text = "6000";
            }
            else if (Item.Text == "Mie Rebus")
            {
                Harga.Text = "5000";
            }
            else if (Item.Text == "Telur")
            {
                Harga.Text = "1500";
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kamu Yakin ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
{
                MessageBox.Show("Sampai Jumpa");
                this.Close();
            }
            else
            {
   
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Item_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnBeli_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Harga.Text))
            {
                MessageBox.Show("Pilih Item Terlebih dahulu");
            }
            else
                
            itemList.Items.Add(Item.Text + " " + Harga.Text);
            Harga.Clear();
           
        }

         

    private void Harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            itemList.Items.Clear();
            itemList.Items.Add("Pesanan" + " " + " Harga ");
        }
    }
}
