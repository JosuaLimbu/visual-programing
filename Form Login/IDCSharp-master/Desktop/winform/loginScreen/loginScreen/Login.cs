using System;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class Login : Form
    {
        readonly string Username = "idcsharp";
        readonly string Password = "12345";
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == Username && TxtPassword.Text == Password)
            {
                MessageBox.Show("Kamu berhasil login");
            }
            else if (TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
        }

        
    }
}
