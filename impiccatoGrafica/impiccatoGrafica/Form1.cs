namespace impiccatoGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btng_Click(object sender, EventArgs e)
        {
            string[,] matrice = new string[7, 50];
            string path = "Nomi.txt",riga="";
            string[] parole = new string[50];
            Random rdn= new Random();   
            StreamReader sr = new StreamReader(path);
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                riga= sr.ReadLine();
                parole = riga.Split(",");
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = parole[j];
                }
            }
            string parola = matrice[rdn.Next(0, matrice.GetLength(0)),rdn.Next(1, matrice.GetLength(1))];
            char[] parolaTrasf = new char[parola.Length];
            for (int i = 0; i < parolaTrasf.Length; i++)
            {
                parolaTrasf[i] = '_';
            }

            lblP.Text = new string(parolaTrasf);
        }
    }
}
