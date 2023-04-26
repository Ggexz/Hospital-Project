
namespace Prj.Modules.Login
{
    partial class LoginEkrani
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LgnKlncHastane = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LgnKlncAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LgnKlncSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LgnKlncSube = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LgnGirisButton = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncHastane.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncSube.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(281, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Hastane";
            // 
            // LgnKlncHastane
            // 
            this.LgnKlncHastane.Location = new System.Drawing.Point(281, 47);
            this.LgnKlncHastane.Name = "LgnKlncHastane";
            this.LgnKlncHastane.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LgnKlncHastane.Size = new System.Drawing.Size(170, 26);
            this.LgnKlncHastane.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(281, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kullanıcı Adı";
            // 
            // LgnKlncAdi
            // 
            this.LgnKlncAdi.Location = new System.Drawing.Point(281, 115);
            this.LgnKlncAdi.Name = "LgnKlncAdi";
            this.LgnKlncAdi.Size = new System.Drawing.Size(170, 26);
            this.LgnKlncAdi.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(281, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Şifre";
            // 
            // LgnKlncSifre
            // 
            this.LgnKlncSifre.Location = new System.Drawing.Point(281, 183);
            this.LgnKlncSifre.Name = "LgnKlncSifre";
            this.LgnKlncSifre.Size = new System.Drawing.Size(170, 26);
            this.LgnKlncSifre.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(281, 226);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Şube";
            // 
            // LgnKlncSube
            // 
            this.LgnKlncSube.Location = new System.Drawing.Point(281, 251);
            this.LgnKlncSube.Name = "LgnKlncSube";
            this.LgnKlncSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LgnKlncSube.Size = new System.Drawing.Size(170, 26);
            this.LgnKlncSube.TabIndex = 5;
            // 
            // LgnGirisButton
            // 
            this.LgnGirisButton.Location = new System.Drawing.Point(295, 300);
            this.LgnGirisButton.Name = "LgnGirisButton";
            this.LgnGirisButton.Size = new System.Drawing.Size(126, 50);
            this.LgnGirisButton.TabIndex = 6;
            this.LgnGirisButton.Text = "Giriş";
            this.LgnGirisButton.Click += new System.EventHandler(this.LgnGirisButton_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(295, 366);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(122, 19);
            this.hyperlinkLabelControl1.TabIndex = 7;
            this.hyperlinkLabelControl1.Text = "Şifremi  Unuttum";
            // 
            // LoginEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.LgnGirisButton);
            this.Controls.Add(this.LgnKlncSube);
            this.Controls.Add(this.LgnKlncSifre);
            this.Controls.Add(this.LgnKlncAdi);
            this.Controls.Add(this.LgnKlncHastane);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "LoginEkrani";
            this.Text = "LoginEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncHastane.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LgnKlncSube.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit LgnKlncHastane;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit LgnKlncAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit LgnKlncSifre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit LgnKlncSube;
        private DevExpress.XtraEditors.SimpleButton LgnGirisButton;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}