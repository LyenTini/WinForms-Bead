namespace WindowsForms1810
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Adatok = new System.Windows.Forms.ListBox();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetolt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSzuldatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioFerfi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUjhobbi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // Adatok
            // 
            this.Adatok.FormattingEnabled = true;
            this.Adatok.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.Adatok.Location = new System.Drawing.Point(65, 32);
            this.Adatok.Name = "Adatok";
            this.Adatok.Size = new System.Drawing.Size(108, 121);
            this.Adatok.TabIndex = 1;
            this.Adatok.SelectedIndexChanged += new System.EventHandler(this.Hobbik_SelectedIndexChanged);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(331, 359);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 2;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetolt
            // 
            this.buttonBetolt.Location = new System.Drawing.Point(203, 359);
            this.buttonBetolt.Name = "buttonBetolt";
            this.buttonBetolt.Size = new System.Drawing.Size(75, 23);
            this.buttonBetolt.TabIndex = 3;
            this.buttonBetolt.Text = "Betöltés";
            this.buttonBetolt.UseVisualStyleBackColor = true;
            this.buttonBetolt.Click += new System.EventHandler(this.buttonBetolt_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(431, 258);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 4;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            this.buttonHozzaad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonMentes_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Szül. dátum: ";
            // 
            // tbSzuldatum
            // 
            this.tbSzuldatum.Location = new System.Drawing.Point(82, 62);
            this.tbSzuldatum.Name = "tbSzuldatum";
            this.tbSzuldatum.Size = new System.Drawing.Size(155, 20);
            this.tbSzuldatum.TabIndex = 6;
            this.tbSzuldatum.TextChanged += new System.EventHandler(this.tbSzuldatum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nem: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNev);
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Controls.Add(this.radioFerfi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSzuldatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regisztráció";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(82, 29);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(155, 20);
            this.tbNev.TabIndex = 10;
            this.tbNev.TextChanged += new System.EventHandler(this.tbNev_TextChanged);
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(134, 92);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 9;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Nő";
            this.radioNo.UseVisualStyleBackColor = true;
            this.radioNo.CheckedChanged += new System.EventHandler(this.radioNo_CheckedChanged);
            // 
            // radioFerfi
            // 
            this.radioFerfi.AutoSize = true;
            this.radioFerfi.Location = new System.Drawing.Point(83, 92);
            this.radioFerfi.Name = "radioFerfi";
            this.radioFerfi.Size = new System.Drawing.Size(45, 17);
            this.radioFerfi.TabIndex = 8;
            this.radioFerfi.TabStop = true;
            this.radioFerfi.Text = "Férfi";
            this.radioFerfi.UseVisualStyleBackColor = true;
            this.radioFerfi.CheckedChanged += new System.EventHandler(this.radioFerfi_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUjhobbi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Adatok);
            this.groupBox2.Location = new System.Drawing.Point(347, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 214);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobbik";
            // 
            // tbUjhobbi
            // 
            this.tbUjhobbi.Location = new System.Drawing.Point(54, 170);
            this.tbUjhobbi.Name = "tbUjhobbi";
            this.tbUjhobbi.Size = new System.Drawing.Size(130, 20);
            this.tbUjhobbi.TabIndex = 3;
            this.tbUjhobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btUjhobbi);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Új hobbi: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Információ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.buttonBetolt);
            this.Controls.Add(this.buttonMentes);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox Adatok;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetolt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSzuldatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFerfi;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUjhobbi;
        private System.Windows.Forms.TextBox tbNev;
    }
}

