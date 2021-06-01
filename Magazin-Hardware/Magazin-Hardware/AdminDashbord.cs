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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Magazin_Hardware
{
    public partial class AdminDashbord : Form
    {
        
        private Form activeForm = null;
        
        public AdminDashbord()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
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
            ((Form)this.TopLevelControl).Close();
            this.Hide();
            Form1 logIn = new Form1();
            logIn.ShowDialog();

        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panel_subMenu_Prod_btns);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProd form = new AddProd();
            openChildForm(form);
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
            AfisareProduse form = new AfisareProduse();
   
            openChildForm(form);
        }

        private void btn_comenziAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btn_stat_Click(object sender, EventArgs e)
        {
            Statistici form = new Statistici();

            openChildForm(form);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
