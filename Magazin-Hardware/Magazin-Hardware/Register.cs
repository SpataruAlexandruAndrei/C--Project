using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.IO;

namespace Magazin_Hardware
{
    public partial class Register : Form
    {
        List<User> UserList1 = new List<User>();
        public static User u = new User();
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void btn_inregistrare_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            string username = tbUsername.Text;
            string nrTel = tbTelefon.Text;
            string email = tbEmail.Text;
            string pass = tbPassword.Text;
            string confPass = tbConfirmPassword.Text;
            if(tbNume.Text == "" || tbPrenume.Text == "" || tbUsername.Text == "" || tbTelefon.Text == "" || tbEmail.Text == "" || tbPassword.Text == "" || tbConfirmPassword.Text == "")
            {
                MessageBox.Show("One or more fields are empty!");
            }
            else

            {
                UserList1.Add(new User(nume, prenume, username, nrTel, email, pass, confPass));
                foreach(var user in UserList1)
                {
                    MessageBox.Show(user.ToString() + "\n");
                }
            }
            try
            {
                u.Nume = nume;
                u.Prenume = prenume;
                u.Username = username;
                u.NrTel = nrTel;
                u.Email = email;
                u.Pass = pass;
                u.ConfPass = confPass;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            TextWriter userWrite = new StreamWriter("LoginInfo.txt");
            foreach (User s in UserList1)
            {
                userWrite.WriteLine(s.Nume);
                userWrite.WriteLine(s.ConfPass);
            }
            userWrite.Close();
            TextWriter tw = new StreamWriter("UserList.txt");
            foreach (var u in UserList1)
            {
                tw.WriteLine(u);
            }
            tw.Close();
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(ID) FROM [User]";
                int id = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO [User] VALUES(?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("Nume", OleDbType.Char, 50).Value = tbNume.Text;
                comanda.Parameters.Add("Prenume", OleDbType.Char, 50).Value = tbPrenume.Text;
                comanda.Parameters.Add("Email", OleDbType.Char, 50).Value = tbEmail.Text;
                comanda.Parameters.Add("Numar Telefon", OleDbType.Integer).Value = Convert.ToInt32(tbTelefon.Text);
                comanda.Parameters.Add("Parola", OleDbType.Char, 50).Value = tbPassword.Text;
                comanda.Parameters.Add("Username", OleDbType.Char, 50).Value = tbUsername.Text;
                comanda.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbEmail.Clear();
                tbConfirmPassword.Clear();
                tbPassword.Clear();
                tbPrenume.Clear();
                tbTelefon.Clear();
                tbUsername.Clear();
            }


            MessageBox.Show("Te-ai inregistrat cu succses!");
            //Closing first form
            this.Hide();
            //////////
            UserDashbord uDash = new UserDashbord();
            uDash.Show();
        }

        public string getUsername()
        {
            return tbUsername.Text;
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                error.SetError(tbNume, "Firstname input is empty!");
                tbNume.Focus();
            }
            else if (!Regex.IsMatch(tbNume.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                error.SetError(tbNume, "Name starts with a capital letter and no numbers!");
                tbNume.Focus();
            }
            else
            {
                error.SetError(tbNume, "");
            }
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text == "")
            {
                error.SetError(tbPrenume, "Lastname input is empty!");
                tbPrenume.Focus();
            }
            else if (!Regex.IsMatch(tbPrenume.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                error.SetError(tbPrenume, "Name starts with a capital letter and no numbers!");
                tbPrenume.Focus();
            }
            else
            {
                error.SetError(tbPrenume, "");
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text == "")
            {
                error.SetError(tbTelefon, "Phone input is empty!");
                tbTelefon.Focus();
            }
            else if (!Regex.IsMatch(tbTelefon.Text, @"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$"))
            {
                error.SetError(tbTelefon, "Phone must respect the valid format!");
                tbTelefon.Focus();
            }
            else
            {
                error.SetError(tbTelefon, "");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                error.SetError(tbEmail, "Email input is empty!");
                tbEmail.Focus();
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"[a-zA-Z0-9_\.-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9\.]{2,5}$"))
            {
                error.SetError(tbEmail, "Email must respect the valid format!");
                tbEmail.Focus();
            }
            else
            {
                error.SetError(tbEmail, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text == "")
            {
                error.SetError(tbPassword, "You must input your password!");
                tbPassword.Focus();
            }
            else
            {
                error.SetError(tbPassword, "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                error.SetError(tbConfirmPassword, "Passwords not matching!");
                tbConfirmPassword.Focus();
            }
            else if (tbConfirmPassword.Text == "")
            {
                error.SetError(tbConfirmPassword, "You must confirm the password!");
            }
            else
            {
                error.SetError(tbConfirmPassword, "");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            tbConfirmPassword.UseSystemPasswordChar = true;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
