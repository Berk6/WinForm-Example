namespace Homework3
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
            this.ckbCevre = new System.Windows.Forms.CheckBox();
            this.ckbPerformans = new System.Windows.Forms.CheckBox();
            this.ckbFiyat = new System.Windows.Forms.CheckBox();
            this.gbArabalar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbAudi = new System.Windows.Forms.Label();
            this.lbBMW = new System.Windows.Forms.Label();
            this.lbHonda = new System.Windows.Forms.Label();
            this.lbDefaultAraba = new System.Windows.Forms.Label();
            this.cmbMercedes = new System.Windows.Forms.ComboBox();
            this.cmbAudi = new System.Windows.Forms.ComboBox();
            this.cmbBMW = new System.Windows.Forms.ComboBox();
            this.cmbHonda = new System.Windows.Forms.ComboBox();
            this.cmbDefaultAraba = new System.Windows.Forms.ComboBox();
            this.lbMercedes = new System.Windows.Forms.Label();
            this.ckbDefault = new System.Windows.Forms.CheckBox();
            this.gbArabalar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbCevre
            // 
            this.ckbCevre.AutoSize = true;
            this.ckbCevre.Location = new System.Drawing.Point(99, 392);
            this.ckbCevre.Name = "ckbCevre";
            this.ckbCevre.Size = new System.Drawing.Size(85, 17);
            this.ckbCevre.TabIndex = 0;
            this.ckbCevre.Text = "Çevre Kirliliği";
            this.ckbCevre.UseVisualStyleBackColor = true;
            this.ckbCevre.Click += new System.EventHandler(this.ckbCevre_Click);
            // 
            // ckbPerformans
            // 
            this.ckbPerformans.AutoSize = true;
            this.ckbPerformans.Location = new System.Drawing.Point(99, 369);
            this.ckbPerformans.Name = "ckbPerformans";
            this.ckbPerformans.Size = new System.Drawing.Size(79, 17);
            this.ckbPerformans.TabIndex = 1;
            this.ckbPerformans.Text = "Performans";
            this.ckbPerformans.UseVisualStyleBackColor = true;
            this.ckbPerformans.Click += new System.EventHandler(this.ckbPerformans_Click);
            // 
            // ckbFiyat
            // 
            this.ckbFiyat.AutoSize = true;
            this.ckbFiyat.Location = new System.Drawing.Point(99, 346);
            this.ckbFiyat.Name = "ckbFiyat";
            this.ckbFiyat.Size = new System.Drawing.Size(48, 17);
            this.ckbFiyat.TabIndex = 1;
            this.ckbFiyat.Text = "Fiyat";
            this.ckbFiyat.UseVisualStyleBackColor = true;
            this.ckbFiyat.Click += new System.EventHandler(this.ckbFiyat_Click);
            // 
            // gbArabalar
            // 
            this.gbArabalar.Controls.Add(this.tableLayoutPanel1);
            this.gbArabalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbArabalar.Location = new System.Drawing.Point(0, 0);
            this.gbArabalar.Name = "gbArabalar";
            this.gbArabalar.Size = new System.Drawing.Size(800, 340);
            this.gbArabalar.TabIndex = 2;
            this.gbArabalar.TabStop = false;
            this.gbArabalar.Text = "Arabalar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbAudi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBMW, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHonda, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDefaultAraba, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbMercedes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAudi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBMW, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbHonda, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbDefaultAraba, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbMercedes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 297);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbAudi
            // 
            this.lbAudi.AutoSize = true;
            this.lbAudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAudi.Location = new System.Drawing.Point(125, 79);
            this.lbAudi.Margin = new System.Windows.Forms.Padding(125, 20, 3, 0);
            this.lbAudi.Name = "lbAudi";
            this.lbAudi.Size = new System.Drawing.Size(45, 20);
            this.lbAudi.TabIndex = 0;
            this.lbAudi.Text = "Audi";
            // 
            // lbBMW
            // 
            this.lbBMW.AutoSize = true;
            this.lbBMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBMW.Location = new System.Drawing.Point(125, 138);
            this.lbBMW.Margin = new System.Windows.Forms.Padding(125, 20, 3, 0);
            this.lbBMW.Name = "lbBMW";
            this.lbBMW.Size = new System.Drawing.Size(51, 20);
            this.lbBMW.TabIndex = 0;
            this.lbBMW.Text = "BMW";
            // 
            // lbHonda
            // 
            this.lbHonda.AutoSize = true;
            this.lbHonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHonda.Location = new System.Drawing.Point(125, 197);
            this.lbHonda.Margin = new System.Windows.Forms.Padding(125, 20, 3, 0);
            this.lbHonda.Name = "lbHonda";
            this.lbHonda.Size = new System.Drawing.Size(62, 20);
            this.lbHonda.TabIndex = 0;
            this.lbHonda.Text = "Honda";
            // 
            // lbDefaultAraba
            // 
            this.lbDefaultAraba.AutoSize = true;
            this.lbDefaultAraba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDefaultAraba.Location = new System.Drawing.Point(125, 256);
            this.lbDefaultAraba.Margin = new System.Windows.Forms.Padding(125, 20, 3, 0);
            this.lbDefaultAraba.Name = "lbDefaultAraba";
            this.lbDefaultAraba.Size = new System.Drawing.Size(105, 20);
            this.lbDefaultAraba.TabIndex = 0;
            this.lbDefaultAraba.Text = "Volkswagen";
            // 
            // cmbMercedes
            // 
            this.cmbMercedes.FormattingEnabled = true;
            this.cmbMercedes.Items.AddRange(new object[] {
            "CLA Serisi",
            "E Serisi",
            "Vito",
            "200 Serisi",
            "CL"});
            this.cmbMercedes.Location = new System.Drawing.Point(381, 20);
            this.cmbMercedes.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.cmbMercedes.Name = "cmbMercedes";
            this.cmbMercedes.Size = new System.Drawing.Size(237, 21);
            this.cmbMercedes.TabIndex = 1;
            // 
            // cmbAudi
            // 
            this.cmbAudi.FormattingEnabled = true;
            this.cmbAudi.Items.AddRange(new object[] {
            "Q Serisi",
            "A Serisi"});
            this.cmbAudi.Location = new System.Drawing.Point(381, 79);
            this.cmbAudi.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.cmbAudi.Name = "cmbAudi";
            this.cmbAudi.Size = new System.Drawing.Size(237, 21);
            this.cmbAudi.TabIndex = 1;
            // 
            // cmbBMW
            // 
            this.cmbBMW.FormattingEnabled = true;
            this.cmbBMW.Items.AddRange(new object[] {
            "i8",
            "X3",
            "8 Serisi",
            "5 Serisi",
            "3 Serisi"});
            this.cmbBMW.Location = new System.Drawing.Point(381, 138);
            this.cmbBMW.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.cmbBMW.Name = "cmbBMW";
            this.cmbBMW.Size = new System.Drawing.Size(237, 21);
            this.cmbBMW.TabIndex = 1;
            // 
            // cmbHonda
            // 
            this.cmbHonda.FormattingEnabled = true;
            this.cmbHonda.Items.AddRange(new object[] {
            "Civic",
            "Jazz",
            "City",
            "Accord",
            "CR-V"});
            this.cmbHonda.Location = new System.Drawing.Point(381, 197);
            this.cmbHonda.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.cmbHonda.Name = "cmbHonda";
            this.cmbHonda.Size = new System.Drawing.Size(237, 21);
            this.cmbHonda.TabIndex = 1;
            // 
            // cmbDefaultAraba
            // 
            this.cmbDefaultAraba.FormattingEnabled = true;
            this.cmbDefaultAraba.Items.AddRange(new object[] {
            "Polo",
            "Golf",
            "Passat",
            "Tiguan",
            "Caddy"});
            this.cmbDefaultAraba.Location = new System.Drawing.Point(381, 256);
            this.cmbDefaultAraba.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.cmbDefaultAraba.Name = "cmbDefaultAraba";
            this.cmbDefaultAraba.Size = new System.Drawing.Size(237, 21);
            this.cmbDefaultAraba.TabIndex = 1;
            // 
            // lbMercedes
            // 
            this.lbMercedes.AutoSize = true;
            this.lbMercedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMercedes.Location = new System.Drawing.Point(125, 20);
            this.lbMercedes.Margin = new System.Windows.Forms.Padding(125, 20, 3, 0);
            this.lbMercedes.Name = "lbMercedes";
            this.lbMercedes.Size = new System.Drawing.Size(87, 20);
            this.lbMercedes.TabIndex = 0;
            this.lbMercedes.Text = "Mercedes";
            // 
            // ckbDefault
            // 
            this.ckbDefault.AutoSize = true;
            this.ckbDefault.Location = new System.Drawing.Point(99, 415);
            this.ckbDefault.Name = "ckbDefault";
            this.ckbDefault.Size = new System.Drawing.Size(51, 17);
            this.ckbDefault.TabIndex = 0;
            this.ckbDefault.Text = "Sıfırla";
            this.ckbDefault.UseVisualStyleBackColor = true;
            this.ckbDefault.Click += new System.EventHandler(this.cbDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbArabalar);
            this.Controls.Add(this.ckbFiyat);
            this.Controls.Add(this.ckbPerformans);
            this.Controls.Add(this.ckbDefault);
            this.Controls.Add(this.ckbCevre);
            this.Name = "Form1";
            this.Text = "Homework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbArabalar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbCevre;
        private System.Windows.Forms.CheckBox ckbPerformans;
        private System.Windows.Forms.CheckBox ckbFiyat;
        private System.Windows.Forms.GroupBox gbArabalar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbMercedes;
        private System.Windows.Forms.Label lbAudi;
        private System.Windows.Forms.Label lbBMW;
        private System.Windows.Forms.Label lbHonda;
        private System.Windows.Forms.Label lbDefaultAraba;
        private System.Windows.Forms.ComboBox cmbMercedes;
        private System.Windows.Forms.ComboBox cmbAudi;
        private System.Windows.Forms.ComboBox cmbBMW;
        private System.Windows.Forms.ComboBox cmbHonda;
        private System.Windows.Forms.ComboBox cmbDefaultAraba;
        private System.Windows.Forms.CheckBox ckbDefault;
    }
}

