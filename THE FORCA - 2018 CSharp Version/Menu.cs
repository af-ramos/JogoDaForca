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
    public partial class Menu : Form
    {   
       
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var forca = new Jogo(textBox1.Text, textBox2.Text, textBox3.Text);
            forca.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            textBox1.Focus();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dialog = MessageBox.Show("Você quer realmente sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                this.Hide();
            }
            else if(dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            */
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
