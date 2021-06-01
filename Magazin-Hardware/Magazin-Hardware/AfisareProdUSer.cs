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
    public partial class AfisareProdUSer : Form
    {
        private static int idUser;
        public AfisareProdUSer(int id)
        {
            InitializeComponent();
            AfisareProdUSer.idUser = id;
            displayList();
        }

        public AfisareProdUSer()
        {
            InitializeComponent();
            displayList();
        }

        private void displayList()
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Bd_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM [Componente] ";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Denumire"].ToString());
                    itm.SubItems.Add(reader["Detalii"].ToString());
                    itm.SubItems.Add(reader["Pret"].ToString());
                    itm.SubItems.Add(reader["Cantitate"].ToString());
                    lv_prod.Items.Add(itm);
                }
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

        private void btn_add_cart_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in lv_prod.Items)
                {
                    int ID = Convert.ToInt32(itm.SubItems[0].Text);
                    comanda.CommandText = "SELECT ID_Produs FROM [Cos] WHERE ID_Produs = " + ID;
                    int id = Convert.ToInt32(comanda.ExecuteScalar());
                    if (itm.Selected && Convert.ToInt32(itm.SubItems[0].Text) == id)
                    {
                        comanda.CommandText = "UPDATE [Cos] SET CANTITATE = CANTITATE +" + 1 + " WHERE ID_Produs = " + id;
                        comanda.ExecuteScalar();
                        MessageBox.Show("Ai adaugat inca un produs de tipul:" + itm.SubItems[1].Text + "!");
                    }
                    else if(itm.Selected)
                    {
                        int Id = 0, Cantitate =1 ;
                        string denumire = "";
                        string detalii = "";
                        double Pret = 0;
                        comanda.CommandText = "SELECT ID FROM [Componente] WHERE ID=" + Convert.ToInt32(itm.SubItems[0].Text);
                        Id = Convert.ToInt32(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT DENUMIRE FROM [Componente] WHERE ID=" + Id;
                        denumire = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT DETALII FROM [Componente] WHERE ID=" + Id;
                        detalii = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT PRET FROM [Componente] WHERE ID=" + Id;
                        Pret = Convert.ToDouble(comanda.ExecuteScalar());
                        comanda.CommandText = "INSERT INTO [Cos] VALUES(?,?,?,?,?,?)";
                        comanda.Parameters.Add("ID_PRODUS", OleDbType.Integer).Value = Id;
                        comanda.Parameters.Add("ID_CLIENT", OleDbType.Integer).Value = idUser;
                        comanda.Parameters.Add("DETALII_PRODUS", OleDbType.Char, 255).Value = detalii;
                        comanda.Parameters.Add("DENUMIRE", OleDbType.Char, 255).Value = denumire;
                        comanda.Parameters.Add("PRET", OleDbType.Double).Value = Pret;
                        comanda.Parameters.Add("CANTITATE", OleDbType.Integer).Value = Cantitate; 
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Produs adaugat in cos cu succes!");
                    }
                }
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

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
