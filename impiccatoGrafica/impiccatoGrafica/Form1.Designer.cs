namespace impiccatoGrafica
{
    partial class Form1
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
            btnI = new Button();
            tbox1 = new TextBox();
            btng = new Button();
            lblP = new Label();
            label3 = new Label();
            label4 = new Label();
            btns = new Button();
            label1 = new Label();
            label5 = new Label();
            lblm = new Label();
            label7 = new Label();
            lblv = new Label();
            prova = new Label();
            cboxT = new ComboBox();
            cboxD = new ComboBox();
            btnChiudi = new Button();
            btnCanc = new Button();
            lblc = new Label();
            label6 = new Label();
            lblu = new Label();
            parolaP = new Label();
            lblINDIZI = new Label();
            lblIndizio = new Label();
            btnr = new Button();
            label8 = new Label();
            lblPindov = new Label();
            listBox1 = new ListBox();
            btnIndizio = new Button();
            btnjolly = new Button();
            SuspendLayout();
            // 
            // btnI
            // 
            btnI.Location = new Point(522, 485);
            btnI.Name = "btnI";
            btnI.Size = new Size(75, 23);
            btnI.TabIndex = 0;
            btnI.Text = "INVIA";
            btnI.UseVisualStyleBackColor = true;
            btnI.Visible = false;
            btnI.Click += btnI_Click;
            // 
            // tbox1
            // 
            tbox1.Location = new Point(522, 446);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(100, 23);
            tbox1.TabIndex = 1;
            tbox1.Visible = false;
            // 
            // btng
            // 
            btng.Location = new Point(511, 301);
            btng.Name = "btng";
            btng.Size = new Size(126, 23);
            btng.TabIndex = 2;
            btng.Text = "Genera la parola";
            btng.UseVisualStyleBackColor = true;
            btng.Visible = false;
            btng.Click += btng_Click;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Location = new Point(504, 349);
            lblP.Name = "lblP";
            lblP.Size = new Size(0, 15);
            lblP.TabIndex = 3;
            lblP.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 258);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Tema:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 446);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "INSERISCI:";
            label4.Visible = false;
            // 
            // btns
            // 
            btns.Location = new Point(511, 305);
            btns.Name = "btns";
            btns.Size = new Size(75, 23);
            btns.TabIndex = 10;
            btns.Text = "scegli";
            btns.UseVisualStyleBackColor = true;
            btns.Click += btns_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 262);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 11;
            label1.Text = "Difficoltà";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 111);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Monete:";
            // 
            // lblm
            // 
            lblm.AutoSize = true;
            lblm.Location = new Point(96, 115);
            lblm.Name = "lblm";
            lblm.Size = new Size(0, 15);
            lblm.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 87);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "Vite";
            // 
            // lblv
            // 
            lblv.AutoSize = true;
            lblv.Location = new Point(104, 87);
            lblv.Name = "lblv";
            lblv.Size = new Size(0, 15);
            lblv.TabIndex = 16;
            // 
            // prova
            // 
            prova.AutoSize = true;
            prova.Location = new Point(425, 349);
            prova.Name = "prova";
            prova.Size = new Size(54, 15);
            prova.TabIndex = 17;
            prova.Text = "PAROLA:";
            prova.Visible = false;
            // 
            // cboxT
            // 
            cboxT.FormattingEnabled = true;
            cboxT.Items.AddRange(new object[] { "Niente", "Calcio", "Verbi", "Frutta e verdura", "Animali", "Nazioni", "Lavori", "Città" });
            cboxT.Location = new Point(511, 276);
            cboxT.Name = "cboxT";
            cboxT.Size = new Size(121, 23);
            cboxT.TabIndex = 18;
            cboxT.Visible = false;
            // 
            // cboxD
            // 
            cboxD.FormattingEnabled = true;
            cboxD.Items.AddRange(new object[] { "Facile", "Medio", "Difficile", "Impossibile" });
            cboxD.Location = new Point(511, 280);
            cboxD.Name = "cboxD";
            cboxD.Size = new Size(121, 23);
            cboxD.TabIndex = 20;
            // 
            // btnChiudi
            // 
            btnChiudi.Location = new Point(1025, 29);
            btnChiudi.Name = "btnChiudi";
            btnChiudi.Size = new Size(75, 43);
            btnChiudi.TabIndex = 21;
            btnChiudi.Text = "Chiudere";
            btnChiudi.UseVisualStyleBackColor = true;
            btnChiudi.Click += btnChiudi_Click;
            // 
            // btnCanc
            // 
            btnCanc.Location = new Point(646, 446);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(47, 40);
            btnCanc.TabIndex = 22;
            btnCanc.Text = "AC";
            btnCanc.UseVisualStyleBackColor = true;
            btnCanc.Visible = false;
            btnCanc.Click += btnCanc_Click;
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Location = new Point(542, 404);
            lblc.Name = "lblc";
            lblc.Size = new Size(0, 15);
            lblc.TabIndex = 23;
            lblc.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(887, 168);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 24;
            label6.Text = "Lettere usate:";
            label6.Visible = false;
            // 
            // lblu
            // 
            lblu.AutoSize = true;
            lblu.Location = new Point(979, 168);
            lblu.Name = "lblu";
            lblu.Size = new Size(0, 15);
            lblu.TabIndex = 25;
            lblu.Visible = false;
            // 
            // parolaP
            // 
            parolaP.AutoSize = true;
            parolaP.Location = new Point(495, 177);
            parolaP.Name = "parolaP";
            parolaP.Size = new Size(47, 15);
            parolaP.TabIndex = 26;
            parolaP.Text = "parolaP";
            parolaP.Visible = false;
            // 
            // lblINDIZI
            // 
            lblINDIZI.AutoSize = true;
            lblINDIZI.Location = new Point(804, 404);
            lblINDIZI.Name = "lblINDIZI";
            lblINDIZI.Size = new Size(52, 15);
            lblINDIZI.TabIndex = 28;
            lblINDIZI.Text = "INDIZIO:";
            lblINDIZI.Visible = false;
            // 
            // lblIndizio
            // 
            lblIndizio.AutoSize = true;
            lblIndizio.Location = new Point(511, 369);
            lblIndizio.Name = "lblIndizio";
            lblIndizio.Size = new Size(0, 15);
            lblIndizio.TabIndex = 29;
            lblIndizio.Visible = false;
            // 
            // btnr
            // 
            btnr.Location = new Point(511, 280);
            btnr.Name = "btnr";
            btnr.Size = new Size(137, 58);
            btnr.TabIndex = 30;
            btnr.Text = "Continua";
            btnr.UseVisualStyleBackColor = true;
            btnr.Visible = false;
            btnr.Click += btnr_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(887, 211);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 31;
            label8.Text = "Parole indovinate:";
            label8.Visible = false;
            // 
            // lblPindov
            // 
            lblPindov.AutoSize = true;
            lblPindov.Location = new Point(887, 228);
            lblPindov.Name = "lblPindov";
            lblPindov.Size = new Size(0, 15);
            lblPindov.TabIndex = 32;
            lblPindov.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Prima Lettera (10 monete)", "Ultima Lettera (5 monete)", "Tema della parola (15 monete)", "Prima e ultima lettera (15 monete)", "Descrizione parola (25 monete)" });
            listBox1.Location = new Point(862, 404);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 79);
            listBox1.TabIndex = 33;
            listBox1.Visible = false;
            // 
            // btnIndizio
            // 
            btnIndizio.Location = new Point(912, 489);
            btnIndizio.Name = "btnIndizio";
            btnIndizio.Size = new Size(101, 34);
            btnIndizio.TabIndex = 34;
            btnIndizio.Text = "SCEGLI INDIZIO";
            btnIndizio.UseVisualStyleBackColor = true;
            btnIndizio.Visible = false;
            // 
            // btnjolly
            // 
            btnjolly.Location = new Point(862, 336);
            btnjolly.Name = "btnjolly";
            btnjolly.Size = new Size(109, 40);
            btnjolly.TabIndex = 35;
            btnjolly.Text = "LETTERA JOLLY";
            btnjolly.UseVisualStyleBackColor = true;
            btnjolly.Visible = false;
            btnjolly.Click += btnjolly_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1136, 650);
            Controls.Add(btnjolly);
            Controls.Add(btnIndizio);
            Controls.Add(listBox1);
            Controls.Add(lblPindov);
            Controls.Add(label8);
            Controls.Add(btnr);
            Controls.Add(lblIndizio);
            Controls.Add(lblINDIZI);
            Controls.Add(parolaP);
            Controls.Add(lblu);
            Controls.Add(label6);
            Controls.Add(lblc);
            Controls.Add(btnCanc);
            Controls.Add(btnChiudi);
            Controls.Add(cboxD);
            Controls.Add(cboxT);
            Controls.Add(prova);
            Controls.Add(lblv);
            Controls.Add(label7);
            Controls.Add(lblm);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btns);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblP);
            Controls.Add(btng);
            Controls.Add(tbox1);
            Controls.Add(btnI);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnI;
        private TextBox tbox1;
        private Button btng;
        private Label lblP;
        private Label label3;
        private Label label4;
        private Button btns;
        private Label label1;
        private Label label5;
        private Label lblm;
        private Label lblv;
        private Label prova;
        private ComboBox cboxT;
        private ComboBox cboxD;
        private Button btnChiudi;
        private Button btnCanc;
        private Label lblc;
        private Label label6;
        private Label lblu;
        private Label parolaP;
        private Label lblINDIZI;
        private Label lblIndizio;
        private Button btnr;
        private Label label7;
        private Label label8;
        private Label lblPindov;
        private ListBox listBox1;
        private Button btnIndizio;
        private Button btnjolly;
    }
}
