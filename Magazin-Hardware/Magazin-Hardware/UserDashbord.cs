using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_Hardware
{
    public delegate void CallBack(object obj, string path);
    public partial class UserDashbord : Form
    {
        private Form activeForm = null;
        private static int idUser;

        public UserDashbord(int id)
        {
            InitializeComponent();
            UserDashbord.idUser = id;
        }
        public UserDashbord()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            panel_subMenu_profil_btns.Visible = false;
            panel_subMenu_Prod_btns.Visible = false;
        }

        private void toggleSubMenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panel_subMenu_profil_btns);
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panel_subMenu_Prod_btns);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(childForm);
            panel_show.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_vizualizare_Click(object sender, EventArgs e)
        {
            AfisareProdUSer form = new AfisareProdUSer(idUser);
            openChildForm(form);
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=BD_Proiect.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT COUNT(ID_CLIENT) FROM [Cos] WHERE ID_CLIENT = " + idUser;
                int count = Convert.ToInt32(comanda.ExecuteScalar());
                if(count > 0)
                {
                    Cart form = new Cart(idUser);
                    openChildForm(form);
                }
                else
                {
                    MessageBox.Show("Nu aveti produse in cos!");
                    Cart form = new Cart();
                    openChildForm(form);
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

        private void btn_comenzi_Click(object sender, EventArgs e)
        {
            VizualizareComenziUser form = new VizualizareComenziUser(idUser);
            openChildForm(form);
        }
    }
}
