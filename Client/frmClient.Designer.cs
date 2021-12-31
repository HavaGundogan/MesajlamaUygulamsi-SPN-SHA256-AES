
namespace Client
{
    partial class frmClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGelen = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.btnCoz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCozulen = new System.Windows.Forms.TextBox();
            this.lblDosya = new System.Windows.Forms.Label();
            this.lblAlinanDosyaAdi = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtGelen
            // 
            this.txtGelen.Location = new System.Drawing.Point(14, 35);
            this.txtGelen.Name = "txtGelen";
            this.txtGelen.Size = new System.Drawing.Size(346, 95);
            this.txtGelen.TabIndex = 0;
            this.txtGelen.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gelen Cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anahtar";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(14, 173);
            this.txtAnahtar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(346, 27);
            this.txtAnahtar.TabIndex = 3;
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(274, 273);
            this.btnCoz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(86, 31);
            this.btnCoz.TabIndex = 4;
            this.btnCoz.Text = "Sifre Coz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cozulen Cipher";
            // 
            // txtCozulen
            // 
            this.txtCozulen.Location = new System.Drawing.Point(14, 235);
            this.txtCozulen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCozulen.Name = "txtCozulen";
            this.txtCozulen.Size = new System.Drawing.Size(346, 27);
            this.txtCozulen.TabIndex = 3;
            // 
            // lblDosya
            // 
            this.lblDosya.AutoSize = true;
            this.lblDosya.Location = new System.Drawing.Point(12, 348);
            this.lblDosya.Name = "lblDosya";
            this.lblDosya.Size = new System.Drawing.Size(99, 20);
            this.lblDosya.TabIndex = 5;
            this.lblDosya.Text = "Alınan Dosya:";
            // 
            // lblAlinanDosyaAdi
            // 
            this.lblAlinanDosyaAdi.AutoSize = true;
            this.lblAlinanDosyaAdi.Location = new System.Drawing.Point(117, 348);
            this.lblAlinanDosyaAdi.Name = "lblAlinanDosyaAdi";
            this.lblAlinanDosyaAdi.Size = new System.Drawing.Size(0, 20);
            this.lblAlinanDosyaAdi.TabIndex = 6;
            this.lblAlinanDosyaAdi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblAlinanDosyaAdi_MouseClick);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 375);
            this.Controls.Add(this.lblAlinanDosyaAdi);
            this.Controls.Add(this.lblDosya);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.txtCozulen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGelen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtGelen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCozulen;
        private System.Windows.Forms.Label lblDosya;
        private System.Windows.Forms.LinkLabel lblAlinanDosyaAdi;
    }
}

