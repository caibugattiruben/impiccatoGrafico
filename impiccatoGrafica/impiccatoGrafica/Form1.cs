using System.DirectoryServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace impiccatoGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string parola, tema, descrizione = "";
        char[] parolaTrasf;
        Random rdn = new Random();
        bool chiudere = false, indovinato = false;
        int jolly = 1;
        int[] poss = new int[5];
        string[] pathdiff = null;
        private void btng_Click(object sender, EventArgs e)
        {

            string[,] matrice = new string[7, 50];
            string[,] matrice1 = new string[7, 50];
            string path = "Nomi.txt", riga = "", pathDesc = "descrizioni.txt";
            string[] parole = new string[50];
            Random rdn = new Random();
            StreamReader sr = new StreamReader(path);
            StreamReader sr1 = new StreamReader(pathDesc);
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                riga = sr.ReadLine();
                if (riga != null)
                {
                    parole = riga.Split(",");
                    for (int j = 0; j < matrice.GetLength(1); j++)
                    {
                        matrice[i, j] = parole[j];
                    }
                }

            }
            parole = null;
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                riga = sr1.ReadLine();
                if (riga != null)
                {
                    parole = riga.Split(",");
                    for (int j = 0; j < matrice.GetLength(1); j++)
                    {
                        matrice1[i, j] = parole[j];


                    }
                }

            }
            tema = cboxT.SelectedItem.ToString().ToLower();
            int indice = 0;
            int colonna = rdn.Next(1, matrice.GetLength(1));
            if (tema == "niente")
            {
                int nume = rdn.Next(0, matrice.GetLength(0));
                parola = matrice[nume, colonna];
                tema = matrice[nume, 0];
                descrizione = matrice1[nume, colonna];
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
                parola = matrice[indice, colonna];
                descrizione = matrice1[indice, colonna];
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
            pbox.Visible = true;
            for (int i = 0; i < poss.Length; i++)
            {
                poss[i] = 0;
            }

        }
        private void btns_Click(object sender, EventArgs e)
        {
            string difficol = cboxD.SelectedItem.ToString().ToUpper();
            switch (difficol)
            {
                case "FACILE":
                    pathdiff = ["Immagine0.png", "Immagine1.png", "Immagine2.png", "Immagine3.png", "Immagine4.png", "Immagine5.png", "Immagine6.png", "Immagine7.png", "Immagine8.png", "Immagine9.png"];
                    lblm.Text = "30";
                    lblv.Text = "10";
                    break;
                case "MEDIO":
                    pathdiff = ["Immagine0.png", "Immagine1.png", "Immagine2.png", "Immagine3.png", "Immagine4.png", "Immagine5.png"];
                    lblm.Text = "20";
                    lblv.Text = "5";
                    break;
                case "DIFFICILE":
                    pathdiff = ["Immagine0.png", "Imma" +
                        "ine1.png", "Immagine2.png", "Immagine3.png"];
                    lblm.Text = "10";
                    lblv.Text = "3";
                    break;
                case "IMPOSSIBILE":
                    pathdiff = ["Immagine0.png", "Immagine1.png"];
                    lblm.Text = "5";
                    lblv.Text = "1";
                    break;
            }
            pbox.Image = Image.FromFile("Immagine0.png");
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
            int tentativi = 0;
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
                            lblm.Text = (int.Parse(lblm.Text) + 5).ToString();
                        }
                    }
                }
                else
                {
                    lblc.Text = "LA PAROLA NON CONTIENE LA LETTERA";
                    tentativi++;
                    lblv.Text = (int.Parse(lblv.Text) - 1).ToString();
                    pbox.Image = Image.FromFile(pathdiff[tentativi]);
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
                    tentativi++;
                    pbox.Image = Image.FromFile(pathdiff[tentativi]);
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
                btnChiudi.Visible = true;
                lblc.Visible = true;
                btnr.Visible = true;
                if (vita <= 0)
                {
                    lblc.Text = "Non hai indovinato la parola!!!";
                    pbox.Visible = false;
                }
                else
                {
                    lblc.Text = "Hai indovinato la parola!!!";
                    lboxp.Items.Add(parola);
                    pbox.Visible = false;
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
            lbldesc.Text = "";
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
            int monete = int.Parse(lblm.Text);
            string scelto = lboxI.SelectedItem.ToString();
            switch (scelto)
            {
                case "Prima Lettera (10 monete)":
                    if (monete >= 10 && poss[0] != 1)
                    {
                        poss[0] = 1;
                        parolaTrasf[0] = parola[0];
                        lblm.Text = (int.Parse(lblm.Text) - 10).ToString();
                    }
                    else
                    {
                        lblInd.Text = "NON HAI ABBASTANZA MONETE OPPURE HAI GIà USATO QUESTO INDIZIO";
                    }
                    break;
                case "Ultima Lettera (5 monete)":
                    if (monete >= 5 && poss[1] != 1)
                    {
                        poss[1] = 1;
                        parolaTrasf[parola.Length - 1] = parola[parola.Length - 1];
                        lblm.Text = (int.Parse(lblm.Text) - 5).ToString();
                    }
                    else
                    {
                        lblInd.Text = "NON HAI ABBASTANZA MONETE OPPURE HAI GIà USATO QUESTO INDIZIO";
                    }
                    break;
                case "Tema della parola (15 monete)":
                    if (monete >= 15 && poss[2] != 1)
                    {
                        poss[2] = 1;
                        lblt.Text = tema;
                        lblm.Text = (int.Parse(lblm.Text) - 15).ToString();
                    }
                    else
                    {
                        lblInd.Text = "NON HAI ABBASTANZA MONETE OPPURE HAI GIà USATO QUESTO INDIZIO";
                    }
                    break;
                case "Prima e ultima lettera (15 monete)":
                    if (monete >= 15 && poss[3] != 1)
                    {
                        poss[3] = 1;
                        parolaTrasf[0] = parola[0];
                        parolaTrasf[parola.Length - 1] = parola[parola.Length - 1];
                        lblm.Text = (int.Parse(lblm.Text) - 15).ToString();
                    }
                    else
                    {
                        lblInd.Text = "NON HAI ABBASTANZA MONETE OPPURE HAI GIà USATO QUESTO INDIZIO";
                    }
                    break;
                case "Descrizione parola (25 monete)":
                    if (monete >= 25 && poss[4] != 1)
                    {
                        poss[4] = 1;
                        lbldesc.Text = descrizione;
                        lblm.Text = (int.Parse(lblm.Text) - 25).ToString();
                    }
                    else
                    {
                        lblInd.Text = "NON HAI ABBASTANZA MONETE OPPURE HAI GIà USATO QUESTO INDIZIO";
                    }
                    break;
            }
            lblP.Text = new string(parolaTrasf);
        }

       
    }
}
