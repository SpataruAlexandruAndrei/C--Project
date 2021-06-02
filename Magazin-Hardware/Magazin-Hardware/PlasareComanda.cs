using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_Hardware
{
    public partial class PlasareComanda : Form
    {
        private static int idUser;
        private static double sum;
        private static List<Componente> lista = new List<Componente>();

        public PlasareComanda(int id, double sum, List<Componente> lista)
        {
            InitializeComponent();
            PlasareComanda.idUser = id;
            PlasareComanda.sum = sum;
            PlasareComanda.lista = lista;
        }

        public PlasareComanda()
        {
            InitializeComponent();
        }

        private void btn_finC_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (tb_jud.Text == "")
            {
                isValid = false;
                errorProvider1.SetError(tb_jud, "Introduceti judetul!");
            }
            else if (tb_loc.Text == "")
            {
                isValid = false;
                errorProvider1.SetError(tb_loc, "Introduceti localitatea!");
            }
            else if (tb_adresa.Text == "")
            {
                isValid = false;
                errorProvider1.SetError(tb_adresa, "Introduceti adresa!");
            }
            else if (cb_card.Checked == false && cb_ramburs.Checked == false)
            {
                isValid = false;
                errorProvider1.SetError(lb_mod, "Selectati modalitatea de plata!");
            }

            if (isValid && cb_card.Checked == true)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    OleDbCommand comanda1 = new OleDbCommand();
                    comanda1.Connection = conexiune;
                    string nume, prenume, email, telefon, adresa;
                    DateTime date = DateTime.Now;
                    DateTime date1 = date.AddDays(3);
                    comanda.CommandText = "SELECT Nume FROM [User] WHERE ID = " + idUser;
                    nume = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Prenume FROM [User] WHERE ID = " + idUser;
                    prenume = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Email FROM [User] WHERE ID = " + idUser;
                    email = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Numar_Telefon FROM [User] WHERE ID = " + idUser;
                    telefon = Convert.ToString(comanda.ExecuteScalar());
                    adresa = "Judetul: " + tb_jud.Text + ", Localitatea: " + tb_loc.Text + ", Adresa: " + tb_adresa.Text;
                    comanda.CommandText = "SELECT MAX(ID_Comanda) FROM [Comenzi]";
                    int idComanda = Convert.ToInt32(comanda.ExecuteScalar());
                    comanda.CommandText = "INSERT INTO [Comenzi] VALUES(?,?,?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("ID_Comanda", OleDbType.Integer).Value = idComanda + 1;
                    comanda.Parameters.Add("Nume_Client", OleDbType.Char, 255).Value = nume;
                    comanda.Parameters.Add("Prenume_Client", OleDbType.Char, 255).Value = prenume;
                    comanda.Parameters.Add("Email", OleDbType.Char, 255).Value = email;
                    comanda.Parameters.Add("Telefon", OleDbType.Char, 255).Value = telefon;
                    comanda.Parameters.Add("Adresa", OleDbType.Char, 255).Value = adresa;
                    comanda.Parameters.Add("Data_Livrare", OleDbType.Date).Value = date1;
                    comanda.Parameters.Add("Modalitate_Plata", OleDbType.Char, 255).Value = cb_card.Text;
                    comanda.Parameters.Add("Pret_Comanda", OleDbType.Double).Value = sum;
                    comanda.Parameters.Add("Comanda_Finalizata", OleDbType.Boolean).Value = false;
                    comanda.ExecuteNonQuery();


                    comanda1.CommandText = "SELECT MAX(ID) FROM [Istoric_Produse_Comandate]";
                    int idIstoric = Convert.ToInt32(comanda1.ExecuteScalar());
                    foreach (Componente c in lista)
                    {
                        OleDbCommand comanda2 = new OleDbCommand();
                        comanda2.Connection = conexiune;
                        comanda2.CommandText = "INSERT INTO [Istoric_Produse_Comandate] VALUES(?,?,?,?,?,?,?)";
                        comanda2.Parameters.Add("ID", OleDbType.Integer).Value = idIstoric + 1;
                        comanda2.Parameters.Add("ID_Produs", OleDbType.Integer).Value = c.Id;
                        comanda2.Parameters.Add("ID_Comanda", OleDbType.Integer).Value = idComanda + 1;
                        comanda2.Parameters.Add("Denumire_Produs", OleDbType.Char, 255).Value = c.Denumire;
                        comanda2.Parameters.Add("Detalii_Produs", OleDbType.Char, 255).Value = c.Detalii;
                        comanda2.Parameters.Add("Pret_Produs", OleDbType.Double).Value = c.Pret;
                        comanda2.Parameters.Add("Cantitate_Comandata", OleDbType.Integer).Value = c.Cantitate;
                        comanda2.CommandText = "Update [Componente] SET CANTITATE = CANTITATE - " + c.Cantitate + " WHERE ID = " + c.Id;
                        comanda2.ExecuteScalar();
                        comanda2.ExecuteNonQuery();
                        idIstoric++;
                    }
                    comanda1.ExecuteNonQuery();

                    comanda1.CommandText = "DELETE FROM [Cos] WHERE ID_Client = " + idUser;
                    comanda1.ExecuteNonQuery();

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
                    tb_jud.Clear();
                    tb_loc.Clear();
                    tb_adresa.Clear();
                    cb_card.Checked = false;
                    cb_ramburs.Checked = false;
                    MessageBox.Show("Comanda plasata cu succes!");
                    this.Dispose();
                }

            }
            else if(isValid && cb_ramburs.Checked == true)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    OleDbCommand comanda1 = new OleDbCommand();
                    comanda1.Connection = conexiune;
                    string nume, prenume, email, telefon, adresa;
                    DateTime date = DateTime.Now;
                    DateTime date1 = date.AddDays(3);
                    comanda.CommandText = "SELECT Nume FROM [User] WHERE ID = " + idUser;
                    nume = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Prenume FROM [User] WHERE ID = " + idUser;
                    prenume = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Email FROM [User] WHERE ID = " + idUser;
                    email = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Numar_Telefon FROM [User] WHERE ID = " + idUser;
                    telefon = Convert.ToString(comanda.ExecuteScalar());
                    adresa = "Judetul: " + tb_jud.Text + ", Localitatea: " + tb_loc.Text + ", Adresa: " + tb_adresa.Text;
                    comanda.CommandText = "SELECT MAX(ID_Comanda) FROM [Comenzi]";
                    int idComanda = Convert.ToInt32(comanda.ExecuteScalar());
                    comanda.CommandText = "INSERT INTO [Comenzi] VALUES(?,?,?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("ID_Comanda", OleDbType.Integer).Value = idComanda + 1;
                    comanda.Parameters.Add("Nume_Client", OleDbType.Char, 255).Value = nume;
                    comanda.Parameters.Add("Prenume_Client", OleDbType.Char, 255).Value = prenume;
                    comanda.Parameters.Add("Email", OleDbType.Char, 255).Value = email;
                    comanda.Parameters.Add("Telefon", OleDbType.Char, 255).Value = telefon;
                    comanda.Parameters.Add("Adresa", OleDbType.Char, 255).Value = adresa;
                    comanda.Parameters.Add("Data_Livrare", OleDbType.Date).Value = date1;
                    comanda.Parameters.Add("Modalitate_Plata", OleDbType.Char, 255).Value = cb_ramburs.Text;
                    comanda.Parameters.Add("Pret_Comanda", OleDbType.Double).Value = sum;
                    comanda.Parameters.Add("Comanda_Finalizata", OleDbType.Boolean).Value = false;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("da");

                    comanda1.CommandText = "SELECT MAX(ID) FROM [Istoric_Produse_Comandate]";
                    int idIstoric = Convert.ToInt32(comanda1.ExecuteScalar());
                    foreach (Componente c in lista)
                    {
                        OleDbCommand comanda2 = new OleDbCommand();
                        comanda2.Connection = conexiune;
                        comanda2.CommandText = "INSERT INTO [Istoric_Produse_Comandate] VALUES(?,?,?,?,?,?,?)";
                        comanda2.Parameters.Add("ID", OleDbType.Integer).Value = idIstoric + 1;
                        comanda2.Parameters.Add("ID_Produs", OleDbType.Integer).Value = c.Id;
                        comanda2.Parameters.Add("ID_Comanda", OleDbType.Integer).Value = idComanda + 1;
                        comanda2.Parameters.Add("Denumire_Produs", OleDbType.Char, 255).Value = c.Denumire;
                        comanda2.Parameters.Add("Detalii_Produs", OleDbType.Char, 255).Value = c.Detalii;
                        comanda2.Parameters.Add("Pret_Produs", OleDbType.Double).Value = c.Pret;
                        comanda2.Parameters.Add("Cantitate_Comandata", OleDbType.Integer).Value = c.Cantitate;
                        comanda2.CommandText = "Update [Componente] SET CANTITATE = CANTITATE - " + c.Cantitate + " WHERE ID = " + c.Id;
                        comanda2.ExecuteScalar();
                        comanda2.ExecuteNonQuery();
                        idIstoric++;
                    }
                    //comanda1.ExecuteNonQuery();
                    MessageBox.Show("da");

                    comanda1.CommandText = "DELETE FROM [Cos] WHERE ID_Client = " + idUser;
                    comanda1.ExecuteNonQuery();
                    MessageBox.Show("da");
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
                    tb_jud.Clear();
                    tb_loc.Clear();
                    tb_adresa.Clear();
                    cb_card.Checked = false;
                    cb_ramburs.Checked = false;
                    MessageBox.Show("Comanda plasata cu succes!");
                    this.Dispose();

                }
            }
        }


        private void btn_anulare_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
