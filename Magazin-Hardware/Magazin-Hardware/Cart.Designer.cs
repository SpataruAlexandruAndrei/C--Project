
namespace Magazin_Hardware
{
    partial class Cart
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
            this.lv_cart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_comanda = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_valoareC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_cart
            // 
            this.lv_cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_cart.GridLines = true;
            this.lv_cart.HideSelection = false;
            this.lv_cart.Location = new System.Drawing.Point(378, 127);
            this.lv_cart.Name = "lv_cart";
            this.lv_cart.Size = new System.Drawing.Size(1179, 390);
            this.lv_cart.TabIndex = 0;
            this.lv_cart.UseCompatibleStateImageBehavior = false;
            this.lv_cart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod Produs";
            this.columnHeader1.Width = 235;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Denumire";
            this.columnHeader2.Width = 235;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pret";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantitate";
            this.columnHeader4.Width = 235;
            // 
            // btn_comanda
            // 
            this.btn_comanda.Location = new System.Drawing.Point(397, 582);
            this.btn_comanda.Name = "btn_comanda";
            this.btn_comanda.Size = new System.Drawing.Size(166, 74);
            this.btn_comanda.TabIndex = 1;
            this.btn_comanda.Text = "Plaseaza comanda";
            this.btn_comanda.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(1391, 582);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(166, 74);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Sterge";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_valoareC
            // 
            this.lb_valoareC.AutoSize = true;
            this.lb_valoareC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valoareC.Location = new System.Drawing.Point(839, 604);
            this.lb_valoareC.Name = "lb_valoareC";
            this.lb_valoareC.Size = new System.Drawing.Size(147, 25);
            this.lb_valoareC.TabIndex = 3;
            this.lb_valoareC.Text = "Total Comnda :";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 722);
            this.Controls.Add(this.lb_valoareC);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_comanda);
            this.Controls.Add(this.lv_cart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_cart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_comanda;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_valoareC;
    }
}