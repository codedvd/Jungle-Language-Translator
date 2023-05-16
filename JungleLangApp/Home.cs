using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JungleLangApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toJungle jung = new toJungle();
            jung.Show();
            this.Hide();
        }

        private void Translator_Load(object sender, EventArgs e)
        {

        }

        private void fromJung_Click(object sender, EventArgs e)
        {
            fromJungle fjung = new fromJungle();
            fjung.Show();
            this.Hide();
        }
    }
}
