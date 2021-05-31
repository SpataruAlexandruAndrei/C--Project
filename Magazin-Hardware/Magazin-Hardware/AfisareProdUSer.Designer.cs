
namespace Magazin_Hardware
{
    partial class AfisareProdUSer
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
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detalii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_prod = new System.Windows.Forms.ListView();
            this.btn_add_cart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Text = "Cod Produs";
            this.ID.Width = 235;
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 235;
            // 
            // Detalii
            // 
            this.Detalii.Text = "Detalii";
            this.Detalii.Width = 235;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            this.Pret.Width = 235;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.Width = 235;
            // 
            // lv_prod
            // 
            this.lv_prod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Denumire,
            this.Detalii,
            this.Pret,
            this.Cantitate});
            this.lv_prod.GridLines = true;
            this.lv_prod.HideSelection = false;
            this.lv_prod.Location = new System.Drawing.Point(378, 127);
            this.lv_prod.Name = "lv_prod";
            this.lv_prod.Size = new System.Drawing.Size(1175, 393);
            this.lv_prod.TabIndex = 7;
            this.lv_prod.UseCompatibleStateImageBehavior = false;
            this.lv_prod.View = System.Windows.Forms.View.Details;
            // 
            // btn_add_cart
            // 
            this.btn_add_cart.Location = new System.Drawing.Point(812, 567);
            this.btn_add_cart.Name = "btn_add_cart";
            this.btn_add_cart.Size = new System.Drawing.Size(202, 57);
            this.btn_add_cart.TabIndex = 8;
            this.btn_add_cart.Text = "Adauga in cos";
            this.btn_add_cart.UseVisualStyleBackColor = true;
            this.btn_add_cart.Click += new System.EventHandler(this.btn_add_cart_Click);
            // 
            // AfisareProdUSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 722);
            this.Controls.Add(this.btn_add_cart);
            this.Controls.Add(this.lv_prod);
            this.Name = "AfisareProdUSer";
            this.Text = "AfisareProdUSer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Detalii;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Cantitate;
        private System.Windows.Forms.ListView lv_prod;
        private System.Windows.Forms.Button btn_add_cart;
    }
}