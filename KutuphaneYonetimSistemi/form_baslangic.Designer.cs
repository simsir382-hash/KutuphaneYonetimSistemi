namespace KutuphaneYonetimSistemi
{
    partial class form_baslangic
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
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnKitapYonet = new System.Windows.Forms.Button();
            this.panelIcerik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcerik
            // 
            this.panelIcerik.Controls.Add(this.btnKitapYonet);
            this.panelIcerik.Controls.Add(this.btnKitaplar);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 0);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Size = new System.Drawing.Size(800, 450);
            this.panelIcerik.TabIndex = 0;
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.Location = new System.Drawing.Point(12, 25);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(119, 23);
            this.btnKitaplar.TabIndex = 1;
            this.btnKitaplar.Text = "Kitap Listesi";
            this.btnKitaplar.UseVisualStyleBackColor = true;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnKitapYonet
            // 
            this.btnKitapYonet.Location = new System.Drawing.Point(167, 25);
            this.btnKitapYonet.Name = "btnKitapYonet";
            this.btnKitapYonet.Size = new System.Drawing.Size(119, 23);
            this.btnKitapYonet.TabIndex = 2;
            this.btnKitapYonet.Text = "Kitap Yönet";
            this.btnKitapYonet.UseVisualStyleBackColor = true;
            this.btnKitapYonet.Click += new System.EventHandler(this.btnKitapYonet_Click);
            // 
            // form_baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelIcerik);
            this.Name = "form_baslangic";
            this.Text = "x";
            this.panelIcerik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnKitapYonet;
    }
}