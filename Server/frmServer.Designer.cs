
namespace Server
{
    partial class frmServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.txtGiden = new System.Windows.Forms.TextBox();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.radioSpn = new System.Windows.Forms.RadioButton();
            this.radioSha = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anahtar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj";
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.Location = new System.Drawing.Point(288, 153);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(94, 29);
            this.btnMesajGonder.TabIndex = 2;
            this.btnMesajGonder.Text = "Gonder";
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // txtGiden
            // 
            this.txtGiden.Location = new System.Drawing.Point(75, 8);
            this.txtGiden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiden.Name = "txtGiden";
            this.txtGiden.Size = new System.Drawing.Size(307, 27);
            this.txtGiden.TabIndex = 3;
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(75, 72);
            this.txtAnahtar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(307, 27);
            this.txtAnahtar.TabIndex = 3;
            // 
            // radioSpn
            // 
            this.radioSpn.AutoSize = true;
            this.radioSpn.Location = new System.Drawing.Point(8, 132);
            this.radioSpn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioSpn.Name = "radioSpn";
            this.radioSpn.Size = new System.Drawing.Size(57, 24);
            this.radioSpn.TabIndex = 4;
            this.radioSpn.TabStop = true;
            this.radioSpn.Text = "SPN";
            this.radioSpn.UseVisualStyleBackColor = true;
            this.radioSpn.Click += new System.EventHandler(this.radioSpn_Click);
            // 
            // radioSha
            // 
            this.radioSha.AutoSize = true;
            this.radioSha.Location = new System.Drawing.Point(8, 165);
            this.radioSha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioSha.Name = "radioSha";
            this.radioSha.Size = new System.Drawing.Size(89, 24);
            this.radioSha.TabIndex = 4;
            this.radioSha.TabStop = true;
            this.radioSha.Text = "SHA-256";
            this.radioSha.UseVisualStyleBackColor = true;
            this.radioSha.Click += new System.EventHandler(this.radioSha_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 226);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.txtGiden);
            this.tabPage1.Controls.Add(this.radioSha);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.radioSpn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAnahtar);
            this.tabPage1.Controls.Add(this.btnMesajGonder);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(397, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mesaj Gonder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGonder);
            this.tabPage2.Controls.Add(this.txtDosyaAdi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(397, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dosya Gonder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(282, 92);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(86, 31);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Enabled = false;
            this.txtDosyaAdi.Location = new System.Drawing.Point(88, 53);
            this.txtDosyaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(279, 27);
            this.txtDosyaAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dosya Adı";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.TextBox txtGiden;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.RadioButton radioSpn;
        private System.Windows.Forms.RadioButton radioSha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label3;
    }
}

