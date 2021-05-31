
namespace Magazin_Hardware
{
    partial class PlasareComanda
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_jud = new System.Windows.Forms.TextBox();
            this.cb_ramburs = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_mod = new System.Windows.Forms.Label();
            this.tb_loc = new System.Windows.Forms.TextBox();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.cb_card = new System.Windows.Forms.CheckBox();
            this.btn_finC = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_anulare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalii livrare";
            // 
            // tb_jud
            // 
            this.tb_jud.Location = new System.Drawing.Point(284, 117);
            this.tb_jud.Name = "tb_jud";
            this.tb_jud.Size = new System.Drawing.Size(159, 22);
            this.tb_jud.TabIndex = 1;
            // 
            // cb_ramburs
            // 
            this.cb_ramburs.AutoSize = true;
            this.cb_ramburs.Location = new System.Drawing.Point(284, 269);
            this.cb_ramburs.Name = "cb_ramburs";
            this.cb_ramburs.Size = new System.Drawing.Size(87, 21);
            this.cb_ramburs.TabIndex = 2;
            this.cb_ramburs.Text = "Ramburs";
            this.cb_ramburs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Judet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(280, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localitate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(280, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa:";
            // 
            // lb_mod
            // 
            this.lb_mod.AutoSize = true;
            this.lb_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lb_mod.Location = new System.Drawing.Point(280, 242);
            this.lb_mod.Name = "lb_mod";
            this.lb_mod.Size = new System.Drawing.Size(144, 24);
            this.lb_mod.TabIndex = 6;
            this.lb_mod.Text = "Modalitate plata:";
            // 
            // tb_loc
            // 
            this.tb_loc.Location = new System.Drawing.Point(284, 165);
            this.tb_loc.Name = "tb_loc";
            this.tb_loc.Size = new System.Drawing.Size(159, 22);
            this.tb_loc.TabIndex = 7;
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(284, 217);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(159, 22);
            this.tb_adresa.TabIndex = 8;
            // 
            // cb_card
            // 
            this.cb_card.AutoSize = true;
            this.cb_card.Location = new System.Drawing.Point(284, 296);
            this.cb_card.Name = "cb_card";
            this.cb_card.Size = new System.Drawing.Size(60, 21);
            this.cb_card.TabIndex = 9;
            this.cb_card.Text = "Card";
            this.cb_card.UseVisualStyleBackColor = true;
            // 
            // btn_finC
            // 
            this.btn_finC.Location = new System.Drawing.Point(232, 346);
            this.btn_finC.Name = "btn_finC";
            this.btn_finC.Size = new System.Drawing.Size(109, 52);
            this.btn_finC.TabIndex = 10;
            this.btn_finC.Text = "Plaseaza";
            this.btn_finC.UseVisualStyleBackColor = true;
            this.btn_finC.Click += new System.EventHandler(this.btn_finC_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_anulare
            // 
            this.btn_anulare.Location = new System.Drawing.Point(398, 346);
            this.btn_anulare.Name = "btn_anulare";
            this.btn_anulare.Size = new System.Drawing.Size(109, 52);
            this.btn_anulare.TabIndex = 11;
            this.btn_anulare.Text = "Anulare";
            this.btn_anulare.UseVisualStyleBackColor = true;
            this.btn_anulare.Click += new System.EventHandler(this.btn_anulare_Click);
            // 
            // PlasareComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_anulare);
            this.Controls.Add(this.btn_finC);
            this.Controls.Add(this.cb_card);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.tb_loc);
            this.Controls.Add(this.lb_mod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ramburs);
            this.Controls.Add(this.tb_jud);
            this.Controls.Add(this.label1);
            this.Name = "PlasareComanda";
            this.Text = "PlasareComanda";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_jud;
        private System.Windows.Forms.CheckBox cb_ramburs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_mod;
        private System.Windows.Forms.TextBox tb_loc;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.CheckBox cb_card;
        private System.Windows.Forms.Button btn_finC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_anulare;
    }
}