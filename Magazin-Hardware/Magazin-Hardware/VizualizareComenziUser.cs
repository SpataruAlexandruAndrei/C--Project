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
    public partial class VizualizareComenziUser : Form
    {
        private static int idUser;
        public VizualizareComenziUser(int id)
        {
            InitializeComponent();
            VizualizareComenziUser.idUser = id;
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT NUME FROM [User] WHERE ID = " + idUser;
                string nume = Convert.ToString(comanda.ExecuteScalar());
                comanda.CommandText = "SELECT COUNT(ID_COMANDA) FROM [Comenzi] ";
                int count = Convert.ToInt32(comanda.ExecuteScalar());
                int idComanda = 1;
                for(int i = 0; i < count; i++)
                {
                    comanda.CommandText = "SELECT Nume_Client FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                    string nume1 = Convert.ToString(comanda.ExecuteScalar());
                    OleDbCommand comanda1 = new OleDbCommand();
                    comanda1.Connection = conexiune;
                    if (nume == nume1)
                    {
                        TreeNode t1 = tv_comenzi.Nodes.Add("Numar comanda: " + idComanda);
                        TreeNode t2 = tv_comenzi.Nodes[0].Nodes.Add("Date Facturare");
                        string name = "";
                        comanda1.CommandText = "SELECT Nume_Client FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        name = Convert.ToString(comanda1.ExecuteScalar());
                        t2.Nodes.Add("Nume: " + name);
                        string prenume = "";
                        comanda1.CommandText = "SELECT Prenume_Client FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        prenume = Convert.ToString(comanda1.ExecuteScalar());
                        t2.Nodes.Add("Prenume: " + prenume);
                        string email = "";
                        comanda1.CommandText = "SELECT Email FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        email = Convert.ToString(comanda1.ExecuteScalar());
                        t2.Nodes.Add("Email: " + email);
                        string numar = "";
                        comanda1.CommandText = "SELECT Telefon FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        numar = Convert.ToString(comanda1.ExecuteScalar());
                        t2.Nodes.Add("Numar Telefon: " + numar);
                        string adresa = "";
                        comanda1.CommandText = "SELECT Adresa FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        adresa = Convert.ToString(comanda1.ExecuteScalar());
                        t2.Nodes.Add("Adresa: " + adresa);
                        DateTime data;
                        comanda1.CommandText = "SELECT Data_Livrare FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        data = Convert.ToDateTime(comanda1.ExecuteScalar());
                        TreeNode t3 = tv_comenzi.Nodes[0].Nodes.Add("Date estimata livrarii: " + data.ToString());
                        TreeNode t4 = tv_comenzi.Nodes[0].Nodes.Add("Modalitate plata si cost");
                        string modalitate = "";
                        comanda1.CommandText = "SELECT Modalitate_Plata FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        modalitate = Convert.ToString(comanda1.ExecuteScalar());
                        t4.Nodes.Add("Modalitate plata: " + modalitate);
                        double cost = 0;
                        comanda1.CommandText = "SELECT Pret_Comanda FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        cost = Convert.ToDouble(comanda1.ExecuteScalar());
                        t4.Nodes.Add("Cost: " + cost);
                        string status = "";
                        comanda1.CommandText = "SELECT Comanda_Finalizata FROM [Comenzi] WHERE ID_Comanda = " + idComanda;
                        status = Convert.ToString(comanda1.ExecuteScalar());
                        if (status == "True")
                        {
                            TreeNode t5 = tv_comenzi.Nodes[0].Nodes.Add("Status comanda: Produs/e livrate");
                        }
                        else
                        {
                            TreeNode t5 = tv_comenzi.Nodes[0].Nodes.Add("Status comanda: Produs/e in curs de livrare");
                        }
                        TreeNode t6 = tv_comenzi.Nodes[0].Nodes.Add("Produs/e comandate");
                        int produse = 0;
                        comanda1.CommandText = "SELECT COUNT(ID_Comanda) FROM [Istoric_Produse_Comandate] WHERE ID_Comanda = " + idComanda;
                        produse = Convert.ToInt32(comanda1.ExecuteScalar());
                        for (int j = 0; j < produse; j++)
                        {
                            int cod = 0;
                            comanda1.CommandText = "SELECT ID FROM [Istoric_Produse_Comandate] WHERE ID_Comanda = " + idComanda;
                            cod = Convert.ToInt32(comanda1.ExecuteScalar());
                            TreeNode t7 = tv_comenzi.Nodes[0].Nodes[4].Nodes.Add("Cod produs: " + cod.ToString());
                            string denumire = "";
                            comanda1.CommandText = "SELECT Denumire_Produs FROM [Istoric_Produse_Comandate] WHERE ID_Comanda = " + idComanda;
                            denumire = Convert.ToString(comanda1.ExecuteScalar());
                            t7.Nodes.Add("Denumire produs: " + denumire);
                            string detalii = "";
                            comanda1.CommandText = "SELECT Detalii_Produs FROM [Istoric_Produse_Comandate] WHERE ID_Comanda = " + idComanda;
                            detalii = Convert.ToString(comanda1.ExecuteScalar());
                            t7.Nodes.Add("Detalii produs: " + detalii);
                            double pret = 0;
                            comanda1.CommandText = "SELECT Pret_produs FROM [Istoric_Produse_Comandate] WHERE ID_Comanda = " + idComanda;
                            pret = Convert.ToDouble(comanda1.ExecuteScalar());
                            t7.Nodes.Add("Pret produs: " + pret.ToString());
                            int nr = 0;
                            comanda1.CommandText = "SELECT Cantitate_Comandata FROM [Istoric_Produse_Comandate] WHERE ID_Comanda = " + idComanda;
                            nr = Convert.ToInt32(comanda1.ExecuteScalar());
                            t7.Nodes.Add("Cantitate comandata: " + nr);
                        }
                    }
                    idComanda++;
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
    }
}
