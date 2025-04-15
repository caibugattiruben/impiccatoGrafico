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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            lblINDIZI = new Label();
            btnr = new Button();
            label8 = new Label();
            lboxI = new ListBox();
            btnIndizio = new Button();
            btnjolly = new Button();
            lboxl = new ListBox();
            lboxp = new ListBox();
            label2 = new Label();
            label9 = new Label();
            lblt = new Label();
            lblInd = new Label();
            pbox = new PictureBox();
            label10 = new Label();
            lbldesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // btnI
            // 
            btnI.Anchor = AnchorStyles.None;
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
            tbox1.Anchor = AnchorStyles.None;
            tbox1.Location = new Point(522, 446);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(100, 23);
            tbox1.TabIndex = 1;
            tbox1.Visible = false;
            // 
            // btng
            // 
            btng.Anchor = AnchorStyles.None;
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
            lblP.Anchor = AnchorStyles.None;
            lblP.BackColor = Color.LightCyan;
            lblP.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblP.Location = new Point(483, 369);
            lblP.Name = "lblP";
            lblP.Size = new Size(165, 43);
            lblP.TabIndex = 3;
            lblP.TextAlign = ContentAlignment.MiddleCenter;
            lblP.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(511, 258);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Tema:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Location = new Point(455, 446);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "INSERISCI:";
            label4.Visible = false;
            // 
            // btns
            // 
            btns.Anchor = AnchorStyles.None;
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
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(511, 262);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 11;
            label1.Text = "Difficoltà";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(29, 111);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Monete:";
            // 
            // lblm
            // 
            lblm.Anchor = AnchorStyles.None;
            lblm.AutoSize = true;
            lblm.Location = new Point(96, 115);
            lblm.Name = "lblm";
            lblm.Size = new Size(0, 15);
            lblm.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(29, 87);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "Vite";
            // 
            // lblv
            // 
            lblv.Anchor = AnchorStyles.None;
            lblv.AutoSize = true;
            lblv.Location = new Point(104, 87);
            lblv.Name = "lblv";
            lblv.Size = new Size(0, 15);
            lblv.TabIndex = 16;
            // 
            // prova
            // 
            prova.Anchor = AnchorStyles.None;
            prova.AutoSize = true;
            prova.Location = new Point(401, 381);
            prova.Name = "prova";
            prova.Size = new Size(54, 15);
            prova.TabIndex = 17;
            prova.Text = "PAROLA:";
            prova.Visible = false;
            // 
            // cboxT
            // 
            cboxT.Anchor = AnchorStyles.None;
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
            cboxD.Anchor = AnchorStyles.None;
            cboxD.FormattingEnabled = true;
            cboxD.Items.AddRange(new object[] { "Facile", "Medio", "Difficile", "Impossibile" });
            cboxD.Location = new Point(511, 280);
            cboxD.Name = "cboxD";
            cboxD.Size = new Size(121, 23);
            cboxD.TabIndex = 20;
            // 
            // btnChiudi
            // 
            btnChiudi.Anchor = AnchorStyles.None;
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
            btnCanc.Anchor = AnchorStyles.None;
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
            lblc.Anchor = AnchorStyles.None;
            lblc.AutoSize = true;
            lblc.Location = new Point(371, 422);
            lblc.Name = "lblc";
            lblc.Size = new Size(0, 15);
            lblc.TabIndex = 23;
            lblc.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(747, 446);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 24;
            label6.Text = "Lettere usate:";
            label6.Visible = false;
            // 
            // lblINDIZI
            // 
            lblINDIZI.Anchor = AnchorStyles.None;
            lblINDIZI.AutoSize = true;
            lblINDIZI.Location = new Point(23, 305);
            lblINDIZI.Name = "lblINDIZI";
            lblINDIZI.Size = new Size(52, 15);
            lblINDIZI.TabIndex = 28;
            lblINDIZI.Text = "INDIZIO:";
            lblINDIZI.Visible = false;
            // 
            // btnr
            // 
            btnr.Anchor = AnchorStyles.None;
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
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(899, 158);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 31;
            label8.Text = "Parole indovinate:";
            label8.Visible = false;
            // 
            // lboxI
            // 
            lboxI.Anchor = AnchorStyles.None;
            lboxI.FormattingEnabled = true;
            lboxI.ItemHeight = 15;
            lboxI.Items.AddRange(new object[] { "Prima Lettera (10 monete)", "Ultima Lettera (5 monete)", "Tema della parola (15 monete)", "Prima e ultima lettera (15 monete)", "Descrizione parola (25 monete)" });
            lboxI.Location = new Point(81, 305);
            lboxI.Name = "lboxI";
            lboxI.Size = new Size(191, 79);
            lboxI.TabIndex = 33;
            lboxI.Visible = false;
            // 
            // btnIndizio
            // 
            btnIndizio.Anchor = AnchorStyles.None;
            btnIndizio.Location = new Point(122, 390);
            btnIndizio.Name = "btnIndizio";
            btnIndizio.Size = new Size(101, 34);
            btnIndizio.TabIndex = 34;
            btnIndizio.Text = "SCEGLI INDIZIO";
            btnIndizio.UseVisualStyleBackColor = true;
            btnIndizio.Visible = false;
            btnIndizio.Click += btnIndizio_Click;
            // 
            // btnjolly
            // 
            btnjolly.Anchor = AnchorStyles.None;
            btnjolly.Location = new Point(728, 384);
            btnjolly.Name = "btnjolly";
            btnjolly.Size = new Size(109, 40);
            btnjolly.TabIndex = 35;
            btnjolly.Text = "LETTERA JOLLY";
            btnjolly.UseVisualStyleBackColor = true;
            btnjolly.Visible = false;
            btnjolly.Click += btnjolly_Click;
            // 
            // lboxl
            // 
            lboxl.Anchor = AnchorStyles.None;
            lboxl.FormattingEnabled = true;
            lboxl.ItemHeight = 15;
            lboxl.Location = new Point(830, 446);
            lboxl.Name = "lboxl";
            lboxl.Size = new Size(171, 94);
            lboxl.TabIndex = 36;
            lboxl.Visible = false;
            // 
            // lboxp
            // 
            lboxp.Anchor = AnchorStyles.None;
            lboxp.FormattingEnabled = true;
            lboxp.ItemHeight = 15;
            lboxp.Location = new Point(899, 184);
            lboxp.Name = "lboxp";
            lboxp.Size = new Size(201, 154);
            lboxp.TabIndex = 37;
            lboxp.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Old English Text MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 9);
            label2.Name = "label2";
            label2.Size = new Size(425, 79);
            label2.TabIndex = 38;
            label2.Text = "IMPICCATO";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(22, 222);
            label9.Name = "label9";
            label9.Size = new Size(39, 21);
            label9.TabIndex = 39;
            label9.Text = "TEMA:";
            label9.UseCompatibleTextRendering = true;
            label9.Visible = false;
            // 
            // lblt
            // 
            lblt.Anchor = AnchorStyles.None;
            lblt.AutoSize = true;
            lblt.Location = new Point(68, 222);
            lblt.Name = "lblt";
            lblt.Size = new Size(0, 18);
            lblt.TabIndex = 40;
            lblt.UseCompatibleTextRendering = true;
            // 
            // lblInd
            // 
            lblInd.Anchor = AnchorStyles.None;
            lblInd.AutoSize = true;
            lblInd.Location = new Point(20, 446);
            lblInd.Name = "lblInd";
            lblInd.Size = new Size(0, 15);
            lblInd.TabIndex = 41;
            // 
            // pbox
            // 
            pbox.Anchor = AnchorStyles.None;
            pbox.Location = new Point(421, 91);
            pbox.Name = "pbox";
            pbox.Size = new Size(315, 266);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 42;
            pbox.TabStop = false;
            pbox.Visible = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(22, 243);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 43;
            label10.Text = "DESCIZIONE:";
            label10.UseCompatibleTextRendering = true;
            label10.Visible = false;
            // 
            // lbldesc
            // 
            lbldesc.Anchor = AnchorStyles.None;
            lbldesc.AutoSize = true;
            lbldesc.Location = new Point(96, 243);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(0, 18);
            lbldesc.TabIndex = 44;
            lbldesc.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 650);
            Controls.Add(lbldesc);
            Controls.Add(label10);
            Controls.Add(pbox);
            Controls.Add(lblInd);
            Controls.Add(lblt);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(lboxp);
            Controls.Add(lboxl);
            Controls.Add(btnjolly);
            Controls.Add(btnIndizio);
            Controls.Add(lboxI);
            Controls.Add(label8);
            Controls.Add(btnr);
            Controls.Add(lblINDIZI);
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
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
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
        private Label lblINDIZI;
        private Button btnr;
        private Label label7;
        private Label label8;
        private ListBox lboxI;
        private Button btnIndizio;
        private Button btnjolly;
        private ListBox lboxl;
        private ListBox lboxp;
        private Label label2;
        private Label label9;
        private Label lblt;
        private Label lblInd;
        private PictureBox pbox;
        private Label label10;
        private Label lbldesc;
    }
}
