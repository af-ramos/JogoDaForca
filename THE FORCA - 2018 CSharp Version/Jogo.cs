using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace THE_FORCA___2018_CSharp_Version
{
    public partial class Jogo : Form
    {
        public string[] palavradescobrir;
        public string palavrajogo;
        public int quantidadeletras;
        public char[] palavravetor;
        public int erronormal = 0, errojogo = 0, tentativas = 6;
        public Jogo()
        {
            InitializeComponent();

        }

        public Jogo(string nome, string dica, string palavra)
        {
            InitializeComponent();
            pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca0;
            label4.Text = nome;
            label2.Text = dica;
            palavrajogo = palavra.ToUpper();

            quantidadeletras = palavrajogo.Length;

            palavravetor = new char[100];
            palavradescobrir = new string[100];

            for(int i=0; i<quantidadeletras; i++)
            {
                palavradescobrir[i] = "_";
            }

            label5.Text = string.Join(" ", palavradescobrir);

            palavravetor = palavrajogo.ToCharArray();

            /*foreach (char valor in palavravetor)
            {
                MessageBox.Show(valor.ToString());
            }*/
        }

        private void Jogo_Load(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'A')
                {
                    palavradescobrir[i] = "A";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonA.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'B')
                {
                    palavradescobrir[i] = "B";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonB.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'C')
                {
                    palavradescobrir[i] = "C";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonC.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'D')
                {
                    palavradescobrir[i] = "D";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonD.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'E')
                {
                    palavradescobrir[i] = "E";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonE.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'F')
                {
                    palavradescobrir[i] = "F";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonF.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'G')
                {
                    palavradescobrir[i] = "G";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonG.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'H')
                {
                    palavradescobrir[i] = "H";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonH.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'I')
                {
                    palavradescobrir[i] = "I";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonI.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'J')
                {
                    palavradescobrir[i] = "J";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonJ.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'K')
                {
                    palavradescobrir[i] = "K";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonK.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'L')
                {
                    palavradescobrir[i] = "L";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonL.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'M')
                {
                    palavradescobrir[i] = "M";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonM.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'N')
                {
                    palavradescobrir[i] = "N";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonN.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'O')
                {
                    palavradescobrir[i] = "O";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonO.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'P')
                {
                    palavradescobrir[i] = "P";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonP.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'Q')
                {
                    palavradescobrir[i] = "Q";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            label8.Text = tentativas.ToString();
            buttonQ.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'R')
                {
                    palavradescobrir[i] = "R";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonR.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'S')
                {
                    palavradescobrir[i] = "S";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonS.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'T')
                {
                    palavradescobrir[i] = "T";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonT.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'U')
                {
                    palavradescobrir[i] = "U";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonU.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'V')
                {
                    palavradescobrir[i] = "V";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonV.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'X')
                {
                    palavradescobrir[i] = "X";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonX.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'W')
                {
                    palavradescobrir[i] = "W";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonW.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'Y')
                {
                    palavradescobrir[i] = "Y";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonY.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            erronormal = 0;
            for (int i = 0; i < quantidadeletras; i++)
            {
                if (palavravetor[i] == 'Z')
                {
                    palavradescobrir[i] = "Z";
                }
                else
                {
                    erronormal++;
                }
            }
            label5.Text = string.Join(" ", palavradescobrir);
            buttonZ.Enabled = false;
            Ganhar();
            Perder();
            Tentativa();
            label8.Text = tentativas.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Ganhar()
        {
            Ganhar ganhar = new Ganhar(palavrajogo);
                if(string.Join("",palavradescobrir) == palavrajogo)
                {
                this.Hide();
                ganhar.ShowDialog();
                this.Close();
                }
        }
        
        public void Perder()
        {
            if(erronormal == quantidadeletras)
            {
                errojogo++;
            }

            if (errojogo == 1)
            {
                pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca1;
            }

            if (errojogo == 2)
            {
                pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca2;
            }

            if (errojogo == 3)
            {
                pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca3;
            }

            if (errojogo == 4)
            {
                pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca4;
            }

            if (errojogo == 5)
            {
                pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca5;
            }

            if (errojogo == 6)
            {
                pictureBox1.Image = THE_FORCA___2018_CSharp_Version.Properties.Resources.forca6;
                this.Hide();
                Perder perder = new Perder(palavrajogo);
                perder.ShowDialog();
                this.Close();
            }
        }
        public void Tentativa()
        {
            if (erronormal == quantidadeletras)
            {
                tentativas--;
            }
        }

    }
}
