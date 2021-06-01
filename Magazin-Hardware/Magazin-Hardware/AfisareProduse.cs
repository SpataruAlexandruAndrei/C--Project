using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Magazin_Hardware
{
    public partial class AfisareProduse : Form
    {

        public AfisareProduse()
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in lv_prod.Items)
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "SELECT ID FROM [Componente] WHERE ID=" + id;
                        int ID = Convert.ToInt32(comanda.ExecuteScalar());
                        int Id = Convert.ToInt32(comanda.ExecuteScalar());
                        EditareProdus edit = new EditareProdus(Id);
                        edit.Show();
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
                foreach (ListViewItem itm in lv_prod.Items)
                    if (itm.Selected)
                    {
                        string pro = itm.SubItems[1].Text;
                        comanda.CommandText = "DELETE FROM [COMPONENTE] WHERE DENUMIRE='" + pro + "'";
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Stergere realizata cu succes!");
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
