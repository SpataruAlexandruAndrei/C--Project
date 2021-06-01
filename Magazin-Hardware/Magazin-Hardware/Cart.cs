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
    public partial class Cart : Form
    {
        private static int idUser;

        public Cart(int id)
        {
            InitializeComponent();
            Cart.idUser = id;
            displayList();
            double sum = displayVal();
            lb_valoareC.Text = "Total comanda: " + sum.ToString() + " lei";
        }

        public Cart()
        {
            InitializeComponent();
            displayList();
            double sum = displayVal();
            lb_valoareC.Text = "Total comanda: " + sum.ToString() + " lei";
        }


        public void refresh()
        {
            lv_cart.Items.Clear();
            displayList();
            double sum = displayVal();
            lb_valoareC.Text = "Total comanda: " + sum.ToString() + " lei";
        }

        private double displayVal()
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            conexiune.Open();
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT COUNT(ID_CLIENT) FROM [Cos] WHERE ID_CLIENT = " + idUser;
            int count = Convert.ToInt32(comanda.ExecuteScalar());
            if(count > 0)
            {
                comanda.CommandText = "SELECT SUM(PRET * CANTITATE) FROM [COS] WHERE ID_CLIENT = " + idUser;
                double sum = Convert.ToDouble(comanda.ExecuteScalar());
                return sum;
            }
            return 0;
        }

        private void displayList()
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Bd_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT COUNT(ID_CLIENT) FROM [Cos] WHERE ID_CLIENT = " + idUser;
                int count = Convert.ToInt32(comanda.ExecuteScalar());
                if(count > 0)
                {
                    comanda.CommandText = "SELECT * FROM [Cos] WHERE ID_CLIENT = " + idUser;
                    OleDbDataReader reader = comanda.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem itm = new ListViewItem(reader["ID_Produs"].ToString());
                        itm.SubItems.Add(reader["Denumire"].ToString());
                        itm.SubItems.Add(reader["Detalii_Produs"].ToString());
                        itm.SubItems.Add(reader["Pret"].ToString());
                        itm.SubItems.Add(reader["Cantitate"].ToString());
                        lv_cart.Items.Add(itm);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in lv_cart.Items)
                {
                    int ID = Convert.ToInt32(itm.SubItems[0].Text);
                    comanda.CommandText = "SELECT Cantitate FROM [Cos] WHERE ID = " + ID + " AND ID_CLIENT = " + idUser;
                    int cantitate = Convert.ToInt32(comanda.ExecuteScalar());
                    if (itm.Selected && cantitate - 1 > 0)
                    {
                        comanda.CommandText = "UPDATE [Cos] SET CANTITATE = CANTITATE - " + 1 + " WHERE ID = " + ID;
                        comanda.ExecuteScalar();
                        MessageBox.Show("Cantiatea produsului: " + itm.SubItems[1].Text + "a scazut cu 1!");
                    }
                    else if (itm.Selected)
                    {
                        string pro = itm.SubItems[1].Text;
                        comanda.CommandText = "DELETE FROM [Cos] WHERE DENUMIRE='" + pro + "'";
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Produsul a fost sters din cos!");
                    }
                }
                refresh();
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

        private void btn_comanda_Click(object sender, EventArgs e)
        {
            double sum = displayVal();
            List<Componente> lista = new List<Componente>();
            //Componente c = new Componente(); 
            foreach (ListViewItem itm in lv_cart.Items)
            {
                Componente c = new Componente();
                c.Id = Convert.ToInt32(itm.SubItems[0].Text);
                c.Denumire = itm.SubItems[1].Text;
                c.Detalii = itm.SubItems[2].Text;
                c.Pret = Convert.ToDouble(itm.SubItems[3].Text);
                c.Cantitate = Convert.ToInt32(itm.SubItems[4].Text);
                lista.Add(c);
            }
            PlasareComanda pc = new PlasareComanda(idUser, sum, lista);
            pc.Show();
            refresh();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
