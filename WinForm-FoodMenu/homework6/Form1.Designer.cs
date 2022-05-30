namespace homework6
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bALIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAVUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çORBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbMenu = new System.Windows.Forms.RichTextBox();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.rtbYemekBilgi = new System.Windows.Forms.RichTextBox();
            this.rtbFiyat = new System.Windows.Forms.RichTextBox();
            this.btEkle = new System.Windows.Forms.Button();
            this.btSepetim = new System.Windows.Forms.Button();
            this.pcbYemekFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYemekFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bALIKToolStripMenuItem,
            this.tAVUKToolStripMenuItem,
            this.eTToolStripMenuItem,
            this.çORBAToolStripMenuItem,
            this.sALATAToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // bALIKToolStripMenuItem
            // 
            this.bALIKToolStripMenuItem.Name = "bALIKToolStripMenuItem";
            this.bALIKToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bALIKToolStripMenuItem.Text = "BALIK";
            this.bALIKToolStripMenuItem.Click += new System.EventHandler(this.bALIKToolStripMenuItem_Click);
            // 
            // tAVUKToolStripMenuItem
            // 
            this.tAVUKToolStripMenuItem.Name = "tAVUKToolStripMenuItem";
            this.tAVUKToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tAVUKToolStripMenuItem.Text = "TAVUK";
            this.tAVUKToolStripMenuItem.Click += new System.EventHandler(this.tAVUKToolStripMenuItem_Click);
            // 
            // eTToolStripMenuItem
            // 
            this.eTToolStripMenuItem.Name = "eTToolStripMenuItem";
            this.eTToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.eTToolStripMenuItem.Text = "ET";
            this.eTToolStripMenuItem.Click += new System.EventHandler(this.eTToolStripMenuItem_Click);
            // 
            // çORBAToolStripMenuItem
            // 
            this.çORBAToolStripMenuItem.Name = "çORBAToolStripMenuItem";
            this.çORBAToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.çORBAToolStripMenuItem.Text = "ÇORBA";
            this.çORBAToolStripMenuItem.Click += new System.EventHandler(this.çORBAToolStripMenuItem_Click_1);
            // 
            // sALATAToolStripMenuItem
            // 
            this.sALATAToolStripMenuItem.Name = "sALATAToolStripMenuItem";
            this.sALATAToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sALATAToolStripMenuItem.Text = "SALATA";
            this.sALATAToolStripMenuItem.Click += new System.EventHandler(this.sALATAToolStripMenuItem_Click_1);
            // 
            // rtbMenu
            // 
            this.rtbMenu.Enabled = false;
            this.rtbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbMenu.Location = new System.Drawing.Point(188, 38);
            this.rtbMenu.Name = "rtbMenu";
            this.rtbMenu.Size = new System.Drawing.Size(212, 137);
            this.rtbMenu.TabIndex = 1;
            this.rtbMenu.Text = "";
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(267, 234);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(54, 20);
            this.tbSayi.TabIndex = 2;
            this.tbSayi.TextChanged += new System.EventHandler(this.tbSayi_TextChanged);
            // 
            // rtbYemekBilgi
            // 
            this.rtbYemekBilgi.Enabled = false;
            this.rtbYemekBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbYemekBilgi.Location = new System.Drawing.Point(442, 39);
            this.rtbYemekBilgi.Name = "rtbYemekBilgi";
            this.rtbYemekBilgi.Size = new System.Drawing.Size(111, 247);
            this.rtbYemekBilgi.TabIndex = 3;
            this.rtbYemekBilgi.Text = "";
            this.rtbYemekBilgi.Visible = false;
            // 
            // rtbFiyat
            // 
            this.rtbFiyat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbFiyat.Enabled = false;
            this.rtbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbFiyat.Location = new System.Drawing.Point(552, 253);
            this.rtbFiyat.Name = "rtbFiyat";
            this.rtbFiyat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbFiyat.Size = new System.Drawing.Size(248, 33);
            this.rtbFiyat.TabIndex = 5;
            this.rtbFiyat.Text = "";
            this.rtbFiyat.Visible = false;
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(229, 270);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(131, 43);
            this.btEkle.TabIndex = 6;
            this.btEkle.Text = "SEPETE EKLE";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Visible = false;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // btSepetim
            // 
            this.btSepetim.Location = new System.Drawing.Point(281, 397);
            this.btSepetim.Name = "btSepetim";
            this.btSepetim.Size = new System.Drawing.Size(221, 41);
            this.btSepetim.TabIndex = 7;
            this.btSepetim.Text = "SEPETİM";
            this.btSepetim.UseVisualStyleBackColor = true;
            this.btSepetim.Click += new System.EventHandler(this.btSepetim_Click);
            // 
            // pcbYemekFoto
            // 
            this.pcbYemekFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pcbYemekFoto.Location = new System.Drawing.Point(552, 39);
            this.pcbYemekFoto.Name = "pcbYemekFoto";
            this.pcbYemekFoto.Size = new System.Drawing.Size(248, 216);
            this.pcbYemekFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbYemekFoto.TabIndex = 4;
            this.pcbYemekFoto.TabStop = false;
            this.pcbYemekFoto.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(241, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürün Numarasını Giriniz!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSepetim);
            this.Controls.Add(this.btEkle);
            this.Controls.Add(this.rtbFiyat);
            this.Controls.Add(this.pcbYemekFoto);
            this.Controls.Add(this.rtbYemekBilgi);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.rtbMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYemekFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bALIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAVUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çORBAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALATAToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbMenu;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.RichTextBox rtbYemekBilgi;
        private System.Windows.Forms.PictureBox pcbYemekFoto;
        private System.Windows.Forms.RichTextBox rtbFiyat;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Button btSepetim;
        private System.Windows.Forms.Label label1;
    }
}

