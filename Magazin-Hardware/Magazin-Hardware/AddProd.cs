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
    public partial class AddProd : Form
    {

        public AddProd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            float pret = 0;
            int cantitatea = 0;
            bool isValid = true;
            
            if(tb_nume.Text == "")
            {
                isValid = false;
                errorProvider1.SetError(tb_nume, "Introduceti numele produsului");
            }else if(tb_detalii.Text == "")
            {
                isValid = false;
                errorProvider1.SetError(tb_detalii, "Introduceti detalii despre produs.");
            }else if(!float.TryParse(this.tb_pret.Text, out pret))
            {
                isValid = false;
                errorProvider1.SetError(tb_pret, "Pret invalid.");
            }else if(!Int32.TryParse(this.tb_cantitate.Text, out cantitatea))
            {
                isValid = false;
                errorProvider1.SetError(tb_cantitate, "Cantitate invalida.");
            }

            
            if (isValid)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT MAX(Id) FROM [Componente]";
                    int id = Convert.ToInt32(comanda.ExecuteScalar());
                    comanda.CommandText = "INSERT INTO [Componente] VALUES(?,?,?,?,?)";
                    comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                    comanda.Parameters.Add("Denumire", OleDbType.Char, 50).Value = tb_nume.Text;
                    comanda.Parameters.Add("Detalii", OleDbType.Char, 255).Value = tb_detalii.Text;
                    comanda.Parameters.Add("Pret", OleDbType.Double).Value = Convert.ToDouble(tb_pret.Text);
                    comanda.Parameters.Add("Cantitate", OleDbType.Integer).Value = Convert.ToInt32(tb_cantitate.Text);
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Produs editat cu succes!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                    tb_nume.Clear();
                    tb_detalii.Clear();
                    tb_pret.Clear();
                    tb_cantitate.Clear();
                    errorProvider1.Clear();
                }
            }
        }

    }
}
