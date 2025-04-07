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
            label2 = new Label();
            label3 = new Label();
            btnAz = new Button();
            label4 = new Label();
            btns = new Button();
            label1 = new Label();
            label5 = new Label();
            lblm = new Label();
            label7 = new Label();
            lblv = new Label();
            prova = new Label();
            cboxT = new ComboBox();
            cboxa = new ComboBox();
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
            SuspendLayout();
            // 
            // btnI
            // 
            btnI.Location = new Point(555, 289);
            btnI.Name = "btnI";
            btnI.Size = new Size(75, 23);
            btnI.TabIndex = 0;
            btnI.Text = "INVIA";
            btnI.UseVisualStyleBackColor = true;
            btnI.Click += btnI_Click;
            // 
            // tbox1
            // 
            tbox1.Location = new Point(555, 250);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(100, 23);
            tbox1.TabIndex = 1;
            // 
            // btng
            // 
            btng.Location = new Point(907, 154);
            btng.Name = "btng";
            btng.Size = new Size(126, 23);
            btng.TabIndex = 2;
            btng.Text = "Genera la parola";
            btng.UseVisualStyleBackColor = true;
            btng.Click += btng_Click;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Location = new Point(574, 211);
            lblP.Name = "lblP";
            lblP.Size = new Size(0, 15);
            lblP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 253);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "AZIONE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(907, 111);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Tema:";
            // 
            // btnAz
            // 
            btnAz.Location = new Point(308, 302);
            btnAz.Name = "btnAz";
            btnAz.Size = new Size(75, 23);
            btnAz.TabIndex = 7;
            btnAz.Text = "INVIA";
            btnAz.UseVisualStyleBackColor = true;
            btnAz.Click += btnAz_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 250);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "INSERISCI:";
            // 
            // btns
            // 
            btns.Location = new Point(12, 132);
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
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 11;
            label1.Text = "Difficoltà";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 177);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Monete:";
            // 
            // lblm
            // 
            lblm.AutoSize = true;
            lblm.Location = new Point(76, 177);
            lblm.Name = "lblm";
            lblm.Size = new Size(0, 15);
            lblm.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 111);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "Vite";
            // 
            // lblv
            // 
            lblv.AutoSize = true;
            lblv.Location = new Point(257, 107);
            lblv.Name = "lblv";
            lblv.Size = new Size(0, 15);
            lblv.TabIndex = 16;
            // 
            // prova
            // 
            prova.AutoSize = true;
            prova.Location = new Point(495, 211);
            prova.Name = "prova";
            prova.Size = new Size(54, 15);
            prova.TabIndex = 17;
            prova.Text = "PAROLA:";
            // 
            // cboxT
            // 
            cboxT.FormattingEnabled = true;
            cboxT.Items.AddRange(new object[] { "Niente", "Calcio", "Verbi", "Frutta e verdura", "Animali", "Nazioni", "Lavori", "Città" });
            cboxT.Location = new Point(907, 129);
            cboxT.Name = "cboxT";
            cboxT.Size = new Size(121, 23);
            cboxT.TabIndex = 18;
            // 
            // cboxa
            // 
            cboxa.FormattingEnabled = true;
            cboxa.Items.AddRange(new object[] { "Dire una lettera", "Indizio", "Lettera Jolly", "Indovina la parola" });
            cboxa.Location = new Point(283, 273);
            cboxa.Name = "cboxa";
            cboxa.Size = new Size(121, 23);
            cboxa.TabIndex = 19;
            // 
            // cboxD
            // 
            cboxD.FormattingEnabled = true;
            cboxD.Items.AddRange(new object[] { "Facile", "Medio", "Difficile", "Impossibile" });
            cboxD.Location = new Point(12, 107);
            cboxD.Name = "cboxD";
            cboxD.Size = new Size(121, 23);
            cboxD.TabIndex = 20;
            // 
            // btnChiudi
            // 
            btnChiudi.Location = new Point(984, 533);
            btnChiudi.Name = "btnChiudi";
            btnChiudi.Size = new Size(75, 43);
            btnChiudi.TabIndex = 21;
            btnChiudi.Text = "Chiudere";
            btnChiudi.UseVisualStyleBackColor = true;
            btnChiudi.Click += btnChiudi_Click;
            // 
            // btnCanc
            // 
            btnCanc.Location = new Point(679, 250);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(47, 40);
            btnCanc.TabIndex = 22;
            btnCanc.Text = "AC";
            btnCanc.UseVisualStyleBackColor = true;
            btnCanc.Click += btnCanc_Click;
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Location = new Point(308, 162);
            lblc.Name = "lblc";
            lblc.Size = new Size(0, 15);
            lblc.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(909, 217);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 24;
            label6.Text = "Lettere usate:";
            // 
            // lblu
            // 
            lblu.AutoSize = true;
            lblu.Location = new Point(915, 238);
            lblu.Name = "lblu";
            lblu.Size = new Size(0, 15);
            lblu.TabIndex = 25;
            // 
            // parolaP
            // 
            parolaP.AutoSize = true;
            parolaP.Location = new Point(502, 177);
            parolaP.Name = "parolaP";
            parolaP.Size = new Size(47, 15);
            parolaP.TabIndex = 26;
            parolaP.Text = "parolaP";
            // 
            // lblINDIZI
            // 
            lblINDIZI.AutoSize = true;
            lblINDIZI.Location = new Point(459, 389);
            lblINDIZI.Name = "lblINDIZI";
            lblINDIZI.Size = new Size(52, 15);
            lblINDIZI.TabIndex = 28;
            lblINDIZI.Text = "INDIZIO:";
            // 
            // lblIndizio
            // 
            lblIndizio.AutoSize = true;
            lblIndizio.Location = new Point(511, 369);
            lblIndizio.Name = "lblIndizio";
            lblIndizio.Size = new Size(0, 15);
            lblIndizio.TabIndex = 29;
            // 
            // btnr
            // 
            btnr.Location = new Point(502, 318);
            btnr.Name = "btnr";
            btnr.Size = new Size(137, 58);
            btnr.TabIndex = 30;
            btnr.Text = "Riavvia";
            btnr.UseVisualStyleBackColor = true;
            btnr.Visible = false;
            btnr.Click += btnr_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(844, 293);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 31;
            label8.Text = "Parole indovinate:";
            // 
            // lblPindov
            // 
            lblPindov.AutoSize = true;
            lblPindov.Location = new Point(844, 310);
            lblPindov.Name = "lblPindov";
            lblPindov.Size = new Size(0, 15);
            lblPindov.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 650);
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
            Controls.Add(cboxa);
            Controls.Add(cboxT);
            Controls.Add(prova);
            Controls.Add(lblv);
            Controls.Add(label7);
            Controls.Add(lblm);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btns);
            Controls.Add(label4);
            Controls.Add(btnAz);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Button btnAz;
        private Label label4;
        private Button btns;
        private Label label1;
        private Label label5;
        private Label lblm;
        private Label lblv;
        private Label prova;
        private ComboBox cboxT;
        private ComboBox cboxa;
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
    }
}
