
namespace Magazin_Hardware
{
    partial class EditareProdus
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
            this.btn_anulare = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_cantitate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pret = new System.Windows.Forms.TextBox();
            this.tb_detalii = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anulare
            // 
            this.btn_anulare.BackColor = System.Drawing.Color.Red;
            this.btn_anulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_anulare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anulare.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_anulare.Location = new System.Drawing.Point(443, 353);
            this.btn_anulare.Name = "btn_anulare";
            this.btn_anulare.Size = new System.Drawing.Size(116, 48);
            this.btn_anulare.TabIndex = 23;
            this.btn_anulare.Text = "Cancel";
            this.btn_anulare.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(254, 353);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(116, 48);
            this.btn_edit.TabIndex = 22;
            this.btn_edit.Text = "Modifica";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_cantitate
            // 
            this.tb_cantitate.Location = new System.Drawing.Point(300, 304);
            this.tb_cantitate.Name = "tb_cantitate";
            this.tb_cantitate.Size = new System.Drawing.Size(202, 22);
            this.tb_cantitate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(296, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cantitate:";
            // 
            // tb_pret
            // 
            this.tb_pret.Location = new System.Drawing.Point(300, 253);
            this.tb_pret.Name = "tb_pret";
            this.tb_pret.Size = new System.Drawing.Size(202, 22);
            this.tb_pret.TabIndex = 19;
            // 
            // tb_detalii
            // 
            this.tb_detalii.Location = new System.Drawing.Point(300, 202);
            this.tb_detalii.Name = "tb_detalii";
            this.tb_detalii.Size = new System.Drawing.Size(202, 22);
            this.tb_detalii.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(298, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(298, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Detalii:";
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(300, 150);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(202, 22);
            this.tb_nume.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(296, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modifica Produsul";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_anulare);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_cantitate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_pret);
            this.Controls.Add(this.tb_detalii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditareProdus";
            this.Text = "EditareProdus";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anulare;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_cantitate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pret;
        private System.Windows.Forms.TextBox tb_detalii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}