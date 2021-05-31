
namespace Magazin_Hardware
{
    partial class VizualizareComenziUser
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
            this.tv_comenzi = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tv_comenzi
            // 
            this.tv_comenzi.Location = new System.Drawing.Point(601, 81);
            this.tv_comenzi.Name = "tv_comenzi";
            this.tv_comenzi.Size = new System.Drawing.Size(944, 572);
            this.tv_comenzi.TabIndex = 0;
            // 
            // VizualizareComenziUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 722);
            this.Controls.Add(this.tv_comenzi);
            this.Name = "VizualizareComenziUser";
            this.Text = "VizualizareComenziUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_comenzi;
    }
}