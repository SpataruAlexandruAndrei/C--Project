
namespace Magazin_Hardware
{
    partial class AddProd
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_detalii = new System.Windows.Forms.TextBox();
            this.tb_pret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cantitate = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_anulare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adauga Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(513, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume:";
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(517, 199);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(202, 22);
            this.tb_nume.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(515, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detalii:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(515, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pret:";
            // 
            // tb_detalii
            // 
            this.tb_detalii.Location = new System.Drawing.Point(517, 251);
            this.tb_detalii.Name = "tb_detalii";
            this.tb_detalii.Size = new System.Drawing.Size(202, 22);
            this.tb_detalii.TabIndex = 6;
            // 
            // tb_pret
            // 
            this.tb_pret.Location = new System.Drawing.Point(517, 302);
            this.tb_pret.Name = "tb_pret";
            this.tb_pret.Size = new System.Drawing.Size(202, 22);
            this.tb_pret.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(513, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantitate:";
            // 
            // tb_cantitate
            // 
            this.tb_cantitate.Location = new System.Drawing.Point(517, 353);
            this.tb_cantitate.Name = "tb_cantitate";
            this.tb_cantitate.Size = new System.Drawing.Size(202, 22);
            this.tb_cantitate.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(471, 402);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 48);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Adauga";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_anulare
            // 
            this.btn_anulare.BackColor = System.Drawing.Color.Red;
            this.btn_anulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_anulare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anulare.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_anulare.Location = new System.Drawing.Point(660, 402);
            this.btn_anulare.Name = "btn_anulare";
            this.btn_anulare.Size = new System.Drawing.Size(116, 48);
            this.btn_anulare.TabIndex = 11;
            this.btn_anulare.Text = "Cancel";
            this.btn_anulare.UseVisualStyleBackColor = false;
            this.btn_anulare.Click += new System.EventHandler(this.btn_anulare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 722);
            this.Controls.Add(this.btn_anulare);
            this.Controls.Add(this.btn_add);
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
            this.Name = "AddProd";
            this.Text = "AddProd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_detalii;
        private System.Windows.Forms.TextBox tb_pret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cantitate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_anulare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}