using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Magazin_Hardware
{
    public partial class Form1 : Form
    {
        User newU = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Spataru" && tbPassword.Text == "spataru")
            {
                MessageBox.Show("Welcome, " + tbUsername.Text + "!");
                this.Hide();
                AdminDashbord aDash = new AdminDashbord();
                aDash.ShowDialog();
            }
            else
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT Parola FROM [User] where Username ='" + tbUsername.Text + "'";
                    string password = Convert.ToString(comanda.ExecuteScalar());
                    if (password == tbPassword.Text && tbUsername.Text != "" && tbPassword.Text != "")
                    {
                        comanda.CommandText = "SELECT ID FROM [User] WHERE Username ='" + tbUsername.Text + "'";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());
                        MessageBox.Show("Welcome, " + tbUsername.Text + "!");
                        this.Hide();
                        UserDashbord uDash = new UserDashbord(id);
                        uDash.ShowDialog();
                    }
                    else if ((tbUsername.Text == "" && tbPassword.Text == ""))
                    {
                        MessageBox.Show("Input your username and password!");
                    }
                    else { MessageBox.Show("Invalid user or password! Try Again!"); }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                var log = new Register();
                string username = log.getUsername();
                string path = Directory.GetCurrentDirectory() + @"\LoginInfo.txt";
                try
                {
                    string[] compUser = File.ReadAllLines(path);
                    if (compUser[0] == tbUsername.Text && compUser[1] == tbPassword.Text && tbUsername.Text != "" && tbPassword.Text != "")
                    {
                        MessageBox.Show("Welcome, " + tbUsername.Text + "!");
                        //Closing first form
                        this.Hide();
                        //////////
                        ///
                        UserDashbord uDash = new UserDashbord();
                        uDash.Show();
                    }
                    else if ((tbUsername.Text == "" && tbPassword.Text == ""))
                    {
                        MessageBox.Show("Input your username and password!");
                    }
                    else { MessageBox.Show("Invalid user or password! Try Again!"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No users registered! Register first!");
                }
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
