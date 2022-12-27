using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_FORCA___2018_CSharp_Version
{
    public partial class Ganhar : Form
    {
        public string palavra;
        public Ganhar()
        {
            InitializeComponent();
        }

        public Ganhar(string palavra)
        {
            InitializeComponent();
            this.palavra = palavra;
            label2.Text = this.palavra.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void Ganhar_Load(object sender, EventArgs e)
        {

        }
    }
}
