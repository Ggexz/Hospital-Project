
namespace Prj.Modules.Buttons
{
    partial class ButtonEkrani
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
            this.BttnEkrnHastaProtokol = new DevExpress.XtraEditors.SimpleButton();
            this.BttnEkrnHastaBilgileri = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BttnEkrnHastaProtokol
            // 
            this.BttnEkrnHastaProtokol.Location = new System.Drawing.Point(397, 155);
            this.BttnEkrnHastaProtokol.Name = "BttnEkrnHastaProtokol";
            this.BttnEkrnHastaProtokol.Size = new System.Drawing.Size(170, 73);
            this.BttnEkrnHastaProtokol.TabIndex = 0;
            this.BttnEkrnHastaProtokol.Text = "s";
            // 
            // BttnEkrnHastaBilgileri
            // 
            this.BttnEkrnHastaBilgileri.Location = new System.Drawing.Point(130, 155);
            this.BttnEkrnHastaBilgileri.Name = "BttnEkrnHastaBilgileri";
            this.BttnEkrnHastaBilgileri.Size = new System.Drawing.Size(178, 73);
            this.BttnEkrnHastaBilgileri.TabIndex = 1;
            this.BttnEkrnHastaBilgileri.Text = "Hasta Bilgileri";
            this.BttnEkrnHastaBilgileri.Click += new System.EventHandler(this.BttnEkrnHastaBilgileri_Click);
            // 
            // ButtonEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttnEkrnHastaBilgileri);
            this.Controls.Add(this.BttnEkrnHastaProtokol);
            this.Name = "ButtonEkrani";
            this.Text = "ButtonEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BttnEkrnHastaProtokol;
        private DevExpress.XtraEditors.SimpleButton BttnEkrnHastaBilgileri;
    }
}