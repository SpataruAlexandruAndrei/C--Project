
namespace Magazin_Hardware
{
    partial class Statistici
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_afis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(277, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 641);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(125, 277);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(146, 77);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Preluare date";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_afis
            // 
            this.btn_afis.Location = new System.Drawing.Point(125, 502);
            this.btn_afis.Name = "btn_afis";
            this.btn_afis.Size = new System.Drawing.Size(146, 77);
            this.btn_afis.TabIndex = 2;
            this.btn_afis.Text = "Afisare date";
            this.btn_afis.UseVisualStyleBackColor = true;
            this.btn_afis.Click += new System.EventHandler(this.btn_afis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diagrama pentru cel mai cumparat produs si ordinea cumpararii lui";
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Image = global::Magazin_Hardware.Properties.Resources.x;
            this.bt_exit.Location = new System.Drawing.Point(1174, 1);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(58, 58);
            this.bt_exit.TabIndex = 8;
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Statistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 722);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_afis);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_afis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_exit;
    }
}