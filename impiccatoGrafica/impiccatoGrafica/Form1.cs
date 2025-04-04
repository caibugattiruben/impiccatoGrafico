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
        bool chiudere = false;
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
            cboxT.Visible = false;
            label3.Visible = false;
            btng.Visible = false;
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

        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            tbox1.Text = "";
        }

        private void btnAz_Click(object sender, EventArgs e)
        {
            azione = cboxa.SelectedItem.ToString().ToLower();

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            switch (azione)
            {
                case "dire una lettera":
                    string lettera = tbox1.Text.ToString().ToLower();
                    if (lettera.Length > 1)
                    {
                        lblc.Text = "NON E' UNA LETTERA SINGOLA SE VUOI PROVARE LA PAROLA SELEZIONA INDOVINA LA PAROLA";
                    }
                    else
                    {
                        if (parola.Contains(lettera))
                        {
                            lblc.Text = "LA PAROLA CONTIENE LA LETTERA";
                            for (int i = 0; i < parolaTrasf.Length; i++)
                            {
                                if (lettera[0] == parola[i])
                                {
                                    parolaTrasf[i] = lettera[0];
                                }
                            }
                            lblP.Text = new string(parolaTrasf);
                        }
                        else
                        {
                            lblc.Text = "LA PAROLA NON CONTIENE LA LETTERA";
                            lblu.Text += lettera + ", ";
                        }
                    }
                    break;
                case "dire un indizio":
                    
                    int n = rdn.Next(1,4);
                    
                    break;
                case "lettera jolly":
                    if (jolly == 1)
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
                    }
                    else
                    {
                        lblc.Text = "NON HAI LETTERE JOLLY A DISPOSIZIONE";
                    }

                        break;
                case "indovina la parola":
                    lblc.Text = "Indovina la parola:";
                    string parola1=tbox1.Text.ToString().ToLower();
                    if (parola1.Length == parola.Length)
                    {
                        if (parola1 == parola)
                        {
                            lblc.Text = "HAI INDOVINATO LA PAROLA";
                            for(int i = 0; i < parolaTrasf.Length; i++)
                            {
                                parolaTrasf [i] = parola[i];
                            }
                            lblP.Text = new string(parolaTrasf);
                        }
                        else
                        {
                            lblc.Text = "NON HAI INDOVINATO LA PAROLA";
                            int v=int.Parse(lblv.Text)-1;
                            lblv.Text = v.ToString();
                        }
                    }
                    else if (parola1.Length > parola.Length)
                    {
                        lblc.Text = "LA PAROLA E' TROPPO LUNGA";
                    }
                    else
                    {
                        lblc.Text = "LA PAROLA E' TROPPO CORTA";
                    }
                    
                    break;
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
