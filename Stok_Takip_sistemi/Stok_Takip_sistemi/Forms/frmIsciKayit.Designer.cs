namespace Stok_Takip_sistemi.Forms
{
    partial class frmIsciKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCAd = new System.Windows.Forms.TextBox();
            this.txtCMaas = new System.Windows.Forms.TextBox();
            this.txtCSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşçi Kayıt Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // txtCAd
            // 
            this.txtCAd.Location = new System.Drawing.Point(102, 75);
            this.txtCAd.Name = "txtCAd";
            this.txtCAd.Size = new System.Drawing.Size(143, 22);
            this.txtCAd.TabIndex = 4;
            // 
            // txtCMaas
            // 
            this.txtCMaas.Location = new System.Drawing.Point(102, 109);
            this.txtCMaas.Name = "txtCMaas";
            this.txtCMaas.Size = new System.Drawing.Size(143, 22);
            this.txtCMaas.TabIndex = 5;
            // 
            // txtCSifre
            // 
            this.txtCSifre.Location = new System.Drawing.Point(102, 145);
            this.txtCSifre.Name = "txtCSifre";
            this.txtCSifre.Size = new System.Drawing.Size(143, 22);
            this.txtCSifre.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIsciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCSifre);
            this.Controls.Add(this.txtCMaas);
            this.Controls.Add(this.txtCAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIsciKayit";
            this.Text = "frmIsciKayit";
            this.Load += new System.EventHandler(this.frmIsciKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCAd;
        private System.Windows.Forms.TextBox txtCMaas;
        private System.Windows.Forms.TextBox txtCSifre;
        private System.Windows.Forms.Button button1;
    }
}