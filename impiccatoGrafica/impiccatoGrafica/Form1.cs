using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace impiccatoGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string parola, tema, azione;
        char[] parolaTrasf;
        Random rdn = new Random();
        bool chiudere = false, indovinato = false;
        int jolly = 1;

        private void btng_Click(object sender, EventArgs e)
        {

            string[,] matrice = new string[7, 50];
            string path = "Nomi.txt", riga = "";
            string[] parole = new string[50];
            Random rdn = new Random();
            StreamReader sr = new StreamReader(path);
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                riga = sr.ReadLine();
                parole = riga.Split(",");
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = parole[j];
                }
            }
            tema = cboxT.SelectedItem.ToString().ToLower();
            int indice = 0;
            if (tema == "niente")
            {
                parola = matrice[rdn.Next(0, matrice.GetLength(0)), rdn.Next(1, matrice.GetLength(1))];
            }
            else
            {
                for (int i = 0; i < matrice.GetLength(0); i++)
                {
                    if (tema == matrice[i, 0])
                    {
                        indice = i;
                    }
                }
                parola = matrice[indice, rdn.Next(1, matrice.GetLength(1))];
            }
            parolaP.Text = parola;
            parolaTrasf = new char[parola.Length];
            for (int i = 0; i < parolaTrasf.Length; i++)
            {
                if (parola[i] == ' ')
                {
                    parolaTrasf[i] = ' ';
                }
                else
                {
                    parolaTrasf[i] = '_';
                }

            }

            lblP.Text = new string(parolaTrasf);
            foreach (Control elementi in this.Controls)
            {
                elementi.Visible = true;
            }

            label1.Visible = false;
            cboxD.Visible = false;
            btns.Visible = false;
            cboxT.Visible = false;
            label3.Visible = false;
            btng.Visible = false;
            btnr.Visible = false;

        }
        private void btns_Click(object sender, EventArgs e)
        {
            string difficol = cboxD.SelectedItem.ToString().ToUpper();
            switch (difficol)
            {
                case "FACILE":
                    lblm.Text = "30";
                    lblv.Text = "10";
                    break;
                case "MEDIO":
                    lblm.Text = "20";
                    lblv.Text = "5";
                    break;
                case "DIFFICILE":
                    lblm.Text = "10";
                    lblv.Text = "3";
                    break;
                case "IMPOSSIBILE":
                    lblm.Text = "5";
                    lblv.Text = "1";
                    break;
            }
            label1.Visible = false;
            cboxD.Visible = false;
            btns.Visible = false;
            cboxT.Visible = true;
            label3.Visible = true;
            btng.Visible = true;

        }
        private void btnCanc_Click(object sender, EventArgs e)
        {
            tbox1.Text = "";
        }
        private void btnI_Click(object sender, EventArgs e)
        {
            string lettera = tbox1.Text.ToString().ToLower();
            tbox1.Text = "";
            //LETTERA OK
            if (lettera.Length == 1)
            {
                if (parola.Contains(lettera))
                {
                    lblc.Text = "LA PAROLA CONTIENE LA LETTERA";
                    for (int i = 0; i < parola.Length; i++)
                    {
                        if (lettera[0] == parola[i])
                        {
                            parolaTrasf[i] = parola[i];
                        }
                    }
                }
                else
                {
                    lblc.Text = "LA PAROLA NON CONTIENE LA LETTERA";
                    lblv.Text = (int.Parse(lblv.Text) - 1).ToString();
                }
                lblP.Text = new string(parolaTrasf);
                lboxl.Items.Add(lettera);
            }
            else if (lettera.Length == parola.Length)
            {
                if (parola == lettera)
                {
                    for (int i = 0; i < parolaTrasf.Length; i++)
                    {
                        parolaTrasf[i] = parola[i];
                    }
                }
                else
                {
                    lblv.Text = (int.Parse(lblv.Text) - 1).ToString();
                    lblc.Text = "LA PAROLA DA TE PROVATA NON E' CORRETTA";
                }
            }
            else
            {
                lblc.Text = "IL TESTO SCRITTO DA TE NON RAPPRESENTA NE UNA LETTERA DA PROVARE NE UNA PAROLA DA PROVARE";
            }
            int vita = int.Parse(lblv.Text);
            if (!new string(parolaTrasf).Contains('_') || vita <= 0)
            {
                foreach (Control cose in this.Controls)
                {
                    cose.Visible = false;
                }
                lboxp.Items.Add(parola);
                btnChiudi.Visible = true;
                lblc.Visible = true;
                btnr.Visible = true;
                if (vita <= 0)
                {
                    lblc.Text = "Non hai indovinato la parola!!!";
                }
                else
                {
                    lblc.Text = "Hai indovinato la parola!!!";
                }
            }
        }
        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnr_Click(object sender, EventArgs e)
        {
            btnChiudi.Visible = true;
            btnjolly.Enabled = true;
            lblv.Text = "";
            lblm.Text = "";
            lblP.Text = "";
            lblc.Text = "";
            lboxl.Items.Clear();
            foreach (Control cose in this.Controls)
            {
                if (cose is TextBox)
                {
                    ((TextBox)cose).Clear();
                }
                else if (cose is ComboBox)
                {
                    ((ComboBox)cose).SelectedIndex = -1;
                }
            }
            lblc.Text = "";
            foreach (Control elementi in this.Controls)
            {
                elementi.Visible = false;
            }
            label7.Visible = true;
            label5.Visible = true;
            lblv.Visible = true;
            lblm.Visible = true;
            label1.Visible = true;
            cboxD.Visible = true;
            btns.Visible = true;
            btnChiudi.Visible = true;
        }
        private void btnjolly_Click(object sender, EventArgs e)
        {

            int pos = rdn.Next(1, parola.Length - 1);
            bool esci = false;
            while (esci == false)
            {
                if (parolaTrasf[pos] == '_')
                {
                    parolaTrasf[pos] = parola[pos];
                    esci = true;
                }
                else
                {
                    pos = rdn.Next(1, parola.Length - 1);
                }

            }
            lblP.Text = new string(parolaTrasf);
            btnjolly.Enabled = false;


        }
        private void btnIndizio_Click(object sender, EventArgs e)
        {
            int monete = int.Parse(lblv.Text);

        }
    }
}
