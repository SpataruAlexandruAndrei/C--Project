
namespace Magazin_Hardware
{
    partial class AdminDashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_show = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.panel_subMenu_Prod_btns = new System.Windows.Forms.Panel();
            this.btn_stat = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_vizualizare = new System.Windows.Forms.Button();
            this.btn_comenziAdmin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_prod = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_show.SuspendLayout();
            this.panel_subMenu_Prod_btns.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show
            // 
            this.panel_show.Controls.Add(this.bt_exit);
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(264, 0);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1358, 769);
            this.panel_show.TabIndex = 3;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Image = global::Magazin_Hardware.Properties.Resources.x;
            this.bt_exit.Location = new System.Drawing.Point(1288, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(58, 58);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_profil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_profil.FlatAppearance.BorderSize = 0;
            this.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profil.ForeColor = System.Drawing.Color.Black;
            this.btn_profil.Location = new System.Drawing.Point(0, 494);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_profil.Size = new System.Drawing.Size(264, 66);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Log Out";
            this.btn_profil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profil.UseVisualStyleBackColor = false;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // panel_subMenu_Prod_btns
            // 
            this.panel_subMenu_Prod_btns.BackColor = System.Drawing.Color.LightYellow;
            this.panel_subMenu_Prod_btns.Controls.Add(this.btn_stat);
            this.panel_subMenu_Prod_btns.Controls.Add(this.btn_add);
            this.panel_subMenu_Prod_btns.Controls.Add(this.btn_vizualizare);
            this.panel_subMenu_Prod_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_subMenu_Prod_btns.Location = new System.Drawing.Point(0, 239);
            this.panel_subMenu_Prod_btns.Name = "panel_subMenu_Prod_btns";
            this.panel_subMenu_Prod_btns.Size = new System.Drawing.Size(264, 195);
            this.panel_subMenu_Prod_btns.TabIndex = 2;
            this.panel_subMenu_Prod_btns.Visible = false;
            // 
            // btn_stat
            // 
            this.btn_stat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_stat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stat.FlatAppearance.BorderSize = 0;
            this.btn_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stat.ForeColor = System.Drawing.Color.Black;
            this.btn_stat.Location = new System.Drawing.Point(0, 120);
            this.btn_stat.Name = "btn_stat";
            this.btn_stat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_stat.Size = new System.Drawing.Size(264, 60);
            this.btn_stat.TabIndex = 8;
            this.btn_stat.Text = "Statistici";
            this.btn_stat.UseVisualStyleBackColor = false;
            this.btn_stat.Click += new System.EventHandler(this.btn_stat_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(0, 60);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(264, 60);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Adauga produs";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_vizualizare
            // 
            this.btn_vizualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_vizualizare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vizualizare.FlatAppearance.BorderSize = 0;
            this.btn_vizualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vizualizare.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vizualizare.ForeColor = System.Drawing.Color.Black;
            this.btn_vizualizare.Location = new System.Drawing.Point(0, 0);
            this.btn_vizualizare.Name = "btn_vizualizare";
            this.btn_vizualizare.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_vizualizare.Size = new System.Drawing.Size(264, 60);
            this.btn_vizualizare.TabIndex = 10;
            this.btn_vizualizare.Text = "Afiseaza produsele";
            this.btn_vizualizare.UseVisualStyleBackColor = false;
            this.btn_vizualizare.Click += new System.EventHandler(this.btn_vizualizare_Click);
            // 
            // btn_comenziAdmin
            // 
            this.btn_comenziAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_comenziAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_comenziAdmin.FlatAppearance.BorderSize = 0;
            this.btn_comenziAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comenziAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comenziAdmin.ForeColor = System.Drawing.Color.Black;
            this.btn_comenziAdmin.Location = new System.Drawing.Point(0, 434);
            this.btn_comenziAdmin.Name = "btn_comenziAdmin";
            this.btn_comenziAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_comenziAdmin.Size = new System.Drawing.Size(264, 60);
            this.btn_comenziAdmin.TabIndex = 2;
            this.btn_comenziAdmin.Text = "Comenzi";
            this.btn_comenziAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comenziAdmin.UseVisualStyleBackColor = false;
            this.btn_comenziAdmin.Click += new System.EventHandler(this.btn_comenziAdmin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_profil);
            this.panel3.Controls.Add(this.btn_comenziAdmin);
            this.panel3.Controls.Add(this.panel_subMenu_Prod_btns);
            this.panel3.Controls.Add(this.btn_prod);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 769);
            this.panel3.TabIndex = 2;
            // 
            // btn_prod
            // 
            this.btn_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btn_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod.FlatAppearance.BorderSize = 0;
            this.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.ForeColor = System.Drawing.Color.Black;
            this.btn_prod.Location = new System.Drawing.Point(0, 173);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_prod.Size = new System.Drawing.Size(264, 66);
            this.btn_prod.TabIndex = 1;
            this.btn_prod.Text = "Produse";
            this.btn_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.UseVisualStyleBackColor = false;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Magazin_Hardware.Properties.Resources.Poza_comp;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 173);
            this.panel2.TabIndex = 6;
            // 
            // AdminDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 769);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashbord";
            this.panel_show.ResumeLayout(false);
            this.panel_subMenu_Prod_btns.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Panel panel_subMenu_Prod_btns;
        private System.Windows.Forms.Button btn_stat;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_vizualizare;
        private System.Windows.Forms.Button btn_comenziAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_exit;
    }
}