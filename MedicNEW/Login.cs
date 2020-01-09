using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicNEW
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Mistake
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Mistake
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] users = File.ReadAllLines("login.txt");
            foreach (var line in users)
            {
                string[] userData = line.Split(';');
                if (userData[0].Equals(txtboxUser.Text) && userData[1].Equals(txtboxPass.Text))
                {
                    this.Hide();
                    MessageBox.Show("Bine ai venit "+txtboxUser.Text);
                    Dashboard f = new Dashboard();
                    f.Show();

                }
                else if (!(userData[0].Equals(txtboxUser.Text) && userData[1].Equals(txtboxPass.Text)) && txtboxUser.TextLength != 0 && txtboxPass.TextLength !=0)
                {
                    MessageBox.Show("Nume sau parola gresita");
                    
                }
                if(txtboxUser.Text == "" && txtboxPass.Text == "")
                {
                    MessageBox.Show("Nu lasa spatii goale");
                }
                else if(txtboxUser.TextLength > 0 && txtboxPass.Text == "")
                {
                    MessageBox.Show("Introduceti parola");
                }else if (txtboxUser.Text == "" && txtboxPass.TextLength > 0)
                {
                    MessageBox.Show("Introduceti numele de utilizator");
                }
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
